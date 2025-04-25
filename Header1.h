#pragma once
#include <windows.h>

enum GameObject : short { HALL, WALL, COIN, ENEMY };

enum Color : short {
    BLACK, DARKBLUE, DARKGREEN, TURQUOISE, DARKRED,
    PURPLE, DARKYELLOW, GREY, DARKGREY, BLUE, GREEN,
    CYAN, RED, PINK, YELLOW, WHITE
};

const int HEIGHT = 25;
const int WIDTH = 65;

// Function Prototypes
void HideCursor(HANDLE h);
void InitMap(int map[HEIGHT][WIDTH]);
void DrawMap(HANDLE h, int map[HEIGHT][WIDTH]);
void ShowHero(HANDLE h, COORD hero);
void UpdateCoinsUI(HANDLE h, int coins); CoinsUI(HANDLE h, int coins);