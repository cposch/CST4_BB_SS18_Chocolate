﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class Shape
    {
        public decimal SID { get; set; }
        public decimal ProductID { get; set; }
        public string Name { get; set; }
        public string Filename { get; set; }
        public string MIMETYPE { get; set; }
        public byte[] Shape_Image { get; set; }
        public decimal Price { get; set; }
        public DateTime? Image_Last_Update { get; set; }
        public decimal? FrontendID { get; set; }
        public decimal? ManufacturerID { get; set; }

        public Shape()
        {
        }

        public Shape(decimal sID, decimal productID, string name, string filename, string mIMETYPE, byte[] shape_Image, decimal price, DateTime? image_Last_Update, decimal? frontendID, decimal? manufacturerID)
        {
            SID = sID;
            ProductID = productID;
            Name = name;
            Filename = filename;
            MIMETYPE = mIMETYPE;
            Shape_Image = shape_Image;
            Price = price;
            Image_Last_Update = image_Last_Update;
            FrontendID = frontendID;
            ManufacturerID = manufacturerID;
        }
    }
}
