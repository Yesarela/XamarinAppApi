// Services/ApiService.cs
public class ApiService
{
    private readonly HttpClient _client;

    public ApiService()
    {
        _client = new HttpClient
        {
            BaseAddress = new Uri("https://xamarinappproject.windows.net")
        };
    }

    public async Task<List<Item>> GetItemsAsync()
    {
        var response = await _client.GetAsync("api/items");
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<Item>>(content);
    }
}