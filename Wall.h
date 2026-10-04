#pragma once
#include "Barrier.h"

class Player;

class Wall : public Barrier {
private:
	int height;
public:

	Wall(int height);
	virtual bool overcome(Player& player);


	virtual ~Wall() = default;
};
