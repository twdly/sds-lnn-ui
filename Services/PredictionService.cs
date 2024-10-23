using System.Text.Json;
using lnn_ui.Models;

namespace lnn_ui.Services;

public class PredictionService(HttpClient client, IConfiguration config)
{
    public async Task<LnnOutput> GetPrediction()
    {
        var apiUrl = config.GetConnectionString("ApiUrl");
        var response = client.GetAsync($"{apiUrl}/get");
        var result = await response;
        return JsonSerializer.Deserialize<LnnOutput>(await result.Content.ReadAsStringAsync()) ?? new LnnOutput();
    }
}