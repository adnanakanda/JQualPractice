using SoftwareDesignPattern.Builder;
using SoftwareDesignPattern.Delegation;
using SoftwareDesignPattern.Singleton;
using static SoftwareDesignPattern.Chain_of_Responsibility.ConcreteHandlers;
using static SoftwareDesignPattern.Factory_Method.FactoryMethod;
using static SoftwareDesignPattern.Lazy_Initialization.DBConnection;
using static SoftwareDesignPattern.Lazy_Initialization.LazyPattern;

class Program
{
    static void Main()
    {
        //using builder sdp
        Car myCar = new Car.Builder()
            .SetBrand("Tesla")
            .SetModel("Model S")
            .SetYear(2024)
            .SetEngine("Electric")
            .SetColor("Red")
            .AddSunroof()
            .AddGPS()
            .Build();

        Console.WriteLine(myCar);

        // Delegation 
        OfficePrinter officePrinter = new OfficePrinter();
        officePrinter.PrintDocument("Hello, world!");


        // ObjectPool usage
        var connectionPool = new ObjectPool<Connection>();
        var conn1 = connectionPool.GetObject();
        connectionPool.ReturnObject(conn1);


        //CoR implementation
        // Create handlers
        var agent = new AgentHandler();
        var manager = new ManagerHandler();
        var director = new DirectorHandler();

        // Define the chain: Agent → Manager → Director
        agent.SetNextHandler(manager);
        manager.SetNextHandler(director);

        // Test the chain with different priority levels
        Console.WriteLine("Request with priority 1:");
        agent.HandleRequest(1);

        Console.WriteLine("\nRequest with priority 4:");
        agent.HandleRequest(4);

        Console.WriteLine("\nRequest with priority 7:");
        agent.HandleRequest(7);

        // Lazy Implementation
        var lazyExample = new LazyExample();

        Console.WriteLine("Before accessing the instance...");
        lazyExample.Instance.DoWork(); // Object is created here

        var service = new DatabaseService();

        Console.WriteLine("Before making a database query...");
        service.Connection.Query(); // Database connection is established here


        // Factory Method Implementation
        AnimalFactory factory;

        factory = new DogFactory();
        IAnimal dog = factory.CreateAnimal();
        dog.Speak(); // Output: Woof! Woof!

        factory = new CatFactory();
        IAnimal cat = factory.CreateAnimal();
        cat.Speak(); // Output: Meow! Meow!


    }
}
