using SharedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendDataHandler
{
    public class BackendDataHandling
    {
        BackendDBEntities2 db = new BackendDBEntities2();

        //Inserts ---------------------------------------------------------------

        public void AddProduct(Product p)
        {
            DEMO_PRODUCT_INFO pt = new DEMO_PRODUCT_INFO();
            //pt.PRODUCT_ID = p.Product_ID;
            pt.PRODUCT_NAME = p.Product_Name;
            pt.PRODUCT_DESCRIPTION = p.Product_Description;
            pt.CATEGORY = p.Category;
            pt.PRODUCT_AVAIL = p.Product_Avail;
            pt.LIST_PRICE = p.List_Price;
            pt.PRODUCT_IMAGE = p.Product_Image;
            pt.MIMETYPE = p.MIMETYPE;
            pt.FILENAME = p.Filename;
            pt.IMAGE_LAST_UPDATE = p.Image_Last_Update;
            pt.TAGS = p.Tags;
            pt.SALE_PRICE = p.Sale_Price;
            pt.SALE_BEGIN = p.Sale_Begin;
            pt.SALE_END = p.Sale_End;
            pt.FRONTEND_ID = p.Frontend_ID;
            pt.MANUFACTURER_ID = p.Manufaturer_ID;
            pt.LAST_MODIFIED_DATE = p.Last_Updated;
            pt.LAST_UPDATED_BY = p.Last_Updated_By;

            db.DEMO_PRODUCT_INFO.Add(pt);
            db.SaveChanges();
        }

        public void AddCustomer(Customer c)
        {
            DEMO_CUSTOMERS ct = new DEMO_CUSTOMERS();
            ct.CUSTOMER_ID = c.CustomerId;
            ct.CUST_FIRST_NAME = c.FirstName;
            ct.CUST_LAST_NAME = c.LastName;
            ct.CUST_STREET_ADDRESS1 = c.Address;
            ct.CUST_CITY = c.City;
            ct.CUST_STATE = c.State;
            ct.CUST_POSTAL_CODE = c.Zip;
            ct.CUST_EMAIL = c.Email;
            ct.PHONE_NUMBER1 = c.PhoneNumber;
            ct.URL = c.Url;
            ct.CREDIT_LIMIT = c.CreditLimit;
            ct.TAGS = c.Tags;
            db.DEMO_CUSTOMERS.Add(ct);
            db.SaveChanges();
        }

        public void AddOrder(Order o)
        {
            DEMO_ORDERS ot = new DEMO_ORDERS();

            ot.ORDER_ID = o.OrderId;
            ot.CUSTOMER_ID = o.CustomerID;
            ot.ORDER_TOTAL = o.OrderTotal;
            ot.ORDER_TIMESTAMP = o.OrderTimeStamp;
            ot.USER_NAME = o.UserName;
            ot.TAGS = o.Tags;
            ot.FRONTEND_ID = o.Frontend_ID;
            ot.MANUFACTURER_ID = o.Manufaturer_ID;
            db.DEMO_ORDERS.Add(ot);
            db.SaveChanges();
        }

        public void AddOrderItem(OrderItem oi)
        {
            DEMO_ORDER_ITEMS oit = new DEMO_ORDER_ITEMS();
            oit.ORDER_ITEM_ID = oi.OrderItemID;
            oit.ORDER_ID = oi.OrderID;
            oit.PRODUCT_ID = oi.ProductID;
            oit.UNIT_PRICE = oi.UnitPrice;
            oit.QUANTITY = oi.Quantity;
            oit.MANUFACTURER_ID = oi.ManufacturerID;
            oit.FRONTEND_ID = oi.FrontEndID;
            db.DEMO_ORDER_ITEMS.Add(oit);
            db.SaveChanges();
        }

        public void AddRecipe(Recipe r)
        {
            RECIEPE rt = new RECIEPE();
            rt.ID = r.RID;
            rt.PRODUCT_ID = r.ProductID;
            rt.DESCRIPTION = r.Description;
            rt.FRONTEND_ID = r.FrontendID;
            rt.MANUFACTURER_ID = r.ManufacturerID;
            rt.LAST_UPDATED_BY = r.Last_Updated_By;
            rt.LAST_MODIFIED_DATE = r.Last_Updated;
            db.SaveChanges();
        }


        public void AddIngredient (Ingredient I)
        {
            INGREDIENT it = new INGREDIENT();
            it.ID = I.IID;
            it.PRICE = I.Price;
            it.FILENAME = I.Filename;
            it.MIMETYPE = I.MIMETYPE;
            it.INGREDIENT_IMAGE = I.Ingredient_Image;
            it.DESCRIPTION = I.Description;
            it.LOCATION_TOP = I.Location_Top;
            it.LOCATION_BOTTOM = I.Location_Bottom;
            it.LOCATION_CHOC = I.Location_Choc;
            it.CATEGORY_ID = I.CategoryId;
            it.NAME = I.Name;
            it.QUANTITY = I.Quantity;
            it.IMAGE_LAST_UPDATE = I.Image_Last_Update;
            it.FRONTEND_ID = I.FrontendID;
            it.MANUFACTURER_ID = I.ManufacturerID;
            db.SaveChanges();
        }


        //QueryALL -------------------------------------------------------------

        public List<Product> QueryAllProducts()
        {
            return db.DEMO_PRODUCT_INFO.Select(w => new Product()
            {
                Product_ID = w.PRODUCT_ID,
                Product_Name = w.PRODUCT_NAME,
                Product_Description = w.PRODUCT_DESCRIPTION,
                Category = w.CATEGORY,
                Product_Avail = w.PRODUCT_AVAIL,
                List_Price = w.LIST_PRICE,
                Product_Image = w.PRODUCT_IMAGE,
                MIMETYPE = w.MIMETYPE,
                Filename = w.FILENAME,
                Image_Last_Update = w.IMAGE_LAST_UPDATE,
                Tags = w.TAGS,
                Sale_Price = w.SALE_PRICE,
                Sale_Begin = w.SALE_BEGIN,
                Sale_End = w.SALE_END,
                Frontend_ID = w.FRONTEND_ID,
                Manufaturer_ID = w.MANUFACTURER_ID,
                Last_Updated = w.LAST_MODIFIED_DATE,
                Last_Updated_By = w.LAST_UPDATED_BY

            }).ToList();
        }

        public List<Product> QueryAllProductsbyFID(decimal? FID)
        {
            return db.DEMO_PRODUCT_INFO.Where(w => w.FRONTEND_ID.Equals(FID)).Select(w => new Product()
            {
                Product_ID = w.PRODUCT_ID,
                Product_Name = w.PRODUCT_NAME,
                Product_Description = w.PRODUCT_DESCRIPTION,
                Category = w.CATEGORY,
                Product_Avail = w.PRODUCT_AVAIL,
                List_Price = w.LIST_PRICE,
                Product_Image = w.PRODUCT_IMAGE,
                MIMETYPE = w.MIMETYPE,
                Filename = w.FILENAME,
                Image_Last_Update = w.IMAGE_LAST_UPDATE,
                Tags = w.TAGS,
                Sale_Price = w.SALE_PRICE,
                Sale_Begin = w.SALE_BEGIN,
                Sale_End = w.SALE_END,
                Frontend_ID = w.FRONTEND_ID,
                Manufaturer_ID = w.MANUFACTURER_ID,
                Last_Updated = w.LAST_MODIFIED_DATE,
                Last_Updated_By = w.LAST_UPDATED_BY
            }).ToList();
        }

        public List<Product> QueryAllProductsbyMID(decimal? MID)
        {
            return db.DEMO_PRODUCT_INFO.Where(w => w.MANUFACTURER_ID.Equals(MID)).Select(w => new Product()
            {
                Product_ID = w.PRODUCT_ID,
                Product_Name = w.PRODUCT_NAME,
                Product_Description = w.PRODUCT_DESCRIPTION,
                Category = w.CATEGORY,
                Product_Avail = w.PRODUCT_AVAIL,
                List_Price = w.LIST_PRICE,
                Product_Image = w.PRODUCT_IMAGE,
                MIMETYPE = w.MIMETYPE,
                Filename = w.FILENAME,
                Image_Last_Update = w.IMAGE_LAST_UPDATE,
                Tags = w.TAGS,
                Sale_Price = w.SALE_PRICE,
                Sale_Begin = w.SALE_BEGIN,
                Sale_End = w.SALE_END,
                Frontend_ID = w.FRONTEND_ID,
                Manufaturer_ID = w.MANUFACTURER_ID,
                Last_Updated = w.LAST_MODIFIED_DATE,
                Last_Updated_By = w.LAST_UPDATED_BY
            }).ToList();
        }

        public List<Product> QueryAllProductsbyLastUpdatedByFrontend()
        {
            var date = (from p in db.LAST_SYNCHED
                        where p.ID == 1
                        select p.FRONTEND_LAST_SYNCHED).FirstOrDefault();

            UpdateProductsFrontendLastSynchedDate();
            return db.DEMO_PRODUCT_INFO.Where(w => !w.FRONTEND_ID.Equals(null) && date < w.LAST_MODIFIED_DATE && !w.LAST_UPDATED_BY.Equals("FRONTEND")).Select(w => new Product()
            {
                Product_ID = w.PRODUCT_ID,
                Product_Name = w.PRODUCT_NAME,
                Product_Description = w.PRODUCT_DESCRIPTION,
                Category = w.CATEGORY,
                Product_Avail = w.PRODUCT_AVAIL,
                List_Price = w.LIST_PRICE,
                Product_Image = w.PRODUCT_IMAGE,
                MIMETYPE = w.MIMETYPE,
                Filename = w.FILENAME,
                Image_Last_Update = w.IMAGE_LAST_UPDATE,
                Tags = w.TAGS,
                Sale_Price = w.SALE_PRICE,
                Sale_Begin = w.SALE_BEGIN,
                Sale_End = w.SALE_END,
                Frontend_ID = w.FRONTEND_ID,
                Manufaturer_ID = w.MANUFACTURER_ID,
                Last_Updated = w.LAST_MODIFIED_DATE,
                Last_Updated_By = w.LAST_UPDATED_BY
            }).ToList();
        }

        public List<Product> QueryAllProductsbyLastUpdatedByManufacturer()
        {
            var date = (from p in db.LAST_SYNCHED
                        where p.ID == 1
                        select p.MANUFACTURER_LAST_SYNCHED).FirstOrDefault();
            UpdateProductsManufacturerLastSynchedDate();
            return db.DEMO_PRODUCT_INFO.Where(w => !w.MANUFACTURER_ID.Equals(null) && date < w.LAST_MODIFIED_DATE && !w.LAST_UPDATED_BY.Equals("MANUFACTURER")).Select(w => new Product()
            {
                Product_ID = w.PRODUCT_ID,
                Product_Name = w.PRODUCT_NAME,
                Product_Description = w.PRODUCT_DESCRIPTION,
                Category = w.CATEGORY,
                Product_Avail = w.PRODUCT_AVAIL,
                List_Price = w.LIST_PRICE,
                Product_Image = w.PRODUCT_IMAGE,
                MIMETYPE = w.MIMETYPE,
                Filename = w.FILENAME,
                Image_Last_Update = w.IMAGE_LAST_UPDATE,
                Tags = w.TAGS,
                Sale_Price = w.SALE_PRICE,
                Sale_Begin = w.SALE_BEGIN,
                Sale_End = w.SALE_END,
                Frontend_ID = w.FRONTEND_ID,
                Manufaturer_ID = w.MANUFACTURER_ID,
                Last_Updated = w.LAST_MODIFIED_DATE,
                Last_Updated_By = w.LAST_UPDATED_BY
            }).ToList();
        }
        public List<Customer> QueryAllCustomerbyFID(decimal? FID)
        {
            return db.DEMO_CUSTOMERS.Where(w => w.FRONTEND_ID.Equals(FID)).Select(w => new Customer()
            {

                CustomerId = w.CUSTOMER_ID,
                FirstName = w.CUST_FIRST_NAME,
                LastName = w.CUST_LAST_NAME,
                Address = w.CUST_STREET_ADDRESS1,
                City = w.CUST_CITY,
                State = w.CUST_STATE,
                Zip = w.CUST_POSTAL_CODE,
                Email = w.CUST_EMAIL,
                PhoneNumber = w.PHONE_NUMBER1,
                Url = w.URL,
                CreditLimit = w.CREDIT_LIMIT,
                Tags = w.TAGS
            }).ToList();
        }

        public List<Customer> QueryAllCustomer()
        {
            return db.DEMO_CUSTOMERS.Select(w => new Customer()
            {

                CustomerId = w.CUSTOMER_ID,
                FirstName = w.CUST_FIRST_NAME,
                LastName = w.CUST_LAST_NAME,
                Address = w.CUST_STREET_ADDRESS1,
                City = w.CUST_CITY,
                State = w.CUST_STATE,
                Zip = w.CUST_POSTAL_CODE,
                Email = w.CUST_EMAIL,
                PhoneNumber = w.PHONE_NUMBER1,
                Url = w.URL,
                CreditLimit = w.CREDIT_LIMIT,
                Tags = w.TAGS
            }).ToList();
        }

        public Customer GetCustomer(decimal? CID)
        {
            return db.DEMO_CUSTOMERS.Where(w => w.CUSTOMER_ID.Equals(CID)).Select(w => new Customer()
            {

                CustomerId = w.CUSTOMER_ID,
                FirstName = w.CUST_FIRST_NAME,
                LastName = w.CUST_LAST_NAME,
                Address = w.CUST_STREET_ADDRESS1,
                City = w.CUST_CITY,
                State = w.CUST_STATE,
                Zip = w.CUST_POSTAL_CODE,
                Email = w.CUST_EMAIL,
                PhoneNumber = w.PHONE_NUMBER1,
                Url = w.URL,
                CreditLimit = w.CREDIT_LIMIT,
                Tags = w.TAGS
            }).First();

        }


        public List<Order> QueryAllOrdersbyFID(decimal? FID)
        {
            return db.DEMO_ORDERS.Where(w => w.FRONTEND_ID.Equals(FID)).Select(w => new Order()
            {
              OrderId = w.ORDER_ID,
                CustomerID = w.CUSTOMER_ID,
                OrderTotal = w.ORDER_TOTAL,
                OrderTimeStamp = w.ORDER_TIMESTAMP,
                UserName = w.USER_NAME,
                Tags = w.TAGS,
                Frontend_ID = w.FRONTEND_ID,
                Manufaturer_ID = w.MANUFACTURER_ID

            }).ToList();

        }

        public List<Order> QueryAllOrdersbyMID(decimal? MID)
        {
            return db.DEMO_ORDERS.Where(w => w.MANUFACTURER_ID.Equals(MID)).Select(w => new Order()
            {
                OrderId = w.ORDER_ID,
                CustomerID = w.CUSTOMER_ID,
                OrderTotal = w.ORDER_TOTAL,
                OrderTimeStamp = w.ORDER_TIMESTAMP,
                UserName = w.USER_NAME,
                Tags = w.TAGS,
                Frontend_ID = w.FRONTEND_ID,
                Manufaturer_ID = w.MANUFACTURER_ID

            }).ToList();

        }

        public List<Order> QueryAllOrders()
        {
            return db.DEMO_ORDERS.Select(w => new Order()
            {
                OrderId = w.ORDER_ID,
                CustomerID = w.CUSTOMER_ID,
                OrderTotal = w.ORDER_TOTAL,
                OrderTimeStamp = w.ORDER_TIMESTAMP,
                UserName = w.USER_NAME,
                Tags = w.TAGS,
                Frontend_ID = w.FRONTEND_ID,
                Manufaturer_ID = w.MANUFACTURER_ID

            }).ToList();

        }
        public List<OrderItem> QueryAllOrderItmesByOrder(decimal? oid)
        {
            return db.DEMO_ORDER_ITEMS.Where(w => w.ORDER_ID.Equals(oid)).Select(w => new OrderItem()
            {
                OrderItemID = w.ORDER_ITEM_ID,
                OrderID = w.ORDER_ID,
                ProductID = w.PRODUCT_ID,
                UnitPrice = w.UNIT_PRICE,
                Quantity = w.QUANTITY,
                ManufacturerID = w.MANUFACTURER_ID,
                FrontEndID = w.FRONTEND_ID
        }).ToList();

    }

        public List<Recipe> QueryAllRecipe()
        {
            return db.RECIEPE.Select(w => new Recipe()
            {
               RID = w.ID,
               ProductID = w.PRODUCT_ID,
               Description = w.DESCRIPTION,
               FrontendID = w.FRONTEND_ID,
               ManufacturerID = w.MANUFACTURER_ID,
               Last_Updated_By = w.LAST_UPDATED_BY,
               Last_Updated = w.LAST_MODIFIED_DATE
            }).ToList();
        }

        public Recipe GetRecipe(decimal RID)
        {
            return db.RECIEPE.Where(w => w.ID.Equals(RID)).Select(w => new Recipe()
            {
                RID = w.ID,
                ProductID = w.PRODUCT_ID,
                Description = w.DESCRIPTION,
                FrontendID = w.FRONTEND_ID,
                ManufacturerID = w.MANUFACTURER_ID,
                Last_Updated_By = w.LAST_UPDATED_BY,
                Last_Updated = w.LAST_MODIFIED_DATE
            }).FirstOrDefault();
        }

        public List<Recipe> QueryAllRecipeByFrontendID(decimal FID)
        {
            return db.RECIEPE.Where(w => w.FRONTEND_ID.Equals(FID)).Select(w => new Recipe()
            {
                RID = w.ID,
                ProductID = w.PRODUCT_ID,
                Description = w.DESCRIPTION,
                FrontendID = w.FRONTEND_ID,
                ManufacturerID = w.MANUFACTURER_ID,
                Last_Updated_By = w.LAST_UPDATED_BY,
                Last_Updated = w.LAST_MODIFIED_DATE
            }).ToList();
        }

        public List<Recipe> QueryAllRecipeByManufacturerID(decimal MID)
        {
            return db.RECIEPE.Where(w => w.MANUFACTURER_ID.Equals(MID)).Select(w => new Recipe()
            {
                RID = w.ID,
                ProductID = w.PRODUCT_ID,
                Description = w.DESCRIPTION,
                FrontendID = w.FRONTEND_ID,
                ManufacturerID = w.MANUFACTURER_ID,
                Last_Updated_By = w.LAST_UPDATED_BY,
                Last_Updated = w.LAST_MODIFIED_DATE
            }).ToList();
        }

        public List<Ingredient> QueryAllIngredients()
        {
            return db.INGREDIENT.Select(W => new Ingredient()
            {
                IID = W.ID,
                Price = W.PRICE,
                Filename = W.FILENAME,
                MIMETYPE = W.MIMETYPE,
                Ingredient_Image = W.INGREDIENT_IMAGE,
                Description = W.DESCRIPTION,
                Location_Top = W.LOCATION_TOP,
                Location_Bottom = W.LOCATION_TOP,
                Location_Choc = W.LOCATION_CHOC,
                CategoryId = W.CATEGORY_ID,
                Name = W.NAME,
                Quantity = W.QUANTITY,
                Image_Last_Update = W.IMAGE_LAST_UPDATE,
                FrontendID = W.FRONTEND_ID,
                ManufacturerID = W.MANUFACTURER_ID
            }).ToList();
        }

        public Ingredient GetInredigent(decimal iid)
        {
            return db.INGREDIENT.Where(w => w.ID.Equals(iid)).Select(W => new Ingredient()
            {
                IID = W.ID,
                Price = W.PRICE,
                Filename = W.FILENAME,
                MIMETYPE = W.MIMETYPE,
                Ingredient_Image = W.INGREDIENT_IMAGE,
                Description = W.DESCRIPTION,
                Location_Top = W.LOCATION_TOP,
                Location_Bottom = W.LOCATION_TOP,
                Location_Choc = W.LOCATION_CHOC,
                CategoryId = W.CATEGORY_ID,
                Name = W.NAME,
                Quantity = W.QUANTITY,
                Image_Last_Update = W.IMAGE_LAST_UPDATE,
                FrontendID = W.FRONTEND_ID,
                ManufacturerID = W.MANUFACTURER_ID
            }).FirstOrDefault();
        }


        //updates -----------------------------------------------

        //Product Update -------------------------------------------------------------

        public Boolean UpdateProduct(Product prod, string lub)//Product,LastUpdateBy
        {

            DEMO_PRODUCT_INFO result = (from p in db.DEMO_PRODUCT_INFO
                                        where p.PRODUCT_ID == prod.Product_ID
                                        select p).SingleOrDefault();
            result.PRODUCT_NAME = prod.Product_Name;
            result.PRODUCT_DESCRIPTION = prod.Product_Description;
            result.CATEGORY = prod.Category;
            result.PRODUCT_AVAIL = prod.Product_Avail;
            result.LIST_PRICE = prod.List_Price;
            result.PRODUCT_IMAGE = prod.Product_Image;
            result.MIMETYPE = prod.MIMETYPE;
            result.FILENAME = prod.Filename;
            result.IMAGE_LAST_UPDATE = prod.Image_Last_Update;
            result.TAGS = prod.Tags;
            result.SALE_PRICE = prod.Sale_Price;
            result.SALE_BEGIN = prod.Sale_Begin;
            result.SALE_END = prod.Sale_End;
            result.FRONTEND_ID = prod.Frontend_ID;
            result.MANUFACTURER_ID = prod.Manufaturer_ID;
            result.LAST_UPDATED_BY = lub;
            try
            {
                db.SaveChanges();
                return true;
            }

            catch (DbUpdateException ex)
            {
                return false;
            }
        }




        public Boolean UpdateProductFID (decimal pid, decimal? fid, string lub)//ProductID,FrondEndID,LastUpdateBy
        {
            
               DEMO_PRODUCT_INFO result = (from p in db.DEMO_PRODUCT_INFO
                                 where p.PRODUCT_ID == pid
                                 select p).SingleOrDefault();
            result.FRONTEND_ID = fid;
            result.LAST_UPDATED_BY = lub;
            try
            {
                db.SaveChanges();
                return true;
            }
            
            catch (DbUpdateException ex)
            {
                return false;
            }
        }

        public Boolean UpdateProductMID(decimal pid, decimal? mid, string lub)//ProductID,ManufacturerID,LastUpdateBy
        {

            DEMO_PRODUCT_INFO result = (from p in db.DEMO_PRODUCT_INFO
                                        where p.PRODUCT_ID == pid
                                        select p).SingleOrDefault();
            result.MANUFACTURER_ID = mid;
            result.LAST_UPDATED_BY = lub;
            try
            {
                db.SaveChanges();
                return true;
            }

            catch (DbUpdateException ex)
            {
                return false;
            }
        }

        //Customer Update -------------------------------------------------------------

        public Boolean UpdateCustomer(Customer cust, string lub)//Product,LastUpdateBy
        {

            DEMO_CUSTOMERS result = (from p in db.DEMO_CUSTOMERS
                                        where p.CUSTOMER_ID == cust.CustomerId
                                        select p).SingleOrDefault();
            result.CUST_FIRST_NAME = cust.FirstName;
            result.CUST_LAST_NAME = cust.LastName;
            result.CUST_STREET_ADDRESS1 = cust.Address;
            result.CUST_CITY = cust.City;
            result.CUST_STATE = cust.State;
            result.CUST_POSTAL_CODE = cust.Zip;
            result.CUST_EMAIL = cust.Email;
            result.PHONE_NUMBER1 = cust.PhoneNumber;
            result.URL = cust.Url;
            result.TAGS = cust.Tags;
            result.CREDIT_LIMIT = cust.CreditLimit;
            result.MANUFACTURER_ID = cust.Manufaturer_ID;
            result.FRONTEND_ID = cust.Frontend_ID;
            result.LAST_UPDATED_BY = lub;
            try
            {
                db.SaveChanges();
                return true;
            }

            catch (DbUpdateException ex)
            {
                return false;
            }
        }



        public Boolean UpdateCustomerFID(decimal cid, decimal? fid, string lub)//CustomerID, FrontendID, LastUpdateBy
        {

            DEMO_CUSTOMERS result = (from p in db.DEMO_CUSTOMERS
                                        where p.CUSTOMER_ID == cid
                                        select p).SingleOrDefault();
            result.FRONTEND_ID = fid;
            result.LAST_UPDATED_BY = lub;
            try
            {
                db.SaveChanges();
                return true;
            }

            catch (DbUpdateException ex)
            {
                return false;
            }
        }

        public Boolean UpdateCustomerMID(decimal cid, decimal? mid,string lub)//CustomerID, ManufacturerID, LastUpdateBy
        {

            DEMO_CUSTOMERS result = (from p in db.DEMO_CUSTOMERS
                                        where p.CUSTOMER_ID == cid
                                        select p).SingleOrDefault();
            result.MANUFACTURER_ID = mid;
            result.LAST_UPDATED_BY = lub;
            try
            {
                db.SaveChanges();
                return true;
            }

            catch (DbUpdateException ex)
            {
                return false;
            }
        }

        //Update Recipe
        public Boolean UpdateRecipe(Recipe R, string lub)//Recipe Object, LastUpdateBy
        {

            RECIEPE result = (from p in db.RECIEPE
                                     where p.ID == R.RID
                                     select p).SingleOrDefault();
            result.PRODUCT_ID = R.ProductID;
            result.DESCRIPTION = R.Description;
            result.FRONTEND_ID = R.FrontendID;
            result.MANUFACTURER_ID = R.ManufacturerID;
            result.LAST_UPDATED_BY = lub;
            try
            {
                db.SaveChanges();
                return true;
            }

            catch (DbUpdateException ex)
            {
                return false;
            }
        }
        //Update Ingredients

        public Boolean UpdateIngredients(Ingredient I)//Ingredients Object, LastUpdateBy
        {

            INGREDIENT result = (from p in db.INGREDIENT
                              where p.ID == I.IID
                              select p).SingleOrDefault();

            result.PRICE = I.Price;
            result.FILENAME = I.Filename;
            result.MIMETYPE = I.MIMETYPE;
            result.INGREDIENT_IMAGE = I.Ingredient_Image;
            result.DESCRIPTION = I.Description;
            result.LOCATION_TOP = I.Location_Top;
            result.LOCATION_BOTTOM = I.Location_Bottom;
            result.LOCATION_CHOC = I.Location_Choc;
            result.CATEGORY_ID = I.CategoryId;
            result.NAME = I.Name;
            result.QUANTITY = I.Quantity;
            result.IMAGE_LAST_UPDATE = I.Image_Last_Update;
            result.FRONTEND_ID = I.FrontendID;
            result.MANUFACTURER_ID = I.ManufacturerID;
            try
            {
                db.SaveChanges();
                return true;
            }

            catch (DbUpdateException ex)
            {
                return false;
            }
        }



        //Update LastSynched
        public Boolean UpdateManufacturerLastSynched()
        {

            LAST_SYNCHED result = (from p in db.LAST_SYNCHED
                                     where p.ID == 1
                                     select p).SingleOrDefault();
            result.MANUFACTURER_LAST_SYNCHED = System.DateTime.Now;
            try
            {
                db.SaveChanges();
                return true;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }

        public Boolean UpdateProductsFrontendLastSynchedDate()
        {
            LAST_SYNCHED result = (from p in db.LAST_SYNCHED
                                   where p.ID == 1
                                   select p).SingleOrDefault();
            result.FRONTEND_LAST_SYNCHED = System.DateTime.Now;
            try
            {
                db.SaveChanges();
                return true;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }

        public Boolean UpdateProductsManufacturerLastSynchedDate()
        {
            LAST_SYNCHED result = (from p in db.LAST_SYNCHED
                                   where p.ID == 1
                                   select p).SingleOrDefault();
            result.MANUFACTURER_LAST_SYNCHED = System.DateTime.Now;
            try
            {
                db.SaveChanges();
                return true;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }

        public Boolean UpdateOrdersFrontendLastSynchedDate()
        {
            LAST_SYNCHED result = (from p in db.LAST_SYNCHED
                                   where p.ID == 2
                                   select p).SingleOrDefault();
            result.FRONTEND_LAST_SYNCHED = System.DateTime.Now;
            try
            {
                db.SaveChanges();
                return true;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }

        private Boolean UpdateRecipesFrontendLastSynchedDate()
        {
            LAST_SYNCHED result = (from p in db.LAST_SYNCHED
                                   where p.ID == 3
                                   select p).SingleOrDefault();
            result.FRONTEND_LAST_SYNCHED = System.DateTime.Now;
            try
            {
                db.SaveChanges();
                return true;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }

        private Boolean UpdateCustomerManufacturerLastSynchedDate()
        {
            LAST_SYNCHED result = (from p in db.LAST_SYNCHED
                                   where p.ID == 4
                                   select p).SingleOrDefault();
            result.MANUFACTURER_LAST_SYNCHED = System.DateTime.Now;
            try
            {
                db.SaveChanges();
                return true;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }
    }
}




