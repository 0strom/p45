#include <iostream>
#include "Human.h"
#include "Cat.h"
#include "Robot.h"
#include "Barrier.h"
#include "Treadmill.h"
#include "Wall.h"

using namespace std;

int main() {

   
    Player* players[] = {
        new Human("Derek", 150, 2),
        new Cat("Tabby", 100, 3),
        new Robot("B1", 200, 5)
    };

  
    Barrier* barriers[] = {
        new Treadmill(80),
        new Wall(2),
        new Treadmill(110),
        new Wall(4)
    };

    int playerNum = 3;
    int barrierNum = 4;

    for (int i = 0; i < playerNum; i++) {
        cout << "\n_________________________________" << endl;
        cout << "Player: " << players[i]->getName()  << endl;
        cout << "_________________________________" << endl;

        for (int j = 0; j < barrierNum; j++) {
            // Dereference pointer (*players[i]) to pass by reference (Player&)
            bool passed = barriers[j]->overcome(*players[i]);

            if (!passed) {
                cout << ">>> " << players[i]->getName() << " dropped out! <<<\n" << endl;
                break;
            }
        }
    }

    // clean up
    for (int i = 0; i < playerNum; i++) {
        delete players[i];
    }
    for (int j = 0; j < barrierNum; j++) {
        delete barriers[j];
    }

    return 0;
} 