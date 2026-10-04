#pragma once
#include "Player.h"

class Human: public Player {
protected:
    // Required: Override the protected pure virtual methods from Player
    void run() override;
    void jump() override;
public:
    Human(string name, int maxRun, int maxJump);

    bool run(int distance) override;
    bool jump(int height) override;

    ~Human() override = default;


};
