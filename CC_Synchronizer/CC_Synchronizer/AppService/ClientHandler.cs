﻿using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AppSharedClasses;
using CC_Synchronizer.AppService.SyncDataModels;
using BackendDataHandler;
using SharedLibrary.Models;

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
        SyncDataModels.Recipe recipe = new SyncDataModels.Recipe();
        Recipe_Ingredients recipeIngredients = new Recipe_Ingredients();
        SyncDataModels.Rule rule = new SyncDataModels.Rule();
        Rule_Categories ruleCategories = new Rule_Categories();
        SyncDataModels.Shape shape = new SyncDataModels.Shape();
        BackendDataHandling bdh = new BackendDataHandling();
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
            InputDbContent();

            ClearTableLists();
            GetDbContent();
            SendBack();
            
            //For IDs of new app entries
            Recieve();
            UpdateMID();

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

        private void InputDbContent()
        {
            Customer cust;
            Ingredient ingr;
            IngredientCategory ic;
            Order order;
            OrderItem oi;
            Product prod;
            SharedLibrary.Models.Recipe rec;
            Package pack;
            ReciepeIngredients ri;
            SharedLibrary.Models.Rule rule;
            RuleCategory rc;
            SharedLibrary.Models.Shape shape;

            if (productInfo.TableList.Count > 0)
            {
                foreach (var item in productInfo.TableList)
                {
                    prod = new Product();

                    if (item.BackendID == null)
                    {
                        //Create Product_ID?

                        if (item.ProduktID != null)
                            prod.Manufaturer_ID = item.ProduktID;

                        prod.Product_Name = item.Name;
                        prod.Product_Description = item.Description;
                        prod.Category = item.Category;
                        prod.Product_Avail = item.Availability;
                        prod.List_Price = (decimal?)item.ListPrice;

                        if (item.SalePrice != null)
                            prod.Sale_Price = (decimal?)item.SalePrice;

                        if (item.SaleBegin != null)
                            prod.Sale_Begin = item.SaleBegin;

                        if (item.SaleEnd != null)
                            prod.Sale_End = item.SaleEnd;

                        prod.Filename = item.Filename;

                        if (item.FrontEndID != null)
                            prod.Frontend_ID = item.FrontEndID;

                        bdh.AddProduct(prod);
                    }
                    else
                    {
                        prod.Product_ID = (decimal)item.BackendID;

                        if (item.ProduktID != null)
                            prod.Manufaturer_ID = item.ProduktID;

                        prod.Product_Name = item.Name;
                        prod.Product_Description = item.Description;
                        prod.Category = item.Category;
                        prod.Product_Avail = item.Availability;
                        prod.List_Price = (decimal?)item.ListPrice;

                        if (item.SalePrice != null)
                            prod.Sale_Price = (decimal?)item.SalePrice;

                        if (item.SaleBegin != null)
                            prod.Sale_Begin = item.SaleBegin;

                        if (item.SaleEnd != null)
                            prod.Sale_End = item.SaleEnd;

                        prod.Filename = item.Filename;

                        if (item.FrontEndID != null)
                            prod.Frontend_ID = item.FrontEndID;

                        bdh.UpdateProduct(prod, "MANUFACTURER");
                    }
                }
            }

            if (customers.TableList.Count > 0)
            {
                foreach (var item in customers.TableList)
                {
                    cust = new Customer();

                    if (item.BackendID == null)
                    {
                        //Create Customer_ID

                        cust.FirstName = item.FirstName;
                        cust.LastName = item.LastName;
                        cust.Address = item.StreetAdress1;
                        cust.City = item.City;
                        cust.State = item.State;
                        cust.Zip = item.PostalCode;
                        cust.Email = item.Email;
                        cust.PhoneNumber = item.PhoneNumber1;
                        //cust.Url = "";

                        if (item.CreditLimit != null)
                            cust.CreditLimit = item.CreditLimit;

                        //cust.Tags = "";

                        if (item.Lastmodified != null)
                            cust.Last_Updated = item.Lastmodified;

                        if (item.Customer_ID != null)
                            cust.Manufaturer_ID = item.Customer_ID;

                        if (item.FrontEndID != null)
                            cust.Frontend_ID = item.FrontEndID;

                        bdh.AddCustomer(cust);
                    }
                    else
                    {
                        cust.CustomerId = (decimal)item.BackendID;
                        cust.FirstName = item.FirstName;
                        cust.LastName = item.LastName;
                        cust.Address = item.StreetAdress1;
                        cust.City = item.City;
                        cust.State = item.State;
                        cust.Zip = item.PostalCode;
                        cust.Email = item.Email;
                        cust.PhoneNumber = item.PhoneNumber1;
                        //cust.Url = "";

                        if (item.CreditLimit != null)
                            cust.CreditLimit = item.CreditLimit;

                        //cust.Tags = "";

                        if (item.Lastmodified != null)
                            cust.Last_Updated = item.Lastmodified;

                        if (item.Customer_ID != null)
                            cust.Manufaturer_ID = item.Customer_ID;

                        if (item.FrontEndID != null)
                            cust.Frontend_ID = item.FrontEndID;

                        bdh.UpdateCustomer(cust, "MANUFACTURER");
                    }
                }
            }

            if (ingredientCategory.TableList.Count > 0)
            {
                foreach (var item in ingredientCategory.TableList)
                {
                    ic = new IngredientCategory();

                    if (item.BackendID == null)
                    {
                        //Create ICID

                        ic.Name = item.Name;

                        if (item.Id != null)
                            ic.ManufacturerID = item.Id;

                        if (item.FrontEndID != null)
                            ic.FrontendID = item.FrontEndID;

                        bdh.AddIngredientCategory(ic);
                    }
                    else
                    {
                        ic.ICID = (decimal)item.BackendID;
                        ic.Name = item.Name;

                        if (item.Id != null)
                            ic.ManufacturerID = item.Id;

                        if (item.FrontEndID != null)
                            ic.FrontendID = item.FrontEndID;

                        bdh.UpdateIngredientsCategory(ic);
                    }
                }
            }

            if (ingredients.TableList.Count > 0)
            {
                foreach (var item in ingredients.TableList)
                {
                    ingr = new Ingredient();

                    if (item.BackendID == null)
                    {
                        //Create IID

                        ingr.Price = (decimal)item.Price;
                        //ingr.Filename = "";
                        //ingr.MIMETYPE = "";
                        //ingr.Ingredient_Image = null;
                        ingr.Description = item.Description;
                        ingr.Location_Top = item.LocationTop;
                        ingr.Location_Bottom = item.LocationBottom;
                        ingr.Location_Choc = item.LocationChoc;
                        ingr.Name = item.Name;
                        ingr.Quantity = item.Quantity;
                        ingr.CategoryId = bdh.GetIngredientCategoryBID(item.CategoryId);

                        if (item.Id != null)
                            ingr.ManufacturerID = item.Id;

                        if (item.FrontEndID != null)
                            ingr.FrontendID = item.FrontEndID;

                        bdh.AddIngredient(ingr);
                    }
                    else
                    {
                        ingr.IID = (decimal)item.BackendID;
                        ingr.Price = (decimal)item.Price;
                        //ingr.Filename = "";
                        //ingr.MIMETYPE = "";
                        //ingr.Ingredient_Image = null;
                        ingr.Description = item.Description;
                        ingr.Location_Top = item.LocationTop;
                        ingr.Location_Bottom = item.LocationBottom;
                        ingr.Location_Choc = item.LocationChoc;
                        ingr.Name = item.Name;
                        ingr.Quantity = item.Quantity;
                        ingr.CategoryId = bdh.GetIngredientCategoryBID(item.CategoryId);

                        if (item.Id != null)
                            ingr.ManufacturerID = item.Id;

                        if (item.FrontEndID != null)
                            ingr.FrontendID = item.FrontEndID;

                        bdh.UpdateIngredients(ingr);
                    }
                }
            }

            if (orders.TableList.Count > 0)
            {
                foreach (var item in orders.TableList)
                {
                    order = new Order();

                    if (item.BackendID==null)
                    {
                        //Create Order_ID

                        order.CustomerID = bdh.GetOrderBID(item.CustomerID);
                        order.OrderTotal = (decimal?)item.OrderTotal;
                        order.OrderTimeStamp = item.OrderTimeStamp;
                        order.UserName = item.UserName;

                        if (item.OrdersID != null)
                            order.Manufaturer_ID = item.OrdersID;

                        if (item.FrontEndID != null)
                            order.Frontend_ID = item.FrontEndID;

                        bdh.AddOrder(order);
                    }
                    else
                    {
                        //ToDo: UpdateOrder?
                    }
                }
            }

            if(orderItems.TableList.Count>0)
            {
                foreach (var item in orderItems.TableList)
                {
                    oi = new OrderItem();
                    if(item.BackendID==null)
                    {
                        //Create Order_Item_ID
                        oi.OrderID = bdh.GetOrderBID(item.OrderID);
                        oi.ProductID = bdh.GetProductBID(item.ProductID);
                        oi.UnitPrice = (decimal)item.UnitPrice;
                        oi.Quantity = (int)item.Quantity;

                        if (item.OrderID != null)
                            oi.ManufacturerID = item.OrderID;

                        if (item.FrontEndID != null)
                            oi.FrontEndID = item.FrontEndID;

                        bdh.AddOrderItem(oi);
                    }
                    else
                    {
                        //ToDo: UpdateOrderItem?
                    }
                }
            }

            if (recipe.TableList.Count>0)
            {
                foreach (var item in recipe.TableList)
                {
                    rec = new SharedLibrary.Models.Recipe();
                    if(item.BackendID==null)
                    {
                        //Create ID
                        rec.ProductID = bdh.GetProductBID(item.ProductId);
                        rec.Description = item.Description;

                        if (item.Id != null)
                            rec.ManufacturerID = item.Id;

                        if (item.FrontEndID != null)
                            rec.FrontendID = item.FrontEndID;

                        bdh.AddRecipe(rec);
                    }
                    else
                    {
                        rec.RID = (decimal)item.BackendID;
                        rec.ProductID = bdh.GetProductBID(item.ProductId);
                        rec.Description = item.Description;

                        if (item.Id != null)
                            rec.ManufacturerID = item.Id;

                        if (item.FrontEndID != null)
                            rec.FrontendID = item.FrontEndID;

                        bdh.UpdateRecipe(rec, "MANUFACTURER");
                    }
                }
            }
        }

        private void GetDbContent()
        {
            foreach (var i in bdh.QueryAllProductsByLastUpdatedForManufacturer())
            {
                productInfo.Add(new ShProductInfo((int?)i.Manufaturer_ID, i.Product_Name, i.Product_Description, i.Category, i.Product_Avail, (float)i.List_Price, (float?)i.Sale_Price, i.Sale_Begin, i.Sale_End, null, (int?)i.Product_ID, (int?)i.Frontend_ID, null, i.Filename));
            }

            foreach (var i in bdh.QueryAllCustomersByLastUpdatedForManufacturer())
            {
                customers.Add(new ShCustomers((int?)i.Manufaturer_ID, i.FirstName, i.LastName, i.Address, "", i.City, i.State, i.Zip, i.Email, i.PhoneNumber, "", (int?)i.CreditLimit, (int?)i.CustomerId, (int?)i.Frontend_ID, null));
            }
        }

        private void UpdateMID()
        {
            foreach (var item in productInfo.TableList)
            {
                bdh.UpdateProductMID((decimal)item.BackendID, item.ProduktID, "MANUFACTURER");
            }
            
            foreach (var item in customers.TableList)
            {
                bdh.UpdateCustomerMID((decimal)item.BackendID, item.Customer_ID, "MANUFACTURER");
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
