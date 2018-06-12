using System.Windows.Media.Imaging;     //Reference PresentationCore

namespace AppSharedClasses
{
    public class AppPackage
    {
        private int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public BitmapImage PackageImage { get; set; }

        public AppPackage() { }

        public AppPackage(int id, int productId, string name, float price, BitmapImage packageImage)
        {
            Id = id;
            ProductId = productId;
            Name = name;
            Price = price;
            PackageImage = packageImage;
        }
    }
}
