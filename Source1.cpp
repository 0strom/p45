
#include <iostream>
#include <string>
#include "Car.h"
#include "Ship.h"
#include "Plane.h"
#include "Moto.h"
using namespace std;



int main()
{
    Car car;
    Ship ship;
    Plane plane;
    Moto moto;

    car.SetSpec("Gasoline");
    car.ShowInfo();

    ship.SetSpec("Diesel", 10000.0);
    ship.ShowInfo();

    plane.SetSpec("Jet-A", 50000.0);
    plane.ShowInfo();

    moto.SetSpec("Gasoline", 15.0);
    moto.ShowInfo();



Transport* ptr = nullptr;
int v;
cout << "1.Car\n 2.Ship\n 3.Plane\n 4.Moto";
cin >> v;
switch (v)
{
case 1:
    ptr = new Car();
    break;
case 2:
    ptr = new Ship();
    break;
case 3:
    ptr = new Plane();
    break;
case 4:
    ptr = new Moto();
    break;
default:
    cout << "Error\n";
    break;
}
if (ptr != nullptr) {

    ptr->SetSpec("hybrid", 100.0);
    ptr->ShowInfo();

    delete ptr;
}

return 0;

}