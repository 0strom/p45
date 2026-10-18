namespace ConsoleApp2sharp
{

    using System;
    class Program1
    {
        static void Main()
        {
            /////////////////
            Console.WriteLine("1)");
            Console.Write("Num from 1 to 100 ");
            int n = int.Parse(Console.ReadLine());
            if (n >= 1 && n <= 100)
            {
                if (n % 3 == 0 && n % 5 == 0) Console.WriteLine("Fizz Buzz");
                else if (n % 3 == 0) Console.WriteLine("Fizz");
                else if (n % 5 == 0) Console.WriteLine("Buzz");

                else Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine("Error");
            }


            /////////////////
            Console.WriteLine("\n2)");
            Console.Write("Number:");
            double val2 = double.Parse(Console.ReadLine());
            Console.Write("%:");
            double perc2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Result {(val2 * perc2) / 100}");


            /////////////////
            Console.WriteLine("\n3)");
            Console.WriteLine("4 numbers");
            string d1 = Console.ReadLine();
            string d2 = Console.ReadLine();
            string d3 = Console.ReadLine();
            string d4 = Console.ReadLine();
            int resultNum = int.Parse(d1 + d2 + d3 + d4);
            Console.WriteLine($"Result {resultNum}");


            /////////////////
            Console.WriteLine("\n4)");
            Console.Write("6 digit number: ");
            string numStr = Console.ReadLine();
            if (numStr.Length == 6)
            {
                Console.Write("1: ");
                int p1 = int.Parse(Console.ReadLine()) - 1;
                Console.Write("2: ");
                int p2 = int.Parse(Console.ReadLine()) - 1;

                char[] chars = numStr.ToCharArray();
                char temp = chars[p1];
                chars[p1] = chars[p2];
                chars[p2] = temp;
                Console.WriteLine($"Result {new string(chars)}");
            }
            else
            {
                Console.WriteLine("Error");
            }

            /////////////////
            Console.WriteLine("\n5)");
            Console.Write("Date: ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
            string season = "";

            int m = date.Month;
            if (m == 12 || m == 1 || m == 2) season = "Winter";
            else if (m >= 3 && m <= 5) season = "Spring";
            else if (m >= 6 && m <= 8) season = "Summer";
            else season = "Autumn";
            Console.WriteLine($"{season} {date.DayOfWeek}");



            /////////////////
            Console.WriteLine("\n6)");
            Console.Write("Temperature: ");

            double t = double.Parse(Console.ReadLine());
            Console.Write("1 - Fah to Cel, 2 - Cel to Fah: ");
            string choice = Console.ReadLine();

            if (choice == "1")
                Console.WriteLine($"Result: {(t - 32) * 5 / 9} C");

            else
                Console.WriteLine($"Result: {(t * 9 / 5) + 32} F");

            /////////////////
            Console.WriteLine("\n7)");

            Console.Write("First number: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Second number: ");
            int end = int.Parse(Console.ReadLine());

            if (start > end)
            {
                int tmp = start;
                start = end;
                end = tmp;
            }


            Console.Write("Odd numbers: ");
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0) Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }

}
