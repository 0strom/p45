#pragma once
#include "Barrier.h"

class Player;

class Treadmill : public Barrier {
private:
	int length;

public:
	Treadmill(int length);
    virtual bool overcome(Player& player);


	virtual ~Treadmill() = default;
};
