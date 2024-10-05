using System.Text.Json;
using lnn_ui.Models;

namespace lnn_ui.Services;

public class HistoryService(HttpClient client)
{
    public async Task<List<LnnOutput>> GetHistory(int count)
    {
        var response = client.GetAsync($"http://localhost:5000/get-history?count={count}");
        var result = await response;
        return JsonSerializer.Deserialize<List<LnnOutput>>(await result.Content.ReadAsStringAsync()) ?? [];
    }
}