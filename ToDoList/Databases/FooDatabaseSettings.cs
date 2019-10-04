namespace ToDoList.Databases
{
    public class FooDatabaseSettings : IFooDatabaseSettings
    {
        public string FooCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        
    }

    public interface IFooDatabaseSettings
    {
        string FooCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        
    }
}