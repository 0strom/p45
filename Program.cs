

using System;




class Website
{
    public string Name { get; set; }
    public string Path { get; set; }
    public string Description { get; set; }
    public string Address { get; set; }

    public void Input()
    {
        Console.Write("Website name: ");
        Name = Console.ReadLine();

        Console.Write("Website path: ");
        Path = Console.ReadLine();

        Console.Write("Description: ");
        Description = Console.ReadLine();

        Console.Write("Website address: ");
        Address = Console.ReadLine();
    }

    public override string ToString()
    {
        return "Name: " + Name + "\n" +
               "Path: " + Path + "\n" +
               "Description: " + Description + "\n" +
               "Address: " + Address;
    }
}



class Journal
{
    private string name = "";
    private int year;
    private string description = "";
    private string phone = "";
    private string email = "";
    private int employees;

   

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Year
    {
        get { return year; }
        set { year = value; }
    }
    public string Description
    {
        get { return description; }
        set { description = value; }
    }
    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }
    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public int Employees
    {
        get { return employees; }
        set
        {
            if (value < 0)
                throw new ArgumentException(
                    "Employees must be real");

            employees = value;
        }
    }


    public void Input()
    {
        Console.Write("Name: ");
        Name = Console.ReadLine();

        Console.Write("Year: ");
        Year = Convert.ToInt32(Console.ReadLine());

        Console.Write("Description: ");
        Description = Console.ReadLine();

        Console.Write("Phone: ");
        Phone = Console.ReadLine();

        Console.Write("Email: ");
        Email = Console.ReadLine();

        Console.Write("Employees: ");
        Employees = Convert.ToInt32(Console.ReadLine());
    }

    public override string ToString()
    {
        string result = "Journal name: " + Name + "\n";
        result += "Year: " + Year + "\n";
        result += "Description: " + Description + "\n";
        result += "Phone: " + Phone + "\n";
        result += "Email: " + Email + "\n";
        result += "Employees: " + Employees;

        return result;
    }

    
    public static Journal operator +(Journal journal, int amount)
    {
        return new Journal
        {
            Name = journal.Name,
            Year = journal.Year,
            Description = journal.Description,
            Phone = journal.Phone,
            Email = journal.Email,
            Employees = checked(journal.Employees + amount)
        };
    }

   
    public static Journal operator -(Journal journal, int amount)
    {
        return new Journal
        {
            Name = journal.Name,
            Year = journal.Year,
            Description = journal.Description,
            Phone = journal.Phone,
            Email = journal.Email,
            Employees = checked(journal.Employees - amount)
        };
    }

    

    public static bool operator ==(Journal a, Journal b)
    {
        if (ReferenceEquals(a, b))
            return true;

        if (a is null || b is null)
            return false;

        return a.Employees == b.Employees;
    }

    

    public static bool operator !=(Journal a, Journal b)
    {
        return !(a == b);
    }

    
    public static bool operator >(Journal a, Journal b)
    {
        if (a is null || b is null)
            return false;

        return a.Employees > b.Employees;
    }

   
    public static bool operator <(Journal a, Journal b)
    {
        if (a is null || b is null)
            return b is not null;

        return b is not null && a.Employees < b.Employees;
    }

   
    public override bool Equals(object? obj)
    {
        if (obj is not Journal other)
            return false;

        return Employees == other.Employees;
    }

    public override int GetHashCode()
    {
        return Employees.GetHashCode();
    }
}




class Shop
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Description { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public void Input()
    {
        Console.Write("Shop name: ");
        Name = Console.ReadLine();

        Console.Write("Shop address: ");
        Address = Console.ReadLine();

        Console.Write("Shop description: ");
        Description = Console.ReadLine();

        Console.Write("Phone: ");
        Phone = Console.ReadLine();

        Console.Write("Email: ");
        Email = Console.ReadLine();
    }

    public override string ToString()
    {
        return "Name: " + Name + "\n" +
               "Address: " + Address + "\n" +
               "Description: " + Description + "\n" +
               "Phone: " + Phone + "\n" +
               "Email: " + Email;
    }
}





class Program
{
    static void Main()
    {

        Website website = new Website();

        Console.WriteLine("Website info:");
        website.Input();
        Console.WriteLine("\nWebsite info:");
        Console.WriteLine(website);


        Journal j1 = new Journal();
        j1.Input();

        Journal j2 = new Journal();
        j2.Input();

        Console.WriteLine(j1);
        Console.WriteLine(j2);

        Console.WriteLine("Add: " + (j1 + 3).Employees);
        Console.WriteLine("Remove: " + (j1 - 2).Employees);

        Console.WriteLine("Equal: " + (j1 == j2));
        Console.WriteLine("Not equal: " + (j1 != j2));
        Console.WriteLine("Greater: " + (j1 > j2));
        Console.WriteLine("Smaller: " + (j1 < j2));
        Console.WriteLine("Equals: " + j1.Equals(j2));

        Shop shop = new Shop();

        Console.WriteLine("Shop info:");
        shop.Input();
        Console.WriteLine("\nShop info:");
        Console.WriteLine(shop);

        Console.ReadKey();
    }


}















    class TemperatureArray
    {
        public double Monday { get; set; }
        public double Tuesday { get; set; }
        public double Wednesday { get; set; }
        public double Thursday { get; set; }
        public double Friday { get; set; }
        public double Saturday { get; set; }
        public double Sunday { get; set; }

        public double this[int day]
        {
            get
            {
                if (day == 1) return Monday;
                if (day == 2) return Tuesday;
                if (day == 3) return Wednesday;
                if (day == 4) return Thursday;
                if (day == 5) return Friday;
                if (day == 6) return Saturday;
                if (day == 7) return Sunday;

                throw new Exception("error");
            }
            set
            {
                if (day == 1) Monday = value;
                else if (day == 2) Tuesday = value;
                else if (day == 3) Wednesday = value;
                else if (day == 4) Thursday = value;
                else if (day == 5) Friday = value;
                else if (day == 6) Saturday = value;
                else if (day == 7) Sunday = value;
                else throw new Exception("error");
            }
        }

        public double Average()
        {
            return (Monday + Tuesday + Wednesday +
                    Thursday + Friday + Saturday + Sunday) / 7;
        }
    }

    class Program2
    {
        static void Main()
        {
            TemperatureArray temp = new TemperatureArray();
            for (int i = 1; i <= 7; i++)
            {
                Console.Write("Temperature" + i + ": ");
                temp[i] = Convert.ToDouble(Console.ReadLine());
            }


            Console.WriteLine("Avg temperature: " + temp.Average());

            Console.Write("Day 1-7: ");
            int day = Convert.ToInt32(Console.ReadLine());


            Console.Write("New temperature: ");
            temp[day] = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("New Avg: " + temp.Average());
        }
    }

}