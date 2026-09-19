#pragma once

#include "Continent.h"
#include "Wildebeest.h"
#include "Lion.h"


class Africa : public Continent {
public:
    Herbivore* CreateHerbivore() override {
        return new Wildebeest(100.0);
    }

    Carnivore* CreateCarnivore() override {
        return new Lion(110.0);
    }
};
