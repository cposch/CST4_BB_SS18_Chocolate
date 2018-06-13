using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendDataHandler
{

    public class Product
    {
        public Product()
        {
        }

        public Product(int product_ID, string product_Name, string product_Description, string category, string product_Avail, decimal list_Price, byte[] product_Image, string mIMETYPE, string filename, DateTime image_Last_Update, string tags, decimal sale_Price, DateTime sale_Begin, DateTime sale_End)
        {
            Product_ID = product_ID;
            Product_Name = product_Name;
            Product_Description = product_Description;
            Category = category;
            Product_Avail = product_Avail;
            List_Price = list_Price;
            Product_Image = product_Image;
            MIMETYPE = mIMETYPE;
            Filename = filename;
            Image_Last_Update = image_Last_Update;
            Tags = tags;
            Sale_Price = sale_Price;
            Sale_Begin = sale_Begin;
            Sale_End = sale_End;
        }

        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public string Product_Description { get; set; }
        public string Category { get; set; }
        public string Product_Avail { get; set; }
        public decimal List_Price { get; set; }
        public byte[] Product_Image { get; set; }
        public string MIMETYPE { get; set; }
        public string Filename { get; set; }
        public DateTime Image_Last_Update { get; set; }
        public string Tags { get; set; }
        public decimal Sale_Price { get; set; }
        public DateTime Sale_Begin { get; set; }
        public DateTime Sale_End { get; set; }
    }
}
