using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AppSharedClasses;
using CC_Synchronizer.AppService.SyncDataModels;

namespace CC_Synchronizer.AppService
{
    public class ClientHandler
    {
        Socket socket;
        Customers customers = new Customers();
        Ingredients ingredients = new Ingredients();
        Ingredient_Category ingredientCategory = new Ingredient_Category();
        Order_Items orderItems = new Order_Items();
        Orders orders = new Orders();
        Packages packages = new Packages();
        Product_Info productInfo = new Product_Info();
        Recipe recipe = new Recipe();
        Recipe_Ingredients recipeIngredients = new Recipe_Ingredients();
        Rule rule = new Rule();
        Rule_Categories ruleCategories = new Rule_Categories();
        Shape shape = new Shape();
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
            //Get new data from BE?
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
            ShCustomers customerLine;
            ShIngredient ingredientLine;
            ShIngredientCategory ingredientCategoryLine;
            ShOrderItems orderItemLine;
            ShOrders orderLine;
            ShPackage packageLine;
            ShProductInfo productInfoLine;
            ShRecipe recipeLine;
            ShRecipeIngredients recipeIngredientLine;
            ShRule ruleLine;
            ShRuleCategories ruleCategoryLine;
            ShShape shapeLine;
            
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
                        customerLine = customerXmlSerializer.Deserialize(recievedString);
                        //Console.WriteLine("Customer XML Deserialized");
                        customers.Add(customerLine);
                        //Console.WriteLine("Customer recieved");
                        break;
                    case 2:     //Ingredient
                        ingredientLine = ingredientXmlSerializer.Deserialize(recievedString);
                        ingredients.Add(ingredientLine);
                        break;
                    case 3:     //Ingredient_Category
                        ingredientCategoryLine = ingredientCategoryXmlSerializer.Deserialize(recievedString);
                        //Console.WriteLine("IC XML Deserialized");
                        ingredientCategory.Add(ingredientCategoryLine);
                        //Console.WriteLine("Customer recieved");
                        break;
                    case 4:     //Order_Items
                        orderItemLine = orderItemXmlSerializer.Deserialize(recievedString);
                        orderItems.Add(orderItemLine);
                        break;
                    case 5:     //Orders
                        orderLine = orderXmlSerializer.Deserialize(recievedString);
                        orders.Add(orderLine);
                        break;
                    case 6:     //Packages
                        packageLine = packageXmlSerializer.Deserialize(recievedString);
                        packages.Add(packageLine);
                        break;
                    case 7:     //Product_Info
                        productInfoLine = productInfoXmlSerializer.Deserialize(recievedString);
                        productInfo.Add(productInfoLine);
                        break;
                    case 8:     //Recipe
                        recipeLine = recipeXmlSerializer.Deserialize(recievedString);
                        recipe.Add(recipeLine);
                        break;
                    case 9:     //Recipe_Ingredients
                        recipeIngredientLine = recipeIngredientsXmlSerializer.Deserialize(recievedString);
                        recipeIngredients.Add(recipeIngredientLine);
                        break;
                    case 10:    //Rule
                        ruleLine = ruleXmlSerializer.Deserialize(recievedString);
                        rule.Add(ruleLine);
                        break;
                    case 11:    //Rule_Categories
                        ruleCategoryLine = ruleCategoryXmlSerializer.Deserialize(recievedString);
                        ruleCategories.Add(ruleCategoryLine);
                        break;
                    case 12:    //Shape
                        shapeLine = shapeXmlSerializer.Deserialize(recievedString);
                        shape.Add(shapeLine);
                        break;
                    default:
                        break;
                }

                buffer = new byte[2];
            }
        }

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
