using System;
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        while (true)
        {


            Console.WriteLine("1 - Primes & Fibonacci from 100 numbers");
            Console.WriteLine("2 - Search and replace word in file");
            Console.WriteLine("3 - Moderator (censor banned words)");
            Console.WriteLine("4 - Reverse file content");
            Console.WriteLine("5 - Analyze numbers file");
            Console.WriteLine("0 - Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)

            {
                case "1":
                    Task1();
                    break;
                case "2":
                    Task2();
                    break;
                case "3":
                    Task3();
                    break;
                case "4":
                    Task4();
                    break;
                case "5":
                    Task5();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }

        }
    }

    static void Task1()
    {
        Random rand = new Random();
        int[] numbers = new int[100];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(1, 500);
        }

        List<int> primes = new List<int>();
        List<int> fibs = new List<int>();

        foreach (int num in numbers)
        {
            if (IsPrime(num))
                primes.Add(num);

            if (IsFibonacci(num))
                fibs.Add(num);
        }

        File.WriteAllLines("primes.txt", primes.ConvertAll(n => n.ToString()));
        File.WriteAllLines("fibonacci.txt", fibs.ConvertAll(n => n.ToString()));

        Console.WriteLine("Total numbers: " + numbers.Length);
        Console.WriteLine("Primes count: " + primes.Count);
        Console.WriteLine("Fibonacci count: " + fibs.Count);
    }


    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++)

        {
            if (n % i == 0)
                return false;

        }
        return true;

    }

    static bool IsFibonacci(int n)
    {
        if (n < 0) return false;
        int a = 0, b = 1;
        while (b < n)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }
        return n == 0 || b == n;
    }

    /// /////////
    static void Task2()
    {
        Console.Write("File path:");
        string path = Console.ReadLine();

        Console.Write("Word to find:");
        string target = Console.ReadLine();

        Console.Write("Replace:");
        string replacement = Console.ReadLine();


        if (!File.Exists(path))
        {
            Console.WriteLine("file does not exist");
            return;
        }

        string text = File.ReadAllText(path);
        int count = 0;

        int index = 0;
        while ((index = text.IndexOf(target, index, StringComparison.Ordinal)) != -1)
        {
            count++;
            index += target.Length;
        }

        string updated = text.Replace(target, replacement);
        File.WriteAllText(path, updated);

        Console.WriteLine("Success: " + count);
    }


    /// /////////
    static void Task3()
    {
        Console.Write("Text file path:");
        string textPath = Console.ReadLine();

        Console.Write("Banned words path:");
        string bannedPath = Console.ReadLine();

        Console.Write("Output file path:");
        string outputPath = Console.ReadLine();

        if (!File.Exists(textPath) || !File.Exists(bannedPath))
        {
            Console.WriteLine("Input file not found");
            return;
        }

        string text = File.ReadAllText(textPath);
        string bannedRaw = File.ReadAllText(bannedPath);
        string[] bannedWords = bannedRaw.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        int censoredCount = 0;

        foreach (string word in bannedWords)
        {
            string stars = new string('*', word.Length);
            int idx = 0;
            while ((idx = text.IndexOf(word, idx, StringComparison.Ordinal)) != -1)
            {
                censoredCount++;
                idx += word.Length;
            }
            text = text.Replace(word, stars);
        }

        File.WriteAllText(outputPath, text);
        Console.WriteLine("Bad words: " + censoredCount);
    }

    /// /////////


    static void Task4()
    {
        Console.Write("Source file path:");
        string inputPath = Console.ReadLine();

        Console.Write("New file path:");
        string outputPath = Console.ReadLine();

        if (!File.Exists(inputPath))
        {
            Console.WriteLine("Source file not found");
            return;
        }

        string content = File.ReadAllText(inputPath);
        char[] arr = content.ToCharArray();
        Array.Reverse(arr);

        File.WriteAllText(outputPath, new string(arr));
        Console.WriteLine("Reversed file saved");
    }



    
    /// /////////
  

    static void Task5()
    {
        Console.Write("Numbers file path:");
        string path = Console.ReadLine();

        if (!File.Exists(path))
        {
            Console.WriteLine("File not found");
            return;
        }

        List<int> positive = new List<int>();
        List<int> negative = new List<int>();
        List<int> twoDigit = new List<int>();
        List<int> fiveDigit = new List<int>();

        string[] lines = File.ReadAllLines(path);

        foreach (string line in lines)
        {

            string[] parts = line.Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string part in parts)
            {
                if (int.TryParse(part, out int num))
                {
                    if (num > 0)
                        positive.Add(num);
                    else if (num < 0)
                        negative.Add(num);

                    int abs = Math.Abs(num);
                    if (abs >= 10 && abs <= 99)
                        twoDigit.Add(num);
                    else if (abs >= 10000 && abs <= 99999)
                        fiveDigit.Add(num);

                }
            }
        }

        File.WriteAllLines("positive.txt", positive.ConvertAll(n => n.ToString()));
        File.WriteAllLines("negative.txt", negative.ConvertAll(n => n.ToString()));
        File.WriteAllLines("two_digit.txt", twoDigit.ConvertAll(n => n.ToString()));
        File.WriteAllLines("five_digit.txt", fiveDigit.ConvertAll(n => n.ToString()));

        Console.WriteLine("Positive numbers: " + positive.Count);
        Console.WriteLine("Negative numbers: " + negative.Count);
        Console.WriteLine("2 digit numbers: " + twoDigit.Count);
        Console.WriteLine("5 digit numbers: " + fiveDigit.Count);
    }
}