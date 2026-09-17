#pragma once
#include <iostream>
using namespace std;

class Transport {
protected:
    string m_fuelType; 
    double m_fuelCap; 

public:
    virtual ~Transport() {}

    void SetSpec(const string fuelType) {
        m_fuelType = fuelType;
        m_fuelCap = 0;
    }

    void SetSpec(const string fuelType, const double fuelCap) {
        m_fuelType = fuelType;
        m_fuelCap = fuelCap;
    }

    virtual void ShowInfo() const = 0;
};

