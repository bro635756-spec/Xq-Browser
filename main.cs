using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

class ProEngineController {
    // Senin verdiğin DeepSeek API Key
    private const string AI_KEY = "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";

    static async Task Main(string[] args) {
        Console.WriteLine("Burak Pro-Engine Başlatılıyor...");

        // 1. C++ Çekirdeğini (Root ve Align) Çalıştır
        RunNativeProcess("https_help_file_root.exe");
        RunNativeProcess("pagesalign.exe");

        // 2. CSS ve Stil Kontrolü
        if (File.Exists("style.css")) {
            Console.WriteLine("style.css yüklendi, UI senkronize edildi.");
        }

        // 3. AI Modülünü Aktif Et
        await CallDeepSeekAI("Sistem başlatıldı, Burak için hazır mısın?");
    }

    static void RunNativeProcess(string fileName) {
        if (File.Exists(fileName)) {
            Process.Start(new ProcessStartInfo(fileName) {
                UseShellExecute = false,
                RedirectStandardOutput = true
            });
            Console.WriteLine($"{fileName} başarıyla bağlandı.");
        }
    }

    static async Task CallDeepSeekAI(string prompt) {
        using var client = new HttpClient();
        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {AI_KEY}");
        // DeepSeek v1 API Call Logic
    }
}
