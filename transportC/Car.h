using namespace std;
#pragma once
#include "Transport.h"


class Car :
    public Transport
{
private:
    double m_avgSpeed;

public:
    Car()
    {
        m_avgSpeed = 0;
    }

    void SetMaxSpeed(double avgSpeed)
    {
        m_avgSpeed = avgSpeed;
    }

    double GetMaxSpeed() const
    {
        return m_avgSpeed;
    }

    void ShowInfo() const override;
};