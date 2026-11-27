using System;

enum StoreType
{
    Food,
    Household,
    Clothing,
    Footwear
}

class Play : IDisposable
{
    public string Name { get; set; }
    public string Autor { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }

    public Play(string name, string autor, string genre, int year)
    {
        Name = name;
        Autor = autor;
        Genre = genre;
        Year = year;
        Console.WriteLine("Play created: " + Name);
    }

    public void ShowInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Autor: " + Autor);
        Console.WriteLine("Genre: " + Genre);
        Console.WriteLine("Year: " + Year);
    }

    ~Play()
    {
        Console.WriteLine("Destructor Play: " + Name);
    }

    public void Dispose()
    {
        Console.WriteLine("Play disposed: " + Name);
    }
}

class Store : IDisposable
{
    public string Name { get; set; }
    public string Address { get; set; }
    public StoreType Type { get; set; }

    public Store(string name, string address, StoreType type)
    {
        Name = name;
        Address = address;
        Type = type;
        Console.WriteLine("Store created: " + Name);
    }

    public void ShowInfo()
    {
        Console.WriteLine("Store Name: " + Name);
        Console.WriteLine("Address: " + Address);
        Console.WriteLine("Type: " + Type);
    }

    ~Store()
    {
        Console.WriteLine("Destructor Store: " + Name);
    }

    public void Dispose()
    {
        Console.WriteLine("Store disposed: " + Name);
    }
}

class GarApp1
{
    static void TestPlay()
    {
        Play p1 = new Play("Hamlet", "William Shakespeare", "Tragedy", 1603);
        p1.ShowInfo();
        Console.WriteLine();
        p1.Dispose();
    }

    static void TestStore()
    {
        Store s1 = new Store("Good Market", "1 Main St", StoreType.Food);
        s1.ShowInfo();
        Console.WriteLine();
        s1.Dispose();
    }

    static void Main()
    {
        Console.WriteLine("Play");
        TestPlay();

        Console.WriteLine("\nStore");
        TestStore();

        Console.WriteLine("\nGarbage collector");
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}