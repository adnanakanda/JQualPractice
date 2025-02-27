namespace SoftwareDesignPattern.Factory_Method
{
    public class FactoryMethod
    {
        public interface IAnimal
        {
            void Speak();
        }

        public class Dog : IAnimal
        {
            public void Speak() => Console.WriteLine("Woof! Woof!");
        }

        public class Cat : IAnimal
        {
            public void Speak() => Console.WriteLine("Meow! Meow!");
        }

        //Create an Abstract Factory Class
        public abstract class AnimalFactory
        {
            public abstract IAnimal CreateAnimal();
        }

        //Create Concrete Factory Classes
        public class DogFactory : AnimalFactory
        {
            public override IAnimal CreateAnimal() => new Dog();
        }

        public class CatFactory : AnimalFactory
        {
            public override IAnimal CreateAnimal() => new Cat();
        }
    }
}
