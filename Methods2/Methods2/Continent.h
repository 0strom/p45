#pragma once
#include "Herbivore.h"
#include "Carnivore.h"

class Continent {

public:
    virtual ~Continent() {}

    virtual Herbivore* CreateHerbivore() = 0;
    virtual Carnivore* CreateCarnivore() = 0;
};
