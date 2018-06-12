namespace AppSharedClasses
{
    public class AppRule
    {
        private int Id { get; set; }
        public int ProductId { get; set; }

        public AppRule() { }

        public AppRule(int id, int productId)
        {
            Id = id;
            ProductId = productId;
        }
    }
}
