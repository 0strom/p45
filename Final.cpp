
#include <iostream>
#include <windows.h> // COORD HANDLE SetConsoleTextAttribute SetConsoleCursorPosition
#include "menu.h"
#include <conio.h>

using namespace std;

enum GameObject : short { HALL, WALL, COIN, ENEMY, PACMAN };
enum Color : short {
    BLACK, DARKBLUE, DARKGREEN, TURQUOISE, DARKRED,
    PURPLE, DARKYELLOW, GREY, DARKGREY, BLUE, GREEN,
    CYAN, RED, PINK, YELLOW, WHITE
};
enum Key : short {
    LEFT = 75, RIGHT = 77, UP = 72, DOWN = 80,
    ENTER = 13, SPACE = 32, ESCAPE = 27, BACKSPACE = 8
};
const int HEIGHT = 20;
const int WIDTH = 40;
int map[HEIGHT][WIDTH];

void displayHighScores() {
    SetConsoleCP(65001);
    SetConsoleOutputCP(65001);
    FILE* file;
    int error_code = fopen_s(&file, "C:/Users/Denis/Desktop/highscores.txt", "r"); // Use your actual file path

    if (error_code == 0 && file != nullptr) {
        char* line = new char[200];
        cout << "===== HIGH SCORES =====\n";
        while (true) {
            fgets(line, 199, file);
            if (feof(file) == 0) {
                cout << line;
            }
            else {
                break;
            }
        }
        delete[] line;
        fclose(file);
    }
    else {
        cout << "Failed to load high scores. Error code: " << error_code << "\n";
    }
}


void showLoadingScreen() {
    HANDLE h = GetStdHandle(STD_OUTPUT_HANDLE); 
    const int BAR_WIDTH = 50;

    system("cls");
    system("title Loading Pac-Man");

        
  

    const int colorGradient[] = {
        15, 15, 14, 14, 14, 6, 6  // White to yellow gradient
    };
    const int GRADIENT_SIZE = sizeof(colorGradient) / sizeof(colorGradient[0]);

    // Shading gradient: Light → Medium → Heavy (░ → ▒ → ▓ → █)
    const char shadeGradient[] = {
        176, 177, 178, 219  // ░ → ▒ → ▓ → █
    };
    const int SHADE_SIZE = sizeof(shadeGradient) / sizeof(shadeGradient[0]);

    // Compute the color and character for each bar position
    int barColors[BAR_WIDTH];
    char barChars[BAR_WIDTH];
    for (int i = 0; i < BAR_WIDTH; ++i) {
        int colorIndex = (i * GRADIENT_SIZE) / BAR_WIDTH;
        int shadeIndex = (i * SHADE_SIZE) / BAR_WIDTH;
        barColors[i] = colorGradient[colorIndex];
        barChars[i] = shadeGradient[shadeIndex]; // Use shading from light to heavy
    }

    // Draw empty bar
    std::cout << "Loading: [";
    for (int i = 0; i < BAR_WIDTH; ++i) std::cout << " ";
    std::cout << "]\r";
    std::cout.flush();

    // Animate the bar filling
    for (int i = 0; i < BAR_WIDTH; ++i) {
        SetConsoleTextAttribute(h, barColors[i]);

        // Create the position for the console cursor (no need for 'short' here)
        COORD pos;
        pos.X = 9 + i;  // Adjust for "Loading: ["
        pos.Y = 0;
        SetConsoleCursorPosition(h, pos);

        // Display the respective ASCII block character
        std::cout << barChars[i];

        std::cout.flush();
        Sleep(70); // Adjust the speed here
    }


    SetConsoleTextAttribute(h, 7); 
    std::cout << "\nLoading complete...\n";
    Sleep(1000);
    system("cls");
}



