using System.Collections.Concurrent;

namespace SoftwareDesignPattern.Singleton
{
    public class ObjectPool<T> where T : new()      //constraint ensures that T must have a parameterless constructor.
    {
        private readonly ConcurrentBag<T> pool = new ConcurrentBag<T>();  //thread-safe collection that allows multiple threads to access the pool safely & It stores objects that are no longer in use.

        public T GetObject()        //If an object exists, it is reused. If the pool is empty, a new object is created.
        {
            if (pool.TryTake(out T obj))
                return obj;
            return new T();
        }

        public void ReturnObject(T obj)
        {
            pool.Add(obj);      //stores the object in the ConcurrentBag<T>.
        }
    }

    // Usage
    public class Connection { }

}
