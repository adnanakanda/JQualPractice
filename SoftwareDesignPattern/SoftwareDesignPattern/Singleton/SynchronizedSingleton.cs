namespace SoftwareDesignPattern.Singleton
{
    public sealed class SynchronizedSingleton
    {
        private static SynchronizedSingleton instance;
        private static readonly object lockObj = new object();

        private SynchronizedSingleton() { }

        public static SynchronizedSingleton Instance
        {
            get
            {
                lock (lockObj)
                {
                    if (instance == null)
                        instance = new SynchronizedSingleton();
                }
                return instance;
            }
        }
    }
}
