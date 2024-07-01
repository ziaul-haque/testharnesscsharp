using System;

public class Program
{
    public static void Main()
    {
        string name = "Zee";
        Console.WriteLine($"My name is {name}");
        linqTest();
    }

    static void linqTest()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        var evenNumbers = numbers.Where(n => n % 2 == 0);

        foreach (var num in GetNumbers())
        {
            Console.WriteLine($"num: {num} square={num * num}");
        }
        ProcessNumbers(numbers);
    }

    static IEnumerable<int> GetNumbers()
    {
        yield return 1;
        yield return 2;
        yield return 3;
        yield return 4;
        yield return 5;
    }

    static void ProcessNumbers(int[] numbers)
    {
        bool IsEven(int number) => number % 2 == 0;

        foreach (var number in numbers)
        {
            if (IsEven(number))
            {
                Console.WriteLine($"{number} is even.");
            }
        }
    }
}