void drawPacMan() {
    HANDLE h = GetStdHandle(STD_OUTPUT_HANDLE);

    const int pacManWidth = 48;
    const int pacManHeight = 7;

    const char pacMan[pacManHeight][pacManWidth + 1] = {
        "CCCCC   CCCCC   CCCCC   C    C   CCCCC   C   C",
        "C   C   C   C   C   C   CC  CC   C   C   CC  C",
        "C   C   C   C   C   C   C  C C   C   C   C C C",
        "CCcCC   CCCCC   C       C  C C   CCCCC   C  CC",
        "C       C   C   C   C   C    C   C   C   C   C",
        "C       C   C   C   C   C    C   C   C   C   C",
        "C       C   C   CCCCC   C    C   C   C   C   C"
    };

    COORD pos;
    pos.X = 10;
    pos.Y = 5;
    SetConsoleCursorPosition(h, pos);

    for (int row = 0; row < pacManHeight; ++row) {
        SetConsoleCursorPosition(h, { pos.X, static_cast<SHORT>(pos.Y + row) });
        SetConsoleTextAttribute(h, 14); 
        std::cout << pacMan[row];
    }

    std::cout << "\nPACMAN is ready!\n";
}


// Function to show the main menu
void showMenu() {
    HANDLE h = GetStdHandle(STD_OUTPUT_HANDLE);
    cout << "\n===== PAC-MAN MENU =====\n";


    SetConsoleTextAttribute(h, 10); 
    cout << "1. ▶ Start Game\n";

    SetConsoleTextAttribute(h, 11); 
    cout << "2. 🏆 View High Scores\n";

    SetConsoleTextAttribute(h, 12);
    cout << "3. ❌ Exit\n";
    
    SetConsoleTextAttribute(h, 14);
    cout << "\nChoose an option: ";
}




void generateMap() {
    for (int y = 0; y < HEIGHT; y++) {
        for (int x = 0; x < WIDTH; x++) {
            // Set border as WALL
            if (x == 0 || y == 0 || x == WIDTH - 1 || y == HEIGHT - 1)
                map[y][x] = GameObject::WALL;
            // Add some internal walls for the maze structure
            else if (rand() % 5 == 0)
                map[y][x] = GameObject::WALL;
            // Randomly set HALL, COIN, or ENEMY
            else {
                int randObj = rand() % 10;
                if (randObj < 6)
                    map[y][x] = GameObject::HALL;
                else if (randObj == 6)
                    map[y][x] = GameObject::COIN;
                else if (randObj == 7)
                    map[y][x] = GameObject::ENEMY;
                else
                    map[y][x] = GameObject::HALL;
            }
        }
    }
}

// Function to draw the map
void drawMap() {
    HANDLE h = GetStdHandle(STD_OUTPUT_HANDLE);
    for (int y = 0; y < HEIGHT; y++) {
        for (int x = 0; x < WIDTH; x++) {
            switch (map[y][x]) {
            case GameObject::HALL:
                SetConsoleTextAttribute(h, Color::BLACK);
                cout << " ";
                break;
            case GameObject::WALL:
                SetConsoleTextAttribute(h, Color::BLUE);  // Make walls blue
                cout << (char)178;  // Wall symbol
                break;
            case GameObject::COIN:
                SetConsoleTextAttribute(h, Color::YELLOW);
                cout << ".";
                break;
            case GameObject::ENEMY:
                SetConsoleTextAttribute(h, Color::RED);
                cout << "O";  // Enemy symbol
                break;
            case GameObject::PACMAN:
                SetConsoleTextAttribute(h, Color::YELLOW);  // Make Pac-Man yellow
                cout << "C";  // Pac-Man symbol (C)
                break;
            }
        }
        cout << "\n";
    }
}

// Function to move Pac-Man
void movePacman(COORD& pacman, int direction) {
    // Move Pac-Man based on key input
    switch (direction) {
    case Key::LEFT:
        if (map[pacman.Y][pacman.X - 1] != GameObject::WALL) {
            pacman.X--;
        }
        break;
    case Key::RIGHT:
        if (map[pacman.Y][pacman.X + 1] != GameObject::WALL) {
            pacman.X++;
        }
        break;
    case Key::UP:
        if (map[pacman.Y - 1][pacman.X] != GameObject::WALL) {
            pacman.Y--;
        }
        break;
    case Key::DOWN:
        if (map[pacman.Y + 1][pacman.X] != GameObject::WALL) {
            pacman.Y++;
        }
        break;
    }
}

