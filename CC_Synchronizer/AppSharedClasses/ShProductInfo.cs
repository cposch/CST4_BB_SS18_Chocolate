using System;
using System.Windows.Media.Imaging;     //Reference PresentationCore

namespace AppSharedClasses
{
    public class ShProductInfo
    {
        public int? ProduktID;
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Availability { get; set; }
        public float ListPrice { get; set; }
        public float? SalePrice { get; set; }
        public DateTime? SaleBegin { get; set; }
        public DateTime? SaleEnd { get; set; }
        public BitmapImage ProductImage { get; set; }
        public int? BackendID { get; set; }
        public int? FrontEndID { get; set; }
        public DateTime? Lastmodified { get; set; }
        public string Filename { get; set; }

        public ShProductInfo() { }

        public ShProductInfo(int? produktID, string name, string description, string category, string availability, float listPrice, float? salePrice, DateTime? saleBegin, DateTime? saleEnd, BitmapImage productImage, int? backendID, int? frontEndID, DateTime? lastmodified, string filename)
        {
            ProduktID = produktID;
            Name = name;
            Description = description;
            Category = category;
            Availability = availability;
            ListPrice = listPrice;
            SalePrice = salePrice;
            SaleBegin = saleBegin;
            SaleEnd = saleEnd;
            ProductImage = productImage;
            BackendID = backendID;
            FrontEndID = frontEndID;
            Lastmodified = lastmodified;
            Filename = filename;
        }

        public ShProductInfo(string name, string description, string category, string availability, float listPrice, float? salePrice, DateTime? saleBegin, DateTime? saleEnd, BitmapImage productImage, int? backendID, int? frontEndID, DateTime? lastmodified, string filename)
        {
            Name = name;
            Description = description;
            Category = category;
            Availability = availability;
            ListPrice = listPrice;
            SalePrice = salePrice;
            SaleBegin = saleBegin;
            SaleEnd = saleEnd;
            ProductImage = productImage;
            BackendID = backendID;
            FrontEndID = frontEndID;
            Lastmodified = lastmodified;
            Filename = filename;
        }
    }
}
