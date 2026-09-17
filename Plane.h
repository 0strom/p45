#pragma once
#include "Transport.h"
using namespace std;

class Plane :
    public Transport
{
private:
    double m_capacity;

public:
    Plane()
    {
        m_capacity = 0;
    }

    void SetMaxSpeed(double capacity)
    {
        m_capacity = capacity;
    }

    double GetMaxSpeed() const
    {
        return m_capacity;
    }

    void ShowInfo() const override;

};

