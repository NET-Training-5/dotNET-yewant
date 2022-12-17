using System;

class Method
{
    // Simplest possible: returns nothings, takes no arguments
    public void Print()
    {
        Console.WriteLine("Nepal is beautiful.");
    }

    // Returns nothing, takes some arguments
    public void Print(string message)       // Method overloading
    {
        Console.WriteLine(message);
    }

    // Returns something, takes no arguments
    public string GetMessage()
    {
        var city = "Kathmandu";
        return city;
    }

    // Returns something, takes some arguements
    public double Add(double a, double b)
    {
        return a + b;
    }

    // Expression bodied members
    public double AddS(double a, double b) => a + b;

    // Takes arguements or not, returns multiple values
    // Find sum and product of supplied numbers
    // Tuples
    public (double, double) GetSumAndProduct(float a, float b)
    {
        var sum = a + b;
        var product = a * b;
        
        return (sum, product);
    }

    // CW - Write a method which takes 3 numbers and returns average of all.
    public double FindAverage(params int[] items)
    {
        var sum = 0;
        foreach (var i in items)
        {
            sum = sum + i;
        }

        var average = (double)sum / items.Length;

        return average;
    }

    // CW - Find min and max of numbers provided to a method.
    //      This method should also accept variable number of arguments

    public (short, short) FindMinMax(params short[] numbers) //8,9,2,-5,1,10
    {
        short min = short.MaxValue, max = 0;

        foreach (var num in numbers)
        {
            if (num < min)
                min = num;
            if (num > max)
                max = num;
        }

        return (min, max);
    }
}
