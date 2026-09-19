#pragma once
#include <iostream>
#include "Herbivore.h"
#include "Carnivore.h"

using namespace std;


class AnimalWorld {
private:

    Herbivore* m_Herbivore;
    Carnivore* m_Carnivore;

public:
    
    AnimalWorld(Herbivore* herbivore, Carnivore* carnivore) : m_Herbivore(herbivore), m_Carnivore(carnivore) {
    }

    ~AnimalWorld() {
        delete m_Herbivore;
        delete m_Carnivore;
    }

    void EatHerbivores() {
        m_Herbivore->EatGrass();
    }

    void EatCarnivores() {
        m_Carnivore->Eat(m_Herbivore);
    }

    void ShowWorldInfo() const {
        cout << "\nInfo:" << endl;
        m_Herbivore->ShowInfo();
        m_Carnivore->ShowInfo();
    }
};