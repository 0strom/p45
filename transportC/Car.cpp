#include "Car.h"

using namespace std;

void Car::ShowInfo() const
{
    cout << "Fuel type: " << m_fuelType << endl;
    cout << "Fuel capacity: " << m_fuelCap << endl;
    cout << "Average Speed: " << m_avgSpeed << endl;
}