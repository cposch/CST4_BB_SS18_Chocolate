using System.Windows.Media.Imaging;     //Reference PresentationCore

namespace AppSharedClasses
{
    public class ShShape
    {
        private int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public BitmapImage ShapeImage { get; set; }
        public float Price { get; set; }
        public int BackendID { get; set; }
        public int FrontEndID { get; set; }

        public ShShape() { }

        public ShShape(int id, int productId, string name, BitmapImage shapeImage, float price)
        {
            Id = id;
            ProductId = productId;
            Name = name;
            ShapeImage = shapeImage;
            Price = price;
        }

        public ShShape(int id, int productId, string name, BitmapImage shapeImage, float price, int backendID, int frontEndID):this(id, productId, name, shapeImage, price)
        {
            BackendID = backendID;
            FrontEndID = frontEndID;
        }
    }
}
