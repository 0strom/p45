using System;
using System.Collections.Generic;


interface ICalc
{
    int Less(int valueToCompare);
    int Greater(int valueToCompare);
}

interface IOutput2
{
    void ShowEven();
    void ShowOdd();
}

interface ICalc2
{
    int CountDistinct();
    int EqualToValue(int valueToCompare);
}

class MyArray : ICalc, IOutput2, ICalc2
{
    private int[] data;

    public MyArray(int[] data)
    {
        this.data = data;
    }


    // 
    public int Less(int val)
    {
        int count = 0;
        foreach (var x in data)
        {
            if (x < val) count++;
        }
        return count;
    }

    public int Greater(int val)
    {
        int count = 0;
        foreach (var x in data)
        {
            if (x > val) count++;
        }
        return count;
    }

    // 
    public void ShowEven()
    {
        Console.Write("Even numbers: ");
        foreach (var x in data)
        {
            if (x % 2 == 0) Console.Write(x + " ");
        }
        Console.WriteLine();
    }

    public void ShowOdd()
    {
        Console.Write("Odd numbers: ");
        foreach (var x in data)
        {
            if (x % 2 != 0) Console.Write(x + " ");
        }
        Console.WriteLine();
    }

    // 
    public int CountDistinct()
    {
        HashSet<int> set = new HashSet<int>(data);
        return set.Count;
    }

    public int EqualToValue(int val)
    {
        int count = 0;
        foreach (var x in data)
        {
            if (x == val) count++;
        }
        return count;
    }

    public void Print()
    {
        Console.WriteLine("Array: " + string.Join(", ", data));
    }
}



// 

interface IRemoteControl
{
    void TurnOn();
    void TurnOff();
    void SetChannel(int channel);
}

class TV : IRemoteControl
{
    public void TurnOn() => Console.WriteLine("TV is ON.");
    public void TurnOff() => Console.WriteLine("TV is OFF.");
    public void SetChannel(int ch) => Console.WriteLine($"TV channel set to {ch}.");
}

class Radio : IRemoteControl
{
    public void TurnOn() => Console.WriteLine("Radio is ON.");
    public void TurnOff() => Console.WriteLine("Radio is OFF.");
    public void SetChannel(int ch) => Console.WriteLine($"Radio frequency set to {ch} FM.");
}


// 

interface IValidator
{
    bool Validate();
}

class PasswordValidator : IValidator
{
    private string pass;

    public PasswordValidator(string pass)
    {
        this.pass = pass;
    }

    public bool Validate()
    {
        if (pass != null && pass.Length >= 5)
        {
            Console.WriteLine("Password is ok.");
            return true;
        }
        Console.WriteLine("Password is too short!");
        return false;
    }
}

class EmailValidator : IValidator
{
    private string email;

    public EmailValidator(string email)
    {
        this.email = email;
    }

    public bool Validate()
    {
        if (email != null && email.Contains("@"))
        {
            Console.WriteLine("Email is ok.");
            return true;
        }
        Console.WriteLine("Bad email format!");
        return false;
    }
}


class Program
{
    static void Main()
    {
    

        MyArray arr = new MyArray(new int[] { 1, 2, 2, 5, 8, 9, 10, 5 });
        arr.Print();

        Console.WriteLine("Less than 5: " + arr.Less(5));
        Console.WriteLine("Greater than 5: " + arr.Greater(5));
        arr.ShowEven();
        arr.ShowOdd();


        Console.WriteLine("Unique count: " + arr.CountDistinct());
        Console.WriteLine("Equal to 5: " + arr.EqualToValue(5));
        Console.WriteLine();

  
        IRemoteControl myTv = new TV();
        myTv.TurnOn();
        myTv.SetChannel(7);
        myTv.TurnOff();

        Console.WriteLine();


        IValidator v1 = new PasswordValidator("123");
        v1.Validate();
        IValidator v2 = new EmailValidator("test.com");
        v2.Validate();
        IValidator v3 = new EmailValidator("test@gmail.com");
        v3.Validate();
    }
}
