using System.Text.Json;
using Hotel.Data;
using Hotel.HttpClients.ClientInterfaces;

namespace Hotel.HttpClients;

public class RoomHttpClient : IRoomService
{
    private readonly HttpClient client;

    public RoomHttpClient(HttpClient client)
    {
        this.client = client;
    }

    public async Task<ICollection<Room>> GetAsync()
    {
        var response = await client.GetAsync("/room");
        var content = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode) throw new Exception(content);

        var rooms = JsonSerializer.Deserialize<ICollection<Room>>(content, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        return rooms;
    }
}