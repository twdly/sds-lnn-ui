using System.Globalization;

namespace lnn_ui.Services;

public class DataInputService(HttpClient client, IConfiguration config)
{
    public async Task<string> SendInput(float month, float day, float hour, float lat, float lon, float wind, float pres, float gust, float eye, float speed)
    {
        var values = new Dictionary<string, string>
        {
            { "month", month.ToString(CultureInfo.CurrentCulture) },
            { "day", day.ToString(CultureInfo.CurrentCulture) },
            { "hour", hour.ToString(CultureInfo.CurrentCulture) },
            { "lat", lat.ToString(CultureInfo.CurrentCulture) },
            { "lon", lon.ToString(CultureInfo.CurrentCulture) },
            { "wind", wind.ToString(CultureInfo.CurrentCulture) },
            { "pres", pres.ToString(CultureInfo.CurrentCulture) },
            { "gust", gust.ToString(CultureInfo.CurrentCulture) },
            { "eye", eye.ToString(CultureInfo.CurrentCulture) },
            { "speed", speed.ToString(CultureInfo.CurrentCulture) }
        };
        var content = new FormUrlEncodedContent(values);
        var apiUrl = config.GetConnectionString("ApiUrl");
        var response = await client.PostAsync($"{apiUrl}/set", content);
        return response.StatusCode.ToString();
    }
}