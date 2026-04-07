#include <iostream>
#include <algorithm>
#include <vector>

struct PageData {
    int id;
    std::string url;
    float rank;
};

// Sayfaları Rank değerine göre hizalayan ve optimize eden algoritma
class PageAligner {
public:
    void alignResults(std::vector<PageData>& pages) {
        std::cout << "[ALIGN] Sayfalar bellek üzerinde hizalanıyor (Byte Alignment)..." << std::endl;
        
        // Veriyi rank (puan) sırasına göre hizala (Descending)
        std::sort(pages.begin(), pages.end(), [](const PageData& a, const PageData& b) {
            return a.rank > b.rank;
        });

        for (const auto& page : pages) {
            std::printf("[PTR: %p] ID: %d | Rank: %.2f | URL: %s\n", (void*)&page, page.id, page.rank, page.url.c_str());
        }
    }
};

int main() {
    PageAligner aligner;
    std::vector<PageData> rawResults = {
        {1, "https://google.com", 0.85f},
        {2, "xq://burak-data", 0.99f},
        {3, "help://burakhelpssq.xqom", 1.00f}
    };

    aligner.alignResults(rawResults);
    return 0;
}
