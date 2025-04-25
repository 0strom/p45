#include "Header1.h"
#include <iostream>
#include <ctime>

using namespace std;

void HideCursor(HANDLE h) {
    CONSOLE_CURSOR_INFO cursor;
    cursor.bVisible = false;
    cursor.dwSize = 100;
    SetConsoleCursorInfo(h, &cursor);
}

void InitMap(int map[HEIGHT][WIDTH]) {
    srand((unsigned int)time(0));
    for (int y = 0; y < HEIGHT; y++) {
        for (int x = 0; x < WIDTH; x++) {
            map[y][x] = rand() % 4;

            if (x == 0 || y == 0 || x == WIDTH - 1 || y == HEIGHT - 1)
                map[y][x] = WALL;

            if ((x == 0 && y == 2) || (x == 1 && y == 2) || (x == 2 && y == 2) ||
                (x == WIDTH - 1 && y == HEIGHT - 3) ||
                (x == WIDTH - 2 && y == HEIGHT - 3) ||
                (x == WIDTH - 3 && y == HEIGHT - 3))
                map[y][x] = HALL;

            if (map[y][x] == ENEMY && rand() % 10 != 0)
                map[y][x] = HALL;
        }
    }
}

void DrawMap(HANDLE h, int map[HEIGHT][WIDTH]) {
    for (int y = 0; y < HEIGHT; y++) {
        for (int x = 0; x < WIDTH; x++) {
            switch (map[y][x]) {
            case HALL:
                SetConsoleTextAttribute(h, BLACK);
                cout << " ";
                break;
            case WALL:
                SetConsoleTextAttribute(h, DARKGREEN);
                cout << (char)178;
                break;
            case COIN:
                SetConsoleTextAttribute(h, YELLOW);
                cout << ".";
                break;
            case ENEMY:
                SetConsoleTextAttribute(h, RED);
                cout << "O";
                break;
            }
        }
        cout << "\n";
    }
}

void ShowHero(HANDLE h, COORD hero) {
    SetConsoleCursorPosition(h, hero);
    SetConsoleTextAttribute(h, BLUE);
    cout << "O";
}

void UpdateCoinsUI(HANDLE h, int coins) {
    COORD pos = { WIDTH + 1, 0 };
    SetConsoleCursorPosition(h, pos);
    SetConsoleTextAttribute(h, DARKYELLOW);
    cout << "COINS: ";
    SetConsoleTextAttribute(h, YELLOW);
    cout << coins << "   ";
}