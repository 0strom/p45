#pragma once
#include <iostream>
#include "Carnivore.h"

using namespace std;

class Wolf : public Carnivore {

public:
    Wolf(double power) : Carnivore(power) {}

    void Eat(double Weight) override {
        if (m_Power > Weight) {
            m_Power += 10.0;
            cout << "Power: " << m_Power << endl;
        }
        else {
            m_Power -= 10.0;
            cout << "Power: " << m_Power << endl;
        }
    }

    void ShowInfo() const override {
        cout << "Wolf Power: " << m_Power << endl;
    }
};