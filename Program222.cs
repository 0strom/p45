using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22222222333444
{
    internal class Program222
    {
        class Passport
        {
            public string Number { get; set; }
            public string FullName { get; set; }
            public DateTime IssueDate { get; set; }
            public string Country { get; set; }

            public Passport(string number, string name, DateTime date, string country)
            {
                if (number == "" || name == "" || country == "")
                    throw new Exception("Fields can't be empty");

                if (date > DateTime.Today)
                    throw new Exception("Wrong issue date");

                Number = number;
                FullName = name;
                IssueDate = date;
                Country = country;
            }

            public override string ToString()
            {
                return "Passport number: " + Number + "\n" +
                       "Full name: " + FullName + "\n" +
                       "Issue date: " + IssueDate.ToShortDateString() + "\n" +
                       "Country: " + Country;
            }
        }

        class Program
        {
            static void Main()
            {

                try
                {
                    Console.WriteLine("1 Dec to Bi");
                    Console.WriteLine("2 Bi to Dec");
                    Console.WriteLine("3 Dec to Hex");
                    Console.WriteLine("4 Hex to Dec");
                    Console.Write("Option: ");

                    int choice = int.Parse(Console.ReadLine());

                    if (choice >= 1 && choice <= 4)
                    {
                        Console.Write("Enter number: ");
                        string input = Console.ReadLine();

                        int number;
                        string result = "";

                        if (choice == 1)
                        {
                            number = int.Parse(input);
                            result = Convert.ToString(number, 2);
                        }
                        else if (choice == 2)
                        {
                            number = Convert.ToInt32(input, 2);
                            result = number.ToString();
                        }
                        else if (choice == 3)
                        {
                            number = int.Parse(input);
                            result = Convert.ToString(number, 16);
                        }
                        else
                        {
                            number = Convert.ToInt32(input, 16);
                            result = number.ToString();
                        }

                        Console.WriteLine("Result: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }


                    Console.WriteLine("\nEnter passport info:");

                    Console.Write("Passport number: ");
                    string passportNumber = Console.ReadLine();

                    Console.Write("Full name: ");
                    string fullName = Console.ReadLine();

                    Console.Write("Date (dd.MM.yyyy): ");
                    DateTime date = DateTime.ParseExact(
                        Console.ReadLine(),
                        "dd.MM.yyyy",
                        CultureInfo.InvariantCulture);

                    Console.Write("Country: ");
                    string country = Console.ReadLine();

                    Passport passport = new Passport(
                        passportNumber, fullName, date, country);

                    Console.WriteLine("\nPassport info:");
                    Console.WriteLine(passport);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number is outside the range");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong format");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.ReadKey();
            }
        }

    }
}
