#include <iostream>
#include <vector>
#include <cstdlib>
#ifdef _WIN32
#include <windows.h>
#else
#include <unistd.h>
#endif

class Game {
public:
    void run();
private:
    bool running{false};
    static const int width{20};
    static const int height{10};
    int playerX{width / 2};
    int playerY{height / 2};

    void processInput(char input);
    void update();
    void render() const;
    void clearScreen() const;
};

void Game::clearScreen() const {
#ifdef _WIN32
    system("cls");
#else
    system("clear");
#endif
}

void Game::render() const {
    clearScreen();
    for (int y = 0; y < height; ++y) {
        for (int x = 0; x < width; ++x) {
            if (x == playerX && y == playerY) {
                std::cout << '@';
            } else {
                std::cout << '.';
            }
        }
        std::cout << '\n';
    }
    std::cout << "Use WASD to move, q to quit" << std::endl;
}

void Game::processInput(char input) {
    switch (input) {
        case 'w': if (playerY > 0) --playerY; break;
        case 's': if (playerY < height - 1) ++playerY; break;
        case 'a': if (playerX > 0) --playerX; break;
        case 'd': if (playerX < width - 1) ++playerX; break;
        case 'q': running = false; break;
        default: break;
    }
}

void Game::update() {
    // For future game logic
}

void Game::run() {
    running = true;
    while (running) {
        render();
        char input;
        std::cin >> input;
        processInput(input);
        update();
    }
}

int main() {
    Game game;
    game.run();
    return 0;
}
