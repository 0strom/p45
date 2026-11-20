using System;

class CreditCard
{
    public string number;
    public string owner;
    public string date;
    private string pin;

    public decimal limit;
    public decimal money;
    public decimal creditUsed = 0;

    public event Action<decimal> MoneyAdded;
    public event Action<decimal> MoneySpent;
    public event Action CreditStarted;
    public event Action<decimal> TargetReached;
    public event Action PinChanged;

    decimal target = 1000;

    public CreditCard(string num, string name, string exp,
        string p, decimal l, decimal m)
    {
        number = num;
        owner = name;
        date = exp;
        pin = p;
        limit = l;
        money = m;
    }

    public void AddMoney(decimal amount)
    {
        if (amount <= 0) return;

        decimal old = money;
        money += amount;

        MoneyAdded?.Invoke(amount);

        if (old < target && money >= target)
            TargetReached?.Invoke(money);
    }

    public void SpendMoney(decimal amount)
    {
        if (amount <= 0) return;

        if (amount > money + limit - creditUsed)
        {
            Console.WriteLine("Not enough money!");
            return;
        }

        if (amount > money)
        {
            decimal credit = amount - money;
            money = 0;

            if (creditUsed == 0)
                CreditStarted?.Invoke();

            creditUsed += credit;
        }
        else
        {
            money -= amount;
        }

        MoneySpent?.Invoke(amount);
    }


    public void ChangePin(string oldPin, string newPin)
    {
        if (pin == oldPin)
        {
            pin = newPin;
            PinChanged?.Invoke();
        }
        else
        {
            Console.WriteLine("Wrong PIN!");
        }
    }

    public void ShowInfo()
    {
        Console.WriteLine("Card number: " + number);
        Console.WriteLine("Owner: " + owner);
        Console.WriteLine("Expiration date: " + date);
        Console.WriteLine("Money: " + money);
        Console.WriteLine("Credit limit: " + limit);
        Console.WriteLine("Credit used: " + creditUsed);
    }
}

class Program
{
    static void Main()
    {
        CreditCard card = new CreditCard(
            "123456789",
            "John Smith",
            "12/28",
            "1234",
            2000,
            500
        );

        card.MoneyAdded += amount =>
            Console.WriteLine("Money added: " + amount);

        card.MoneySpent += amount =>
            Console.WriteLine("Money spent: " + amount);



        card.CreditStarted += () =>
            Console.WriteLine("Credit money started being used!");

        card.TargetReached += amount =>
            Console.WriteLine("Target reached! Money: " + amount);

        card.PinChanged += () =>
            Console.WriteLine("PIN successfully changed!");

        Console.WriteLine("CARD INFO");
        card.ShowInfo();

        Console.WriteLine("\nAdding money:");
        card.AddMoney(600);

        Console.WriteLine("\nSpending money:");
        card.SpendMoney(300);

        Console.WriteLine("\nUsing credit:");
        card.SpendMoney(1000);

        Console.WriteLine("\nChanging PIN:");
        card.ChangePin("1234", "5678");

        Console.WriteLine("\nAdding more money:");
        card.AddMoney(500);

        Console.WriteLine("\nFINAL CARD INFO");
        card.ShowInfo();
    }
}
