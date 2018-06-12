namespace AppSharedClasses
{
    public class AppChanges
    {
        public int ID { get; set; }
        public int TableID { get; set; }
        public int ItemID { get; set; }
        public int Synced { get; set; }

        public AppChanges() { }

        public AppChanges(int id, int tableID, int itemID, int synced)
        {
            ID = id;
            TableID = tableID;
            ItemID = itemID;
            Synced = synced;
        }
    }
}
