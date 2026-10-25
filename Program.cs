

using System;


class BookList
{
    public string[] Books = new string[100];
    public int Count = 0;

    public string this[int i]
    {
        get { return Books[i]; }
        set { Books[i] = value; }
    }

    public static BookList operator +(BookList b, string name)
    {
        b.Books[b.Count] = name;
        b.Count++;
        return b;
    }

    public static BookList operator -(BookList b, string name)
    {
        for (int i = 0; i < b.Count; i++)
        {
            if (b.Books[i] == name)
            {
                for (int j = i; j < b.Count - 1; j++)
                    b.Books[j] = b.Books[j + 1];

                b.Count--;
                break;
            }
        }

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
                throw new Exception("Cant be 0");
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
        return new GBP(u.Amount / 1.25);
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
    public double Rate { get; set; } = 1.25;
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
        ///////////
        BookList books = new BookList();

        books = books + "Animal farm";
        books = books + "Romeo and Juliet";
        books = books + "The metamorphosis";

        Console.WriteLine("Books:");
        for (int i = 0; i < books.Count; i++)
            Console.WriteLine(books[i]);

        Console.WriteLine("First book: " + books[0]);
        books = books - "Animal farm";
        Console.WriteLine("Has Romeo and Juliet: " + books.Contains("Romeo and Juliet"));

        ///////////
        Fraction f1 = new Fraction(1, 2);
        Fraction f2 = new Fraction(1, 3);

        Console.WriteLine("\nFractions:");
        Console.WriteLine(f1 + f2);
        Console.WriteLine(f1 - f2);
        Console.WriteLine(f1 * f2);
        Console.WriteLine(f1 / f2);
        Console.WriteLine(f1 == f2);
        Console.WriteLine(f1 != f2);
        Console.WriteLine(new Fraction(4, 6).Reduce());

        ///////////
        USD dollars = new USD(100);
        EUR euros = dollars;
        GBP pounds = (GBP)dollars;

        Console.WriteLine("\nYour currency:");
        Console.WriteLine(dollars.Amount + " " + dollars.Name);
        Console.WriteLine(euros.Amount + " " + euros.Name);
        Console.WriteLine(pounds.Amount + " " + pounds.Name);

        USD backToDollars = euros;
        Console.WriteLine(backToDollars.Amount + " " + backToDollars.Name);
    }
}
