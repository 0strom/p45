
using System;
using System.Collections.Generic;

class BookList
{
    public List<string> Books { get; set; } = new List<string>();

    public string this[int i]
    {
        get { return Books[i]; }
        set { Books[i] = value; }
    }

    public static BookList operator +(BookList b, string name)
    {
        b.Books.Add(name);
        return b;
    }

    public static BookList operator -(BookList b, string name)
    {
        b.Books.Remove(name);
        return b;
    }
}

class Fraction
{
    public int N { get; set; }
    public int D
    {
        get { return d; }
        set
        {
            if (value == 0)
                throw new Exception("Denominator cannot be zero");
            d = value;
        }
    }

    private int d;

    public Fraction(int n, int d)
    {
        N = n;
        D = d;
    }

    public override string ToString()
    {
        return N + "/" + D;
    }

    public static Fraction operator +(Fraction a, Fraction b)
    {
        return new Fraction(a.N * b.D + b.N * a.D, a.D * b.D);
    }

    public static Fraction operator -(Fraction a, Fraction b)
    {
        return new Fraction(a.N * b.D - b.N * a.D, a.D * b.D);
    }

    public static Fraction operator *(Fraction a, Fraction b)
    {
        return new Fraction(a.N * b.N, a.D * b.D);
    }

    public static Fraction operator /(Fraction a, Fraction b)
    {
        return new Fraction(a.N * b.D, a.D * b.N);
    }

    public static bool operator ==(Fraction a, Fraction b)
    {
        return a.N * b.D == b.N * a.D;
    }

    public static bool operator !=(Fraction a, Fraction b)
    {
        return !(a == b);
    }

    public override bool Equals(object obj)
    {
        if (obj is Fraction f)
            return this == f;
        return false;
    }

    public override int GetHashCode()
    {
        return N.GetHashCode() + D.GetHashCode();
    }

    public Fraction Reduce()
    {
        int a = Math.Abs(N);
        int b = Math.Abs(D);

        while (b != 0)
        {
            int t = b;
            b = a % b;
            a = t;
        }

        return new Fraction(N / a, D / a);
    }
}

class USD
{
    public double Amount { get; set; }
    public double Rate { get; set; } = 1;
    public string Name { get; set; } = "USD";

    public USD(double amount)
    {
        Amount = amount;
    }

    public static implicit operator EUR(USD u)
    {
        return new EUR(u.Amount / 1.08);
    }

    public static explicit operator GBP(USD u)
    {
        return new GBP(u.Amount / 1.27);
    }
}

class EUR
{
    public double Amount { get; set; }
    public double Rate { get; set; } = 1.08;
    public string Name { get; set; } = "EUR";

    public EUR(double amount)
    {
        Amount = amount;
    }

    public static implicit operator USD(EUR e)
    {
        return new USD(e.Amount * e.Rate);
    }
}

class GBP
{
    public double Amount { get; set; }
    public double Rate { get; set; } = 1.27;
    public string Name { get; set; } = "GBP";

    public GBP(double amount)
    {
        Amount = amount;
    }

    public static explicit operator USD(GBP g)
    {
        return new USD(g.Amount * g.Rate);
    }
}

class Program
{
    static void Main()
    {
        // Task 1: Books
        BookList books = new BookList();
        books = books + "Harry Potter";
        books = books + "The Hobbit";

        Console.WriteLine("Books:");
        foreach (string b in books.Books)
            Console.WriteLine(b);

        Console.WriteLine("First book: " + books[0]);
        books = books - "Harry Potter";

        Console.WriteLine("Has Hobbit: " + books.Books.Contains("The Hobbit"));

        // Task 2: Fractions
        Fraction f1 = new Fraction(1, 2);
        Fraction f2 = new Fraction(1, 3);

        Console.WriteLine("\nFractions:");
        Console.WriteLine(f1 + f2);
        Console.WriteLine(f1 - f2);
        Console.WriteLine(f1 * f2);
        Console.WriteLine(f1 / f2);
        Console.WriteLine(f1 == f2);
        Console.WriteLine(f1 != f2);
        Console.WriteLine(new Fraction(2, 4).Reduce());

        // Task 3: Currency
        USD dollars = new USD(100);
        EUR euros = dollars;
        GBP pounds = (GBP)dollars;

        Console.WriteLine("\nCurrency:");
        Console.WriteLine(dollars.Amount + " " + dollars.Name);
        Console.WriteLine(euros.Amount + " " + euros.Name);
        Console.WriteLine(pounds.Amount + " " + pounds.Name);

        USD backToDollars = euros;
        Console.WriteLine(backToDollars.Amount + " " + backToDollars.Name);
    }
}