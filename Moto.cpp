#include "Moto.h"

using namespace std;

void Moto::ShowInfo() const
{
    cout << "Fuel type: " << m_fuelType << endl;
    cout << "Fuel capacity: " << m_fuelCap << endl;
    cout << "Max Speed: " << m_maxSpeed << endl;
}