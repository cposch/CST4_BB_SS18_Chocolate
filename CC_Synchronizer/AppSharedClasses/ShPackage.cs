using System.Windows.Media.Imaging;     //Reference PresentationCore

namespace AppSharedClasses
{
    public class ShPackage
    {
        private int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public BitmapImage PackageImage { get; set; }
        public int BackendID { get; set; }
        public int FrontEndID { get; set; }

        public ShPackage() { }

        public ShPackage(int id, int productId, string name, float price, BitmapImage packageImage, int backendID, int frontEndID)
        {
            Id = id;
            ProductId = productId;
            Name = name;
            Price = price;
            PackageImage = packageImage;
            BackendID = backendID;
            FrontEndID = frontEndID;
        }
    }
}
