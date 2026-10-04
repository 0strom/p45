#include <iostream>
#include "Robot.h"
using namespace std;

Robot::Robot(string name, int maxRun, int maxJump)
    : Player(name, maxRun, maxJump) {
}

void Robot::run() {}

void Robot::jump() {}

bool Robot::run(int distance) {
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

bool Robot::jump(int height) {
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