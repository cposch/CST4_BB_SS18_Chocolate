using System.Windows.Media.Imaging;     //Reference PresentationCore

namespace AppSharedClasses
{
    public class AppShape
    {
        private int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public BitmapImage ShapeImage { get; set; }
        public float Price { get; set; }

        public AppShape() { }

        public AppShape(int id, int productId, string name, BitmapImage shapeImage, float price)
        {
            Id = id;
            ProductId = productId;
            Name = name;
            ShapeImage = shapeImage;
            Price = price;
        }
    }
}
