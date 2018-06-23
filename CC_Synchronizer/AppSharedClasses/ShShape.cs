using System;
using System.Windows.Media.Imaging;     //Reference PresentationCore

namespace AppSharedClasses
{
    public class ShShape
    {
        public int? Id { get; set; }
        public int? ProductId { get; set; }
        public string Name { get; set; }
        public BitmapImage ShapeImage { get; set; }
        public float Price { get; set; }
        public int? BackendID { get; set; }
        public int? FrontEndID { get; set; }
        public DateTime? Lastmodified { get; set; }
        public string Filename { get; set; }

        public ShShape() { }

        public ShShape(int? id, int? productId, string name, BitmapImage shapeImage, float price, int? backendID, int? frontEndID, DateTime? lastmodified, string filename)
        {
            Id = id;
            ProductId = productId;
            Name = name;
            ShapeImage = shapeImage;
            Price = price;
            BackendID = backendID;
            FrontEndID = frontEndID;
            Lastmodified = lastmodified;
            Filename = filename;
        }

        public ShShape(int? productId, string name, BitmapImage shapeImage, float price, int? backendID, int? frontEndID, DateTime? lastmodified, string filename)
        {
            ProductId = productId;
            Name = name;
            ShapeImage = shapeImage;
            Price = price;
            BackendID = backendID;
            FrontEndID = frontEndID;
            Lastmodified = lastmodified;
            Filename = filename;
        }
    }
}
