namespace AppSharedClasses
{
    public class AppTableID
    {
        public int ID { get; set; }
        public string TableName { get; set; }

        public AppTableID() { }

        public AppTableID(int iD, string tableName)
        {
            ID = iD;
            TableName = tableName;
        }
    }
}
