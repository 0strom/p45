#include "Plane.h"

using namespace std;

void Plane::ShowInfo() const
{
    cout << "Fuel type: " << m_fuelType << endl;
    cout << "Fuel capacity: " << m_fuelCap << endl;
    cout << "Plane capacity: " << m_capacity << endl;
}