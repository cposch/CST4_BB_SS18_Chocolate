using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AppSharedClasses;
using CC_Synchronizer.AppService.SyncDataModels;
using BackendDataHandler;

namespace CC_Synchronizer.AppService
{
    public class ClientHandler
    {
        Socket socket;
        Customers customers;
        Ingredients ingredients;
        Ingredient_Category ingredientCategory;
        Order_Items orderItems;
        Orders orders;
        Packages packages;
        Product_Info productInfo;
        Recipe recipe;
        Recipe_Ingredients recipeIngredients;
        Rule rule;
        Rule_Categories ruleCategories;
        Shape shape;
        byte[] buffer = new byte[2];


        public ClientHandler(Socket socket)
        {
            this.socket = socket;

            Console.WriteLine(DateTime.Now.ToString() + " App Client connected from " + socket.RemoteEndPoint.ToString());
            Task.Factory.StartNew(Synchronization);
        }

        private void Synchronization()
        {
            ClearTableLists();
            //Console.WriteLine("Table cleared");
            Recieve();
            //Console.WriteLine("Recieving finished");
            //GetDbContent();
            //Merge
            SendBack();

            Console.WriteLine("App Client connected from " + socket.RemoteEndPoint.ToString() + " synchronized");
            //socket.Close();
        }

        private void ClearTableLists()
        {
            customers.TableList.Clear();
            ingredients.TableList.Clear();
            ingredientCategory.TableList.Clear();
            orderItems.TableList.Clear();
            orders.TableList.Clear();
            packages.TableList.Clear();
            productInfo.TableList.Clear();
            recipe.TableList.Clear();
            recipeIngredients.TableList.Clear();
            rule.TableList.Clear();
            ruleCategories.TableList.Clear();
            shape.TableList.Clear();
        }

        private void Recieve()
        {
            #region Init AppSharedClasses & SyncXMLSerializer
            customers = new Customers();
            ingredients = new Ingredients();
            ingredientCategory = new Ingredient_Category();
            orderItems = new Order_Items();
            orders = new Orders();
            packages = new Packages();
            productInfo = new Product_Info();
            recipe = new Recipe();
            recipeIngredients = new Recipe_Ingredients();
            rule = new Rule();
            ruleCategories = new Rule_Categories();
            shape = new Shape();

            SyncXMLSerializer<ShCustomers> customerXmlSerializer = new SyncXMLSerializer<ShCustomers>();
            SyncXMLSerializer<ShIngredient> ingredientXmlSerializer = new SyncXMLSerializer<ShIngredient>();
            SyncXMLSerializer<ShIngredientCategory> ingredientCategoryXmlSerializer = new SyncXMLSerializer<ShIngredientCategory>();
            SyncXMLSerializer<ShOrderItems> orderItemXmlSerializer = new SyncXMLSerializer<ShOrderItems>();
            SyncXMLSerializer<ShOrders> orderXmlSerializer = new SyncXMLSerializer<ShOrders>();
            SyncXMLSerializer<ShPackage> packageXmlSerializer = new SyncXMLSerializer<ShPackage>();
            SyncXMLSerializer<ShProductInfo> productInfoXmlSerializer = new SyncXMLSerializer<ShProductInfo>();
            SyncXMLSerializer<ShRecipe> recipeXmlSerializer = new SyncXMLSerializer<ShRecipe>();
            SyncXMLSerializer<ShRecipeIngredients> recipeIngredientsXmlSerializer = new SyncXMLSerializer<ShRecipeIngredients>();
            SyncXMLSerializer<ShRule> ruleXmlSerializer = new SyncXMLSerializer<ShRule>();
            SyncXMLSerializer<ShRuleCategories> ruleCategoryXmlSerializer = new SyncXMLSerializer<ShRuleCategories>();
            SyncXMLSerializer<ShShape> shapeXmlSerializer = new SyncXMLSerializer<ShShape>();
            #endregion

            int length = 0;
            string recievedString = "";
            int TableId = 0;
            
            while (TableId < 12.5)
            {
                length = socket.Receive(buffer);
                recievedString = Encoding.ASCII.GetString(buffer, 0, length);
                //Console.WriteLine(recievedString);

                if (buffer.Length == 2)
                {
                    buffer = new byte[10];
                    TableId = int.Parse(recievedString);
                    //Console.WriteLine("TableID: "+TableId.ToString());
                    continue;
                }
                else if (buffer.Length == 10)
                {
                    buffer = new byte[int.Parse(recievedString)];
                    continue;
                }

                switch (TableId)
                {
                    case 1:     //Customer
                        //Console.WriteLine("Customer XML Deserialized");
                        customers.Add(customerXmlSerializer.Deserialize(recievedString));
                        //Console.WriteLine("Customer recieved");
                        break;
                    case 2:     //Ingredient
                        ingredients.Add(ingredientXmlSerializer.Deserialize(recievedString));
                        break;
                    case 3:     //Ingredient_Category
                        ingredientCategory.Add(ingredientCategoryXmlSerializer.Deserialize(recievedString));
                        //Console.WriteLine("IC XML Deserialized");
                        break;
                    case 4:     //Order_Items
                        orderItems.Add(orderItemXmlSerializer.Deserialize(recievedString));
                        break;
                    case 5:     //Orders
                        orders.Add(orderXmlSerializer.Deserialize(recievedString));
                        break;
                    case 6:     //Packages
                        packages.Add(packageXmlSerializer.Deserialize(recievedString));
                        break;
                    case 7:     //Product_Info
                        productInfo.Add(productInfoXmlSerializer.Deserialize(recievedString));
                        break;
                    case 8:     //Recipe
                        recipe.Add(recipeXmlSerializer.Deserialize(recievedString));
                        break;
                    case 9:     //Recipe_Ingredients
                        recipeIngredients.Add(recipeIngredientsXmlSerializer.Deserialize(recievedString));
                        break;
                    case 10:    //Rule
                        rule.Add(ruleXmlSerializer.Deserialize(recievedString));
                        break;
                    case 11:    //Rule_Categories
                        ruleCategories.Add(ruleCategoryXmlSerializer.Deserialize(recievedString));
                        break;
                    case 12:    //Shape
                        shape.Add(shapeXmlSerializer.Deserialize(recievedString));
                        break;
                    default:
                        break;
                }

                buffer = new byte[2];
            }
        }

