namespace lnn_ui.Services;

public class DataInputService(HttpClient client)
{
    public async Task<string> SendInput(int temperature, int vorticity)
    {
        var values = new Dictionary<string, string>
        {
            { "temperature", temperature.ToString() },
            { "vorticity", vorticity.ToString() }
        };
        var content = new FormUrlEncodedContent(values);
        var response = await client.PostAsync("http://localhost:5000/set", content);
        return response.StatusCode.ToString();
    }
}