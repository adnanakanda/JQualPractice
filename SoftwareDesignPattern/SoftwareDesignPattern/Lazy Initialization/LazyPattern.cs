namespace SoftwareDesignPattern.Lazy_Initialization
{
    public class LazyPattern
    {
        public class ExpensiveObject
        {
            public ExpensiveObject()
            {
                Console.WriteLine("ExpensiveObject created.");
            }

            public void DoWork()
            {
                Console.WriteLine("Doing some work...");
            }
        }

        public class LazyExample
        {
            private readonly Lazy<ExpensiveObject> _instance = new Lazy<ExpensiveObject>(() => new ExpensiveObject());

            public ExpensiveObject Instance => _instance.Value;
        }

        //public class LazyExample
        //{
        //    private ExpensiveObject _instance;

        //    public ExpensiveObject Instance
        //    {
        //        get
        //        {
        //            if (_instance == null)
        //            {
        //                Console.WriteLine("Initializing ExpensiveObject...");
        //                _instance = new ExpensiveObject();
        //            }
        //            return _instance;
        //        }
        //    }
        //}
    }
}
