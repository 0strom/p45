#pragma once
#include "Transport.h"
using namespace std;

class Moto :
    public Transport
{
private:
    double m_maxSpeed;

public:
    Moto()
    {
        m_maxSpeed = 0;
    }

    void SetMaxSpeed(double maxSpeed)
    {
        m_maxSpeed = maxSpeed;
    }

    double GetMaxSpeed() const
    {
        return m_maxSpeed;
    }

    void ShowInfo() const override;

};
