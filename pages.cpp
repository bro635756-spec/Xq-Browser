#include <fstream>

void saveIndex(std::string data) {
    std::ofstream file("index.db", std::ios::app);
    file << data << std::endl;
}
