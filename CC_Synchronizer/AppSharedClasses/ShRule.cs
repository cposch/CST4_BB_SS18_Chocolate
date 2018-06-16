namespace AppSharedClasses
{
    public class ShRule
    {
        private int Id { get; set; }
        public int ProductId { get; set; }
        public int BackendID { get; set; }
        public int FrontEndID { get; set; }

        public ShRule() { }

        public ShRule(int id, int productId, int backendID, int frontEndID)
        {
            Id = id;
            ProductId = productId;
            BackendID = backendID;
            FrontEndID = frontEndID;
        }
    }
}
