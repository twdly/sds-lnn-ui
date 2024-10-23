using System.Text.Json;
using lnn_ui.Models;

namespace lnn_ui.Services;

public class HistoryService(HttpClient client, IConfiguration config)
{
    public async Task<List<LnnOutput>> GetHistory(int count)
    {
        var apiUrl = config.GetConnectionString("ApiUrl");
        var response = client.GetAsync($"{apiUrl}/get-history?count={count}");
        var result = await response;
        return JsonSerializer.Deserialize<List<LnnOutput>>(await result.Content.ReadAsStringAsync()) ?? [];
    }
}