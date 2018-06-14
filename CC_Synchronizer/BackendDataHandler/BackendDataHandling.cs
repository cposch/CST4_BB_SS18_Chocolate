using SharedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendDataHandler
{
    public class BackendDataHandling
    {
        BackendDBEntities2 db = new BackendDBEntities2();
        

        public void AddProduct(Product p)
        {
            DEMO_PRODUCT_INFO pt = new DEMO_PRODUCT_INFO();
            pt.PRODUCT_ID = p.Product_ID;
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

            db.DEMO_PRODUCT_INFO.Add(pt);
            db.SaveChanges();
        }


    }
}
