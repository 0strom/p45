#pragma once

class Player;

class Barrier {
public:
	virtual bool overcome(Player& player) = 0;
	

virtual ~Barrier() = default; //default virtual destructor to prevent resorse leaks 
};