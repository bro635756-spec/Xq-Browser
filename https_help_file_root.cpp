#include <iostream>
#include <fstream>
#include <string>

// C# (Main.cs) tarafından çağrılan fonksiyonlar
extern "C" {
    void ProcessFileRequest(const char* path) {
        std::ifstream file(path);
        if (file.is_open()) {
            std::cout << "[ROOT] Dosya erişimi onaylandı: " << path << std::endl;
        } else {
            std::cout << "[ERROR] file:// erişimi reddedildi." << std::endl;
        }
    }
}

int main() {
    std::cout << "HTTPS & File Root Module Active." << std::endl;
    return 0;
}
