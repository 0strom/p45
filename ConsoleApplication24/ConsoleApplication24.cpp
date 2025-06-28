#include <iostream>
#include <string>
using namespace std;

class Guitar {
private:
    string color;
    int strings = 6;
    string name;
    string modelname;

public:
    void SetColor(string color) {
        this->color = color;
    }


    void SetStrings(int strings) {
        if (strings >= 6 && strings <= 12)
            this->strings = strings;
    }
    void SetName(string name) {
        this->name = name;
    }
    void SetModelName(string modelname) {
        this->modelname = modelname;
    }


    string GetColor() {
        return color;
    }
    int GetStrings() {
        return strings;
    }
    string GetName() {
        return name;
    }
    string GetModelName() {
        return modelname;
    }


    void Play() {
        cout << name << " is being played...\n";
    }
    void OutOfTune() {
        cout << name << " is detuned\n";
    }
    void Tuned() {
        cout << name << ": is tuned, you can play again\n";
    }

    class Book {

    private:
        string color;
        int pages = 10;
        string name;

    public:
        void SetColor(string c) {
            color = c;
        }
        void SetPages(int p) {
            if (p > 0 && p <= 10000) pages = p;
        }
        void SetName(string n) {
            name = n;
        }

        string GetColor() {
            return color;
        }
        int GetPages() {
            return pages;
        }
        string GetName() {
            return name;
        }

        void Read() {
            cout << name << " is being read...\n";
        }
        void Buy() {
            cout << "New book - " << name << " - is bought\n";
        }
        void Finish() {
            cout << name << " is finished, go buy a new one!\n";
        }
    };



    class Drink {

    private:
        double price = 0.99;
        string flavour;
        string brandname;

    public:
        void SetPrice(double p) {
            if (p >= 0) price = p;
        }
        void SetFlavour(string f) {
            flavour = f;
        }
        void SetBrandName(string b) {
            brandname = b;
        }

        double GetPrice() {
            return price;
        }
        string GetFlavour() {
            return flavour;
        }
        string GetBrandName() {
            return brandname;
        }

        void ReadDrink() {
            cout << brandname << " is the name of it\n";
        }
        void Drinking() {
            cout << flavour << " is good\n";
        }
        void Throw() {
            cout << brandname << " thrown away\n";
        }
    };

    class Phone {

    private:
        int battery = 100;
        string modelname;
        string brandname;

    public:
        void SetBattery(int b) {
            if (b >= 0 && b <= 100) battery = b;
        }
        void SetModelName(string m) {
            modelname = m;
        }
        void SetBrandName(string b) {
            brandname = b;
        }

        int GetBattery() {
            return battery;
        }
        string GetModelName() {
            return modelname;
        }
        string GetBrandName() {
            return brandname;
        }

        void WatchPhone() {
            cout << brandname << " — so many things to watch\n";
        }
        void LowBattery() {
            battery = 0; cout << brandname << " 0%\n";
        }

        void Charge() {
            battery = 100; cout << brandname << " 100%\n";
        }
    };


    class Door {

    private:
        string name;
        string status;

    public:
        void SetName(string n) {
            name = n;
        }
        void SetStatus(string s) {
            status = s;
        }

        string GetName() {
            return name;
        }
        string GetStatus() {
            return status;
        }

        void Open() {
            status = "opened";
            cout << name << " is opened\n";
        }
        void Close() {
            status = "closed";
            cout << name << " is closed\n";
        }
        void Broken() {
            cout << name << " is broken, you cannot use it!\n";
        }
    };



    class Calculator {
    private:
        string name;

    public:
        void SetName(string n) {
            name = n;
        }
        string GetName() {
            return name;
        }

        void On() { cout << name << " is On\n"; }

        void CalculateSum() {
            int a, b;
            cout << "Enter first number: ";
            cin >> a;
            cout << "Enter second number: ";
            cin >> b;
            cout << name << " is calculating sum...\n";
            cout << "Sum = " << a + b << "\n";
        }

        void Off() {
            cout << name << " is Off, you must turn it on!\n";
        }
    };

    int main() {
        Guitar acoustic;

        acoustic.SetModelName("Fender");
        acoustic.SetName("Blackie");
        acoustic.SetStrings(6);

        acoustic.Play();
        acoustic.OutOfTune();
        acoustic.Tuned();

        cout << "\n";

        Book newbook;

        newbook.SetName("Funny Book");
        newbook.SetPages(150);

        newbook.Buy();
        newbook.Read();
        newbook.Finish();

        cout << "\n";

        Drink cola;

        cola.SetBrandName("Coca-Cola");
        cola.SetPrice(0.99);
        cola.SetFlavour("Cherry");

        cola.ReadDrink();
        cola.Drinking();
        cola.Throw();

        cout << "\n";

        Phone myphone;

        myphone.SetBrandName("IPHONE");
        myphone.SetBattery(99);
        myphone.SetModelName("IPHONE SE");

        myphone.WatchPhone();
        myphone.LowBattery();
        myphone.Charge();

        cout << "\n";

        Door kitchendoor;


        kitchendoor.SetName("Pink Door");
        kitchendoor.SetStatus("closed");

        kitchendoor.Close();
        kitchendoor.Open();
        cout << "\n";

        Door balcondoor;


        balcondoor.SetName("White Door");
        balcondoor.SetStatus("opened");

        balcondoor.Open();
        balcondoor.Close();

        cout << "\n";

        Calculator mycalc;


        mycalc.SetName("Casio 1");
        mycalc.Off();
        mycalc.On();
        mycalc.CalculateSum();
        mycalc.Off();

    }
}