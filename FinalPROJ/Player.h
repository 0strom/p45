#pragma once
#include <string>

using namespace std;

class Player {
protected:
	string name;
	int maxRun = 0;
	int maxJump = 0;
	virtual void run() = 0; //methods every decendent class have (dog, human)
	virtual void jump() = 0;

public:
	Player(string name, int maxRun, int maxJump)
		: name(name), maxRun(maxRun), maxJump(maxJump) {}

	virtual bool run(int distance) = 0;
	virtual bool jump(int height) = 0;

	string getName() const { return name; }


	virtual ~Player() = default; //default virtual destructor to prevent resorse leaks 
};
