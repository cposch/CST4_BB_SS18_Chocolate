using System;
using System.Windows.Media.Imaging;     //Reference PresentationCore

namespace AppSharedClasses
{
    public class ShPackage
    {
        public int? Id { get; set; }
        public int? ProductId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public BitmapImage PackageImage { get; set; }
        public int? BackendID { get; set; }
        public int? FrontEndID { get; set; }
        public DateTime? Lastmodified { get; set; }
        public string Filename { get; set; }

        public ShPackage() { }

        public ShPackage(int? id, int? productId, string name, float price, BitmapImage packageImage, int? backendID, int? frontEndID, DateTime? lastmodified, string filename)
        {
            Id = id;
            ProductId = productId;
            Name = name;
            Price = price;
            PackageImage = packageImage;
            BackendID = backendID;
            FrontEndID = frontEndID;
            Lastmodified = lastmodified;
            Filename = filename;
        }

        public ShPackage(int? productId, string name, float price, BitmapImage packageImage, int? backendID, int? frontEndID, DateTime? lastmodified, string filename)
        {
            ProductId = productId;
            Name = name;
            Price = price;
            PackageImage = packageImage;
            BackendID = backendID;
            FrontEndID = frontEndID;
            Lastmodified = lastmodified;
            Filename = filename;
        }
    }
}
