#include <iostream>
#include <string>
#include <vector>

// Makine seviyesinde hızlı indeksleme simülasyonu
int main() {
    std::string query;
    std::cout << "Engine Core Initialized..." << std::endl;
    while (std::getline(std::cin, query)) {
        if (query == "exit") break;
        std::cout << "Indexing results for: " << query << std::endl;
        // Search logic here
    }
    return 0;
}
