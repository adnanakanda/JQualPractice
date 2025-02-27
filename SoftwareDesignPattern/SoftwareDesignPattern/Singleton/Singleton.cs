namespace SoftwareDesignPattern.Singleton
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());

        private Singleton() { }

        public static Singleton Instance => instance.Value;
    }

}
