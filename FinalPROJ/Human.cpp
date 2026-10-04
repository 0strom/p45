
#include <iostream>
#include "Human.h"
using namespace std;

// Constructor
Human::Human(string name, int maxRun, int maxJump)
    : Player(name, maxRun, maxJump) {
}

// Basic actions
void Human::run() {}

void Human::jump() {}

// Running through obstacle
bool Human::run(int distance) {
    if (distance <= maxRun) {
        cout << "Player " << name << " passed obstacle Treadmill at distance " << distance << endl;
        return true;
    }
    else {
        cout << "Player " << name << " failed obstacle Treadmill at distance " << distance
            << ". Passed: " << maxRun << endl;
        return false;
    }
}

// Jumping over obstacle
bool Human::jump(int height) {
    if (height <= maxJump) {
        cout << "Player " << name << " passed obstacle Wall at distance " << height << endl;
        return true;
    }

    else {
        cout << "Player " << name << " failed obstacle Wall at distance " << height
            << ". Passed: " << maxJump << endl;
        return false;
    }
}