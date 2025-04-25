#include <iostream>
#include <windows.h>
#include <conio.h>
#include "Header1.h"

using namespace std;

enum Key : short {
    LEFT = 75,
    RIGHT = 77,
    UP = 72,
    DOWN = 80
};

int main() {
    HANDLE h = GetStdHandle(STD_OUTPUT_HANDLE);
    system("title Bomberman");

    HideCursor(h);

    int map[HEIGHT][WIDTH];
    InitMap(map);
    DrawMap(h, map);

    COORD hero = { 0, 2 };
    ShowHero(h, hero);

    int coins = 0;
    UpdateCoinsUI(h, coins);

    while (true) {
        int code = _getch();
        if (code == 224) code = _getch();

        COORD old = hero;
        bool moved = false;

        switch (code) {
        case LEFT:
            if (hero.X > 0 && map[hero.Y][hero.X - 1] != WALL) {
                hero.X--;
                moved = true;
            }
            break;
        case RIGHT:
            if (map[hero.Y][hero.X + 1] != WALL) {
                hero.X++;
                moved = true;
            }
            break;
        case UP:
            if (map[hero.Y - 1][hero.X] != WALL) {
                hero.Y--;
                moved = true;
            }
            break;
        case DOWN:
            if (map[hero.Y + 1][hero.X] != WALL) {
                hero.Y++;
                moved = true;
            }
            break;
        }

        if (moved) {
            SetConsoleCursorPosition(h, old);
            SetConsoleTextAttribute(h, BLACK);
            cout << " ";
            ShowHero(h, hero);
        }

        if (map[hero.Y][hero.X] == COIN) {
            coins++;
            map[hero.Y][hero.X] = HALL;
            UpdateCoinsUI(h, coins);
        }

        if (map[hero.Y][hero.X] == ENEMY) {
            COORD pos = { WIDTH + 1, 2 };
            SetConsoleCursorPosition(h, pos);
            SetConsoleTextAttribute(h, RED);
            cout << "GAME OVER!";
            break;
        }
    }

    return 0;
}