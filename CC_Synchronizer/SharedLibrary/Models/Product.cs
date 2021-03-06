﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class Product
    {
        public Product()
        {
        }

        public Product( string product_Name, string product_Description, string category, string product_Avail, decimal? list_Price, byte[] product_Image, string mIMETYPE, string filename, DateTime? image_Last_Update, string tags, decimal? sale_Price, DateTime? sale_Begin, DateTime? sale_End, decimal? frontend_ID, decimal? manufaturer_ID)
        {
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
            Frontend_ID = frontend_ID;
            Manufaturer_ID = manufaturer_ID;

        }

        public Product(string product_Name, string product_Description, string category, string product_Avail, decimal? list_Price, byte[] product_Image, string mIMETYPE, string filename, DateTime? image_Last_Update, string tags, decimal? sale_Price, DateTime? sale_Begin, DateTime? sale_End, decimal? frontend_ID, decimal? manufaturer_ID, DateTime? last_Updated, string last_Updated_By) : this(product_Name, product_Description, category, product_Avail, list_Price, product_Image, mIMETYPE, filename, image_Last_Update, tags, sale_Price, sale_Begin, sale_End, frontend_ID, manufaturer_ID)
        {
            Last_Updated = last_Updated;
            Last_Updated_By = last_Updated_By;
        }

        public decimal Product_ID { get; set; }
        public string Product_Name { get; set; }
        public string Product_Description { get; set; }
        public string Category { get; set; }
        public string Product_Avail { get; set; }
        public decimal? List_Price { get; set; }
        public byte[] Product_Image { get; set; }
        public string MIMETYPE { get; set; }
        public string Filename { get; set; }
        public DateTime? Image_Last_Update { get; set; }
        public string Tags { get; set; }
        public decimal? Sale_Price { get; set; }
        public DateTime? Sale_Begin { get; set; }
        public DateTime? Sale_End { get; set; }
        public decimal? Frontend_ID { get; set; }
        public decimal? Manufaturer_ID { get; set; }

        public DateTime? Last_Updated { get; set; }

        public string Last_Updated_By { get; set; }
    }
}
