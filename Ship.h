using namespace std;
#pragma once
#include "Transport.h"

class Ship :
    public Transport
{
private:
    double m_numDecks;

public:
    Ship()
    {
        m_numDecks = 0;
    }

    void SetMaxSpeed(double numDecks)
    {
        m_numDecks = numDecks;
    }

    double GetMaxSpeed() const
    {
        return m_numDecks;
    }

    void ShowInfo() const override;
};
