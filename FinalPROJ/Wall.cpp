#include <iostream>
#include "Wall.h"
#include "Player.h"

using namespace std;

Wall::Wall(int height) : height(height) {}

bool Wall::overcome(Player& player) {
    return player.jump(height);

}
