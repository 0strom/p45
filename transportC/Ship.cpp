#include "Ship.h"

using namespace std;

void Ship::ShowInfo() const
{
    cout << "Fuel type: " << m_fuelType << endl;
    cout << "Fuel capacity: " << m_fuelCap << endl;
    cout << "Number of decks: " << m_numDecks << endl;
}