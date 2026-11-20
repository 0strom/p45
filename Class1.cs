using System;
using System;
namespace ListTask
{
    class Employee
    {
        public string name;
        public string position;
        public double salary;
        public string email;
        public Employee(string name, string position, double salary, string email)
        {
            this.name = name;
            this.position = position;
            this.salary = salary;
            this.email = email;
        }
        public void Show()
        {
            Console.WriteLine(name + " " + position + " " + salary + " " + email);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Tom", "Manager", 33000, "tom@gmail.com"));
            employees.Add(new Employee("Anna", "Designer", 25005, "anna@gmail.com"));
            employees.Add(new Employee("John", "Programmer", 44444, "john@gmail.com"));
            employees.Add(new Employee("Kate", "Accountant", 28228, "kate@gmail.com"));
            employees.Add(new Employee("Mike", "Director", 50000, "mike@gmail.com"));
            employees.Add(new Employee("Emma", "HR", 27000, "emma@gmail.com"));
            employees.Add(new Employee("Alex", "Programmer", 42042, "alex@gmail.com"));
            employees.Add(new Employee("Lisa", "Designer", 26000, "lisa@gmail.com"));
            employees.Add(new Employee("Sam", "Manager", 35000, "sam@gmail.com"));
            employees.Add(new Employee("Nick", "Accountant", 29000, "nick@gmail.com"));

            while (true)
            {
                Console.WriteLine("\nShow employees (A)");
                Console.WriteLine("Add employee (Add)");
                Console.WriteLine("Delete employee (Del)");
                Console.WriteLine("Edit employee (Edit)");
                Console.WriteLine("Search employee (S)");
                Console.WriteLine("Sort employees (Sort)");
                Console.WriteLine("Exit (X)");

                Console.Write("Choice: ");
                string choice = Console.ReadLine().ToUpper();
                //Show
                if (choice == "A")
                {
                    foreach (Employee e in employees)
                        e.Show();
                }

                //Add new
                else if (choice == "Add")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Position: ");
                    string position = Console.ReadLine();
                    Console.Write("Salary: ");
                    double salary = double.Parse(Console.ReadLine());
                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    employees.Add(new Employee(name, position, salary, email));
                    Console.WriteLine("Added");
                }
                //Delete
                else if (choice == "Del")
                {
                    Console.Write("Enter email: ");
                    string email = Console.ReadLine();
                    Employee e = employees.Find(x => x.email == email);

                    if (e != null)
                    {
                        employees.Remove(e);
                        Console.WriteLine("Deleted");
                    }
                    else
                        Console.WriteLine("Error");
                }
                //Edit 
                else if (choice == "Edit")
                {
                    Console.Write("Enter email: ");
                    string email = Console.ReadLine();
                    Employee e = employees.Find(x => x.email == email);
                    if (e != null)
                    {
                        Console.Write("New name: ");
                        e.name = Console.ReadLine();
                        Console.Write("New position: ");
                        e.position = Console.ReadLine();
                        Console.Write("New salary: ");
                        e.salary = double.Parse(Console.ReadLine());
                        Console.Write("New email: ");
                        e.email = Console.ReadLine();
                        Console.WriteLine("Added");
                    }
                    else
                        Console.WriteLine("Error");
                }
                //Search
                else if (choice == "S")
                {
                    Console.WriteLine("1. Search by name");
                    Console.WriteLine("2. Search by salary");
                    string s = Console.ReadLine();
                    if (s == "1")
                    {
                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();
                        Employee e = employees.Find(x => x.name == name);
                        if (e != null)
                            e.Show();
                        else
                            Console.WriteLine("Error");
                    }
                    else if (s == "2")
                    {
                        Console.Write("Enter min salary: ");
                        double min = double.Parse(Console.ReadLine());
                        Console.Write("Enter max salary: ");
                        double max = double.Parse(Console.ReadLine());

                        foreach (Employee e in employees)
                        {
                            if (e.salary >= min && e.salary <= max)
                                e.Show();
                        }
                    }
                }

                //Sort
                else if (choice == "Sort")
                {
                    Console.WriteLine("1. Sort by name");
                    Console.WriteLine("2. Sort by salary");
                    Console.WriteLine("3. Sort by position");
                    string s = Console.ReadLine();
                    if (s == "1")
                        employees.Sort((a, b) => a.name.CompareTo(b.name));
                    else if (s == "2")
                        employees.Sort((a, b) => a.salary.CompareTo(b.salary));
                    else if (s == "3")
                        employees.Sort((a, b) => a.position.CompareTo(b.position));
                    foreach (Employee e in employees)
                        e.Show();
                }
                //Exit program
                else if (choice == "X")
                {
                    break;
                }
            }
        }
    }
}
namespace ListTask { class Employee { public string name; public string position; public double salary; public string email; public Employee(string name, string position, double salary, string email) { this.name = name; this.position = position; this.salary = salary; this.email = email; } public void Show() { Console.WriteLine(name + " " + position + " " + salary + " " + email); } } internal class Program { static void Main(string[] args) { List<Employee> employees = new List<Employee>(); employees.Add(new Employee("Tom", "Manager", 33000, "tom@gmail.com")); employees.Add(new Employee("Anna", "Designer", 25005, "anna@gmail.com")); employees.Add(new Employee("John", "Programmer", 44444, "john@gmail.com")); employees.Add(new Employee("Kate", "Accountant", 28228, "kate@gmail.com")); employees.Add(new Employee("Mike", "Director", 50000, "mike@gmail.com")); employees.Add(new Employee("Emma", "HR", 27000, "emma@gmail.com")); employees.Add(new Employee("Alex", "Programmer", 42042, "alex@gmail.com")); employees.Add(new Employee("Lisa", "Designer", 26000, "lisa@gmail.com")); employees.Add(new Employee("Sam", "Manager", 35000, "sam@gmail.com")); employees.Add(new Employee("Nick", "Accountant", 29000, "nick@gmail.com")); while (true) { Console.WriteLine("\nShow employees (A)"); Console.WriteLine("Add employee (Add)"); Console.WriteLine("Delete employee (Del)"); Console.WriteLine("Edit employee (Edit)"); Console.WriteLine("Search employee (S)"); Console.WriteLine("Sort employees (Sort)"); Console.WriteLine("Exit (X)"); Console.Write("Choice: "); string choice = Console.ReadLine().ToUpper();                //Show                if (choice == "A")                {                    foreach (Employee e in employees)                        e.Show();                }                //Add new                else if (choice == "Add")                {                    Console.Write("Name: ");                    string name = Console.ReadLine();                    Console.Write("Position: ");                    string position = Console.ReadLine();                    Console.Write("Salary: ");                    double salary = double.Parse(Console.ReadLine());                    Console.Write("Email: ");                    string email = Console.ReadLine();                    employees.Add(new Employee(name, position, salary, email));                    Console.WriteLine("Added");                }                //Delete                else if (choice == "Del")                {                    Console.Write("Enter email: ");                    string email = Console.ReadLine();                    Employee e = employees.Find(x => x.email == email);                    if (e != null)                    {                        employees.Remove(e);                        Console.WriteLine("Deleted");                    }                    else                        Console.WriteLine("Error");                }                //Edit                 else if (choice == "Edit")                {                    Console.Write("Enter email: ");                    string email = Console.ReadLine();                    Employee e = employees.Find(x => x.email == email);                    if (e != null)                    {                        Console.Write("New name: ");                        e.name = Console.ReadLine();                        Console.Write("New position: ");                        e.position = Console.ReadLine();                        Console.Write("New salary: ");                        e.salary = double.Parse(Console.ReadLine());                        Console.Write("New email: ");                        e.email = Console.ReadLine();                        Console.WriteLine("Added");                    }                    else                        Console.WriteLine("Error");                }                //Search                else if (choice == "S")                {                    Console.WriteLine("1. Search by name");                    Console.WriteLine("2. Search by salary");                    string s = Console.ReadLine();                    if (s == "1")                    {                        Console.Write("Enter name: ");                        string name = Console.ReadLine();                        Employee e = employees.Find(x => x.name == name);                        if (e != null)                            e.Show();                        else                            Console.WriteLine("Error");                    }                    else if (s == "2")                    {                        Console.Write("Enter min salary: ");                        double min = double.Parse(Console.ReadLine());                        Console.Write("Enter max salary: ");                        double max = double.Parse(Console.ReadLine());                        foreach (Employee e in employees)                        {                            if (e.salary >= min && e.salary <= max)                                e.Show();                        }                    }                }                //Sort                else if (choice == "Sort")                {                    Console.WriteLine("1. Sort by name");                    Console.WriteLine("2. Sort by salary");                    Console.WriteLine("3. Sort by position");                    string s = Console.ReadLine();                    if (s == "1")                        employees.Sort((a, b) => a.name.CompareTo(b.name));                    else if (s == "2")                        employees.Sort((a, b) => a.salary.CompareTo(b.salary));                    else if (s == "3")                        employees.Sort((a, b) => a.position.CompareTo(b.position));                    foreach (Employee e in employees)                        e.Show();                }                //Exit program                else if (choice == "X")                {                    break;                }            }        }    }}