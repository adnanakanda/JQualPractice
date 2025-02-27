namespace SoftwareDesignPattern.Lazy_Initialization
{
    public class DBConnection
    {
        public class DatabaseConnection
        {
            public DatabaseConnection()
            {
                Console.WriteLine("Database connection established.");
            }

            public void Query()
            {
                Console.WriteLine("Executing SQL query...");
            }
        }

        public class DatabaseService
        {
            private readonly Lazy<DatabaseConnection> _dbConnection = new Lazy<DatabaseConnection>(() => new DatabaseConnection());

            public DatabaseConnection Connection => _dbConnection.Value;
        }
    }
}