// Function to update the game state
void updateGame(HANDLE h, COORD pacman, int& score) {

  
    // Check if Pac-Man collected a coin
    if (map[pacman.Y][pacman.X] == GameObject::COIN) {
        score++;
        map[pacman.Y][pacman.X] = GameObject::HALL;  // Replace coin with hall
    }

    // Check if Pac-Man collided with an enemy
    if (map[pacman.Y][pacman.X] == GameObject::ENEMY) {
        SetConsoleCursorPosition(h, { 0, HEIGHT });
        SetConsoleTextAttribute(h, Color::RED);
        cout << "GAME OVER! Final Score: " << score << "\n";

        // ✅ Write the score to file
        FILE* fileOut;
        int error_code = fopen_s(&fileOut, "C:/Users/Denis/Desktop/highscores.txt", "a"); // Append
        if (error_code == 0 && fileOut != nullptr) {
            fprintf(fileOut, "%d\n", score);
            fclose(fileOut);
        }
        else {
            cout << "Failed to save high score.\n";
        }

        exit(0);  // End the game
    }
}
// Main game loop
void startGame() {
    HANDLE h = GetStdHandle(STD_OUTPUT_HANDLE);
    srand(time(0));

    // Hide cursor
    CONSOLE_CURSOR_INFO cursor;
    cursor.bVisible = false;
    cursor.dwSize = 100;
    SetConsoleCursorInfo(h, &cursor);

    // Initialize map and draw it
    generateMap();
    COORD pacman = { 2, 2 }; // Starting position of Pac-Man
    int score = 0;

    // Display the score
    COORD scorePos = { WIDTH + 2, 0 };
    SetConsoleCursorPosition(h, scorePos);
    SetConsoleTextAttribute(h, Color::GREEN);
    cout << "SCORE: ";
    SetConsoleTextAttribute(h, Color::YELLOW);
    cout << score;

    // Start the game loop
    while (true) {
        // Draw the game map
        SetConsoleCursorPosition(h, { 0, 0 });
        drawMap();

        // Draw Pac-Man
        SetConsoleCursorPosition(h, pacman);
        SetConsoleTextAttribute(h, Color::YELLOW);
        cout << "C";

        // Read player input
        int key = _getch();
        if (key == 224) {
            key = _getch();  // To capture arrow keys
        }

        // Move Pac-Man based on input
        movePacman(pacman, key);

        // Update the game (check for coin collection or game over)
        updateGame(h, pacman, score);

        // Update the score display
        SetConsoleCursorPosition(h, scorePos);
        SetConsoleTextAttribute(h, Color::GREEN);
        cout << "SCORE: ";
        SetConsoleTextAttribute(h, Color::YELLOW);
        cout << score;

        // Slow down the game loop
        Sleep(100);
    }
}


int main() {
    showLoadingScreen();

    HANDLE h = GetStdHandle(STD_OUTPUT_HANDLE);
    system("title Pac-Man");

    // Hide the cursor
    CONSOLE_CURSOR_INFO cursor;
    cursor.bVisible = false;
    cursor.dwSize = 100;
    SetConsoleCursorInfo(h, &cursor);

    while (true) {
        system("cls");
        drawPacMan();      // Show Pac-Man ASCII art
        showMenu();        // Show the main menu

        int choice;
        cin >> choice;     // Get user's choice

        switch (choice) {
        case 1:
            system("cls");
            startGame();   // Start the game
            break;

        case 2:
            system("cls");
            displayHighScores();  // Show high scores
            cout << "\nPress any key to return to the menu...";
            _getch();             // Wait for input before returning
            break;

        case 3:
            cout << "Exiting game.\n";
            return 0;       // Exit the program

        default:
            cout << "Invalid choice. Please try again.\n";
            Sleep(1500);
            break;
        }
    }

    return 0;
}