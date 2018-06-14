using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using AppSharedClasses;
using CC_Synchronizer.AppService.SyncDataModels;

namespace CC_Synchronizer.AppService
{
    public class ClientHandler
    {
        Socket socket;
        byte[] buffer = new byte[2];

        public ClientHandler(Socket socket)
        {
            this.socket = socket;

            Console.WriteLine(DateTime.Now.ToString() + ": App Client connected from " + socket.RemoteEndPoint.ToString());
            Task.Factory.StartNew(TestRecieve);
        }

        private void TestRecieve()
        {
            int length = 0;
            string recievedString = "";
            int TableId = 0;

            while(TableId < 12.5)
            {
                length = socket.Receive(buffer);
                recievedString = Encoding.ASCII.GetString(buffer, 0, length);

                if (buffer.Length == 2)
                {
                    buffer = new byte[10];
                    TableId = int.Parse(recievedString);
                    continue;
                }
                else if (10 == buffer.Length)
                {
                    buffer = new byte[int.Parse(recievedString)];
                    continue;
                }
                Console.WriteLine(recievedString);

                switch (TableId)
                {
                    case 1:     //Customer
                        Customers DeserializedCustomer = Customers.Deserialize(recievedString);
                        //returned for Testing
                        TestSend(TableId, DeserializedCustomer);
                        //save To Database maybe new Thread?
                        break;
                    case 2:     //Ingredient
                        Ingredients DeserializedIngredients = Ingredients.Deserialize(recievedString);
                        //returned for Testing
                        TestSend(TableId, DeserializedIngredients);
                        //save To Database maybe new Thread?
                        break;
                    case 3:     //Ingredient_Category
                        Ingredient_Category DeserializedIngredient_Category = Ingredient_Category.Deserialize(recievedString);
                        //returned for Testing
                        TestSend(TableId, DeserializedIngredient_Category);
                        //save To Database maybe new Thread?
                        break;
                    case 4:     //Order_Items
                        Order_Items DeserializedOrder_Items = Order_Items.Deserialize(recievedString);
                        //returned for Testing
                        TestSend(TableId, DeserializedOrder_Items);
                        //save To Database maybe new Thread?
                        break;
                    case 5:     //Orders
                        Orders DeserializedOrders = Orders.Deserialize(recievedString);
                        //returned for Testing
                        TestSend(TableId, DeserializedOrders);
                        //save To Database maybe new Thread?
                        break;
                    case 6:     //Packages
                        Packages DeserializedPackages = Packages.Deserialize(recievedString);
                        //returned for Testing
                        TestSend(TableId, DeserializedPackages);
                        //save To Database maybe new Thread?
                        break;
                    case 7:     //Product_Info
                        Product_Info DeserializedProductInfo = Product_Info.Deserialize(recievedString);
                        //returned for Testing
                        TestSend(TableId, DeserializedProductInfo);
                        //save To Database maybe new Thread?
                        break;
                    case 8:     //Recipe
                        Recipe DeserializedRecipe = Recipe.Deserialize(recievedString);
                        //returned for Testing
                        TestSend(TableId, DeserializedRecipe);
                        //save To Database maybe new Thread?
                        break;
                    case 9:     //RecipeIngredients
                        Recipe_Ingredients DeserializedRecipeIngredients = Recipe_Ingredients.Deserialize(recievedString);
                        //returned for Testing
                        TestSend(TableId, DeserializedRecipeIngredients);
                        //save To Database maybe new Thread?
                        break;
                    case 10:    //Rule
                        Rule DeserializedRule = Rule.Deserialize(recievedString);
                        //returned for Testing
                        TestSend(TableId, DeserializedRule);
                        //save To Database maybe new Thread?
                        break;
                    case 11:    //Rule_Categories
                        Rule_Categories DeserializedRuleCategories = Rule_Categories.Deserialize(recievedString);
                        //returned for Testing
                        TestSend(TableId, DeserializedRuleCategories);
                        //save To Database maybe new Thread?
                        break;
                    case 12:    //Shape
                        Shape DeserializedShape = Shape.Deserialize(recievedString);
                        //returned for Testing
                        TestSend(TableId, DeserializedShape);
                        //save To Database maybe new Thread?
                        break;
                    default:
                        break;
                }

                if(TableId < 12.5)
                    buffer = new byte[2];
            }
        }

        private void TestSend<T>(int tableId, T deserializedDataModel)
        {
            string tableIdString = tableId.ToString();
            socket.Send(Encoding.UTF8.GetBytes(tableIdString));

            var serializerDataModel = new SyncXMLSerializer<T>();
            string returnString = serializerDataModel.Serializer(deserializedDataModel);
            int stringLength = returnString.Length;
            string stringBytes = stringLength.ToString();

            for (int i = stringBytes.Length; i < 10; i++)
            {
                stringBytes = "0" + stringBytes;
            }

            socket.Send(Encoding.UTF8.GetBytes(stringBytes));
            socket.Send(Encoding.UTF8.GetBytes(returnString));
            Console.WriteLine("String "+tableIdString+" returned");
        }
    }
}
