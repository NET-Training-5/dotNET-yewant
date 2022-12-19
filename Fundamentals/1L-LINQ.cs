// LINQ - Language Integrated Query

using System;
using System.Collections.Generic;
using System.Linq;

class LINQ
{
    int[] numbers = { 3, 4, 6, 8, 1, 3, 4, 51, 45, 67, 12, 34, 35 };

    public void LearnToQuery()
    {
        PrintValues(numbers, "Input Array: ");

        // List all even numbers from "numbers" array
        // Declarative Way
        var evenNumbers = numbers.Where(x => x % 2 == 0);
        PrintValues(evenNumbers, "Even Numbers: ");

        // List all odd numbers which are divisible by 3
        var oddNumbers = numbers.Where(x => x % 2 != 0 && x % 3 == 0);
        PrintValues(oddNumbers, "Odd Numbers divisible by 3: ");

        // List multiples of 5 and 7 from "numbers"
        var multipleOf5And7 = numbers.Where(x => x % 5 == 0 && x % 7 == 0);
        PrintValues(multipleOf5And7, "Multiple of 5 and 7: ");

        // List all items less than 100 with trailing 0, from "numbers"
        var numbersWithTrailing0 = numbers.Where(x => x < 100 && x.ToString().EndsWith("0"));

        // Projections
        // Print squares of all items in numbers array
        var squares = numbers.Select(x => x * x);
        PrintValues(squares, "Squares: ");

        // Print square root of all items less than 50
        var sqRoots = numbers.Where(x => x < 50).Select(x => Math.Round(Math.Sqrt(x), 2));

        // Expression syntax
        var sqRoots2 = from x in numbers
                       where x < 50
                       select Math.Round(Math.Sqrt(x), 2);


        PrintValues(sqRoots, "Square roots (< 50): ");

        // Sort numbers
        var numbersSorted = numbers.Order();

        // List 5 items skipping first two
        var fiveItems = numbers.Skip(2).Take(5);
        PrintValues(fiveItems, "Skip-Take: ");

        // Check if any item is even number
        var isThereAnyEvenNumber = numbers.Any(x => x % 2 == 0);
        Console.WriteLine($"Any Even: {isThereAnyEvenNumber}");

        // Check if all items are even numbers
        var areAllEvenNumbers = numbers.All(x => x % 2 == 0);
        Console.WriteLine($"All Even: {areAllEvenNumbers}");
    }

    public void LearnToQueryOnObjectCollection()
    {
        Person p1 = new();
        p1.fullName = "Kisan Shrestha";
        p1.gender = 'M';
        p1.height = 170.23f;

        Person p2 = new() { fullName = "Ram Basnet", gender = 'M', height = 160.34f };
        Person p3 = new() { fullName = "Gita Basnet", gender = 'F', height = 164.34f };
        Person p4 = new() { fullName = "Ganesh Joshi", gender = 'M', height = 161.34f };
        Person p5 = new() { fullName = "Rita Basnet", gender = 'F', height = 180.38f };

        List<Person> people = new List<Person>() { p1, p2, p3, p4, p5 };

        // List all females
        var females = people.Where(x => x.gender == 'F');
        
        // List all males in ascending order of their height
        // Contextual keywords
        var males = from p in people
                    where p.gender == 'M'
                    orderby p.height
                    select p;
        
    }
    void PrintValues<T>(IEnumerable<T> items, string label)
    {
        Console.Write($"\n{label}");
        foreach (var item in items)
            Console.Write(item + " ");
    }
}
