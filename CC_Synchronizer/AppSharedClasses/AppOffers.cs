using System;

namespace AppSharedClasses
{
    public class AppOffers
    {
        private int produktID;
        public string Name { get; set; }
        public float SalePrice { get; set; }
        public DateTime SaleBegin { get; set; }
        public DateTime SaleEnd { get; set; }

        public AppOffers() { }

        public AppOffers(int produktID, string name, float salePrice, DateTime saleBegin, DateTime saleEnd)
        {
            this.produktID = produktID;
            Name = name;
            SalePrice = salePrice;
            SaleBegin = saleBegin;
            SaleEnd = saleEnd;
        }
    }
}
