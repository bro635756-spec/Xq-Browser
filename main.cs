using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program {
    private static readonly string apiKey = "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";

    static async Task Main(string[] args) {
        Console.WriteLine("AI Search Service Started...");
        // AI Sorgu örneği
        await CallAI("Merhaba, bugün hava nasıl?");
    }

    static async Task CallAI(string prompt) {
        using var client = new HttpClient();
        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
        // DeepSeek API Request logic here
    }
}
