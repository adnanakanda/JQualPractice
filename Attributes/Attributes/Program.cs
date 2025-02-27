internal class Program
{
    private static void Main(string[] args)
    {
        //Filters elements based on a condition.
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Get even numbers
        var evens = numbers.Where(n => n % 2 == 0);

        Console.WriteLine(string.Join(", ", evens));  // Output: 2, 4, 6, 8, 10


        //Sort elements in ascending or descending order.

        List<string> names = new List<string> { "Bob", "Alice", "Charlie" };

        // Ascending order
        var sortedNames = names.OrderBy(name => name);
        Console.WriteLine(string.Join(", ", sortedNames));  // Output: Alice, Bob, Charlie

        // Descending order
        var sortedDesc = names.OrderByDescending(name => name);
        Console.WriteLine(string.Join(", ", sortedDesc));  // Output: Charlie, Bob, Alice

        var people = new List<(string Name, int Age)>
        {
            ("Alice", 30), ("Bob", 25), ("Charlie", 35)
        };

        // Sort by age
        var sortedByAge = people.OrderBy(p => p.Age);

        List<int> num = new List<int> { 1, 2, 3, 4, 5 };

        bool exists = num.Contains(3);  // True
        bool missing = num.Contains(10); //False
        bool hasEven = num.Any(n => n % 2 == 0);  // True (2, 4)

        // Find duplicates
        var duplicates = numbers.GroupBy(n => n)
                                .Where(g => g.Count() > 1)
                                .Select(g => g.Key);

        Console.WriteLine(string.Join(", ", duplicates));  // Output: 2, 4
        var uniqueNumbers = numbers.Distinct();

        //Combines two collections without removing duplicates.
        var list1 = new List<int> { 1, 2, 3 };
        var list2 = new List<int> { 3, 4, 5 };

        var merged = list1.Concat(list2);

        Console.WriteLine(string.Join(", ", merged));  // Output: 1, 2, 3, 3, 4, 5

        //Combines two collections and removes duplicates.
        var uniqueMerged = list1.Union(list2);
        Console.WriteLine(string.Join(", ", uniqueMerged));  // Output: 1, 2, 3, 4, 5





        //Using Anonymous Types in LINQ
        var people2 = new List<(string Name, int Age)>
            {
                ("Alice", 30),
                ("Bob", 25),
                ("Charlie", 35)
            };

        // Select only Name and Age in an anonymous type
        var selectedPeople = people2.Select(p => new { p.Name, p.Age });

        foreach (var person in selectedPeople)
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }



        // //Generics Usage
        Utility.Print(10);        // Value: 10
        Utility.Print("Hello");   // Value: Hello
        Utility.Print(3.14);      // Value: 3.14


        //Generic Method with Multiple Type Parameters usage 
        Pair.Show(1, "Apple");        // First: 1, Second: Apple
        Pair.Show(3.14, true);        // First: 3.14, Second: True


    }
}

//Generics

public class Utility
{
    public static void Print<T>(T value)
    {
        Console.WriteLine($"Value: {value}");
    }
}

//Generic Method with Multiple Type Parameters

public class Pair
{
    public static void Show<T1, T2>(T1 first, T2 second)
    {
        Console.WriteLine($"First: {first}, Second: {second}");
    }
}