#pragma once

#include "Continent.h"
#include "Bison.h"
#include "Wolf.h"


class NorthAmerica : public Continent {
public:

    Herbivore* CreateHerbivore() override {
        return new Bison(300.0);
    }

    Carnivore* CreateCarnivore() override {
        return new Wolf(200.0);
    }
};
