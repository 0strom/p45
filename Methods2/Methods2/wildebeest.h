#pragma once
#include <iostream>
#include "Herbivore.h"

using namespace std;

class Wildebeest: public Herbivore {
public:
    Wildebeest(double weight) : Herbivore(weight) {}


    void EatGrass() override {
        if (m_Life) {
            m_Weight += 10.0;
            cout << "Weight:" << m_Weight << endl;
        }
        else {
            cout << "dead" << endl;
        }
    }

    void ShowInfo() const override {
        cout << "Wildebeest Weight:" << m_Weight
            cout << "Life:";
        if (m_Life) {
            cout << "alive" << endl;
        }
        else {
            cout << "dead" << endl;
        }
    }
};
