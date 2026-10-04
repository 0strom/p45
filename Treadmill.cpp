#include <iostream>
#include "Treadmill.h"
#include "Player.h"

using namespace std;

Treadmill::Treadmill(int length) : length(length) {}

bool Treadmill::overcome(Player& player) {
    return player.run(length);
}
