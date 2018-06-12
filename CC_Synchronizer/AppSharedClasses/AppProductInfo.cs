using System;
using System.Windows.Media.Imaging;     //Reference PresentationCore

namespace AppSharedClasses
{
    public class AppProductInfo
    {
        private int ProduktID;
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool Availability { get; set; }
        public float ListPrice { get; set; }
        public float SalePrice { get; set; }
        public DateTime SaleBegin { get; set; }
        public DateTime SaleEnd { get; set; }
        public BitmapImage ProductImage { get; set; }

        public AppProductInfo() { }

        public AppProductInfo(int produktID, string name, string description, string category, bool availability, float listPrice, float salePrice, DateTime saleBegin, DateTime saleEnd, BitmapImage productImage)
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
        }
    }
}
