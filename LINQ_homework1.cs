using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqPractice
{

    class Company
    {
        public string Name { get; set; }
        public DateTime FoundedDate { get; set; }
        public string BusinessProfile { get; set; }
        public string DirectorFullName { get; set; }
        public int EmployeesCount { get; set; }
        public string Address { get; set; }
        public Employee[] Employees { get; set; } = Array.Empty<Employee>();

        public override string ToString() =>
            $"{Name} | Founded: {FoundedDate:yyyy-MM-dd} | {BusinessProfile} | Director: {DirectorFullName} | Staff: {EmployeesCount} | {Address}";
    }

    class Employee
    {

        public string FullName { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }

        public override string ToString() =>
            $"  - {FullName} ({Position}) | Phone: {Phone} | Email: {Email} | Salary: {Salary}";
    }

    class Program
    {
        static void Main()
        {
            var companies = new[]
            {
                new Company

                {
                    Name = "Fresh Food Co",
                    FoundedDate = DateTime.Today.AddYears(-5),
                    BusinessProfile = "Food",
                    DirectorFullName = "Mark White",
                    EmployeesCount = 150,
                    Address = "14 Baker St, London",
                    Employees = new[]
                    {
                        new Employee { FullName = "Leo Miller", Position = "Manager", Phone = "234-555-019", Email = "leo.miller@freshfood.com", Salary = 3200m },
                        new Employee { FullName = "Amy Carter", Position = "Accountant", Phone = "098-444-112", Email = "amy.carter@freshfood.com", Salary = 2100m }
                    }
                },

                new Company
                {
                    Name = "Spark Marketing",
                    FoundedDate = DateTime.Today.AddDays(-123),
                    BusinessProfile = "Marketing",
                    DirectorFullName = "Sara Black",
                    EmployeesCount = 85,
                    Address = "22 King St, London",
                    Employees = new[]
                    {
                        new Employee { FullName = "Dan Brooks", Position = "Manager", Phone = "239-881-304", Email = "dan.brooks@spark.io", Salary = 2900m },
                        new Employee { FullName = "Tess Ward", Position = "Designer", Phone = "555-210-987", Email = "tess.ward@spark.io", Salary = 2400m }
                    }
                },

                new Company
                {
                    Name = "White Pine Tech",
                    FoundedDate = DateTime.Today.AddYears(-3),
                    BusinessProfile = "IT",
                    DirectorFullName = "Paul Black",
                    EmployeesCount = 240,
                    Address = "9 Park Ave, Manchester",
                    Employees = new[]
                    {
                        new Employee { FullName = "Leo Reed", Position = "Developer", Phone = "231-700-650", Email = "dylan.reed@whitepine.dev", Salary = 4500m },
                        new Employee { FullName = "Kate Bell", Position = "Manager", Phone = "777-321-889", Email = "kate.bell@whitepine.dev", Salary = 3600m }
                    }
                },

                new Company
                {
                    Name = "Quick Food Hub",
                    FoundedDate = DateTime.Today.AddMonths(-6),
                    BusinessProfile = "Marketing",
                    DirectorFullName = "Emma White",
                    EmployeesCount = 350,
                    Address = "5 High St, London",
                    Employees = new[]
                    {
                        new Employee { FullName = "Sam Cole", Position = "Developer", Phone = "230-192-837", Email = "sam.cole@quickhub.com", Salary = 3800m }
                    }
                }
            };


            ///////////////////////
            Print("All companies:", from c in companies select c);
            Print("Name contains Food:", from c in companies where c.Name.Contains("Food") select c);
            Print("Marketing profile:", from c in companies where c.BusinessProfile == "Marketing" select c);
            Print("Marketing or IT:", from c in companies where c.BusinessProfile == "Marketing" || c.BusinessProfile == "IT" select c);
            Print("More than 100 employees:", from c in companies where c.EmployeesCount > 100 select c);
            Print("100 to 300 employees:", from c in companies where c.EmployeesCount >= 100 && c.EmployeesCount <= 300 select c);
            Print("In London:", from c in companies where c.Address.Contains("London") select c);
            Print("Director last name White:", from c in companies where c.DirectorFullName.EndsWith(" White") select c);
            Print("Founded over 2 years ago:", from c in companies where c.FoundedDate < DateTime.Today.AddYears(-2) select c);
            Print("Founded 123 days ago:", from c in companies where (DateTime.Today - c.FoundedDate.Date).Days == 123 select c);
            Print("Director Black & name has White:", from c in companies where c.DirectorFullName.EndsWith(" Black") && c.Name.Contains("White") select c);


            ///////////////////////
            Print("All:", companies.Select(c => c));
            Print("Food in name:", companies.Where(c => c.Name.Contains("Food")));
            Print("Marketing:", companies.Where(c => c.BusinessProfile == "Marketing"));
            Print("Marketing or IT:", companies.Where(c => c.BusinessProfile == "Marketing" || c.BusinessProfile == "IT"));
            Print("l thaness 100 staff:", companies.Where(c => c.EmployeesCount > 100));
            Print("100-300 staff:", companies.Where(c => c.EmployeesCount >= 100 && c.EmployeesCount <= 300));
            Print("London:", companies.Where(c => c.Address.Contains("London")));
            Print("Director White:", companies.Where(c => c.DirectorFullName.EndsWith(" White")));
            Print("> 2 years old:", companies.Where(c => c.FoundedDate < DateTime.Today.AddYears(-2)));
            Print("123 days old:", companies.Where(c => (DateTime.Today - c.FoundedDate.Date).Days == 123));
            Print("Black + White:", companies.Where(c => c.DirectorFullName.EndsWith(" Black") && c.Name.Contains("White")));


            ///////////////////////
            var targetCompany = companies[0];
            decimal minSalary = 2500m;

            Print($"Staff at {targetCompany.Name}:", from e in targetCompany.Employees select e);
            Print($"Staff at {targetCompany.Name} earning > {minSalary}:", from e in targetCompany.Employees where e.Salary > minSalary select e);
            Print("All managers:", from c in companies from e in c.Employees where e.Position == "Manager" select e);
            Print("Phone starts with 23:", from c in companies from e in c.Employees where e.Phone.StartsWith("23") select e);
            Print("Email starts with di:", from c in companies from e in c.Employees where e.Email.StartsWith("di", StringComparison.OrdinalIgnoreCase) select e);
            Print("First name Leo:", from c in companies from e in c.Employees where e.FullName.StartsWith("Leo ") select e);



            ///////////////////////
            int[] numbers = { 121, 75, 81 };
            var desc = from n in numbers orderby DigitSum(n) descending select n;
            var asc = from n in numbers orderby DigitSum(n) ascending select n;

            Console.WriteLine("digit sum desc: " + string.Join(", ", desc));
            Console.WriteLine("digit sum asc:  " + string.Join(", ", asc));
        }

        static int DigitSum(int n)
        {
            n = Math.Abs(n);
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        static void Print<T>(string title, IEnumerable<T> items)
        {
            Console.WriteLine($"\n{title}");
            foreach (var item in items)
                Console.WriteLine(item);
        }
    }
}