
using System;
using System.Globalization;

class Program
{
    delegate bool Check(int n);

    static int[] Filter(int[] arr, Check c)
    {
        return Array.FindAll(arr, c);
    }

    static bool Even(int n)
    {
        return n % 2 == 0;
    }

    static bool Odd(int n)
    {
        return n % 2 != 0;
    }

    static bool Prime(int n)
    {
        if (n < 2) return false;

        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }


    static bool Fib(int n)
    {
        int a = 0, b = 1;

        while (a < n)
        {
            int t = a + b;
            a = b;
            b = t;
        }

        return a == n;
    }


    static void Time()
    {
        Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
    }

    static void Date()
    {
        Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy"));
    }

    static void Day()
    {
        Console.WriteLine(DateTime.Now.ToString("dddd",
            new CultureInfo("en")));
    }


    static bool Positive(double n)
    {
        return n > 0;
    }

    static double Triangle(double a, double h)
    {
        return a * h / 2;
    }

    static double Rectangle(double a, double b)
    {
        return a * b;
    }


    static void Main()
    {

        int[] arr = { 1, 2, 3, 4, 5, 8, 9, 13, 16, 21, 25 };

        Console.WriteLine("TASK 1");

        Console.WriteLine("Array:");
        Console.WriteLine(string.Join(", ", arr));

        Console.WriteLine("Even numbers:");
        Console.WriteLine(string.Join(", ", Filter(arr, Even)));

        Console.WriteLine("Odd numbers:");
        Console.WriteLine(string.Join(", ", Filter(arr, Odd)));

        Console.WriteLine("Prime numbers:");
        Console.WriteLine(string.Join(", ", Filter(arr, Prime)));

        Console.WriteLine("Fibonacci numbers:");
        Console.WriteLine(string.Join(", ", Filter(arr, Fib)));



        Console.WriteLine("\nTASK 2");

        Action t = Time;
        Action d = Date;
        Action day = Day;

        Console.WriteLine("Current time:");
        t();

        Console.WriteLine("Current date:");
        d();

        Console.WriteLine("Day of the week:");
        day();


        Predicate<double> p = Positive;
        Console.WriteLine("Is the number positive: " + p(5));

        Func<double, double, double> tr = Triangle;
        Console.WriteLine("Triangle area: " + tr(10, 5));

        Func<double, double, double> rec = Rectangle;
        Console.WriteLine("Rectangle area: " + rec(8, 4));
    }
}