        //private void GetDbContent()
        //{
        //    BackendDataHandling bdh = new BackendDataHandling();

        //}

        private void SendBack()
        {
            if(customers.TableList.Count > 0)
                foreach (var item in customers.TableList)
                {
                    Send(1, item);
                }

            if (ingredients.TableList.Count > 0)
                foreach (var item in ingredients.TableList)
                {
                    Send(2, item);
                }

            if (ingredientCategory.TableList.Count > 0)
                foreach (var item in ingredientCategory.TableList)
                {
                    Send(3, item);
                }

            if (orderItems.TableList.Count > 0)
                foreach (var item in orderItems.TableList)
                {
                    Send(4, item);
                }
            
            if (orders.TableList.Count > 0)
                foreach (var item in orders.TableList)
                {
                    Send(5, item);
                }
            
            if (packages.TableList.Count > 0)
                foreach (var item in packages.TableList)
                {
                    Send(6, item);
                }
            
            if (productInfo.TableList.Count > 0)
                foreach (var item in productInfo.TableList)
                {
                    Send(7, item);
                }
            
            if (recipe.TableList.Count > 0)
                foreach (var item in recipe.TableList)
                {
                    Send(8, item);
                }
            
            if (recipeIngredients.TableList.Count > 0)
                foreach (var item in recipeIngredients.TableList)
                {
                    Send(9, item);
                }

            if (rule.TableList.Count > 0)
                foreach (var item in rule.TableList)
                {
                    Send(10, item);
                }

            if (ruleCategories.TableList.Count > 0)
                foreach (var item in ruleCategories.TableList)
                {
                    Send(11, item);
                }

            if (shape.TableList.Count > 0)
                foreach (var item in shape.TableList)
                {
                    Send(12, item);
                }

            SendEnd();
        }

        private void Send<T>(int tableId, T deserialized)
        {
            string tableIdString = tableId.ToString();
            socket.Send(Encoding.UTF8.GetBytes(tableIdString));
            //Console.WriteLine("TableID sent: " + tableIdString);
            Thread.Sleep(50);

            var serializer = new SyncXMLSerializer<T>();
            string returnString = serializer.Serializer(deserialized);
            int stringLength = returnString.Length;
            string stringBytes = stringLength.ToString();

            for (int i = stringBytes.Length; i < 10; i++)
            {
                stringBytes = "0" + stringBytes;
            }

            socket.Send(Encoding.UTF8.GetBytes(stringBytes));
            //Console.WriteLine("stringByte sent: " + stringBytes);
            Thread.Sleep(50);
            socket.Send(Encoding.UTF8.GetBytes(returnString));
            Console.WriteLine("Table " + tableIdString + " returned");
        }

        private void SendEnd()
        {
            socket.Send(Encoding.UTF8.GetBytes("13"));
        }
    }
}
