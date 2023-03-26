using System.Text.Json;
using Hotel.Data;
using Hotel.HttpClients.ClientInterfaces;

namespace Hotel.HttpClients;

public class ReservationHttpClient : IReservationService
{
    private readonly HttpClient client;

    public ReservationHttpClient(HttpClient client)
    {
        this.client = client;
    }

    public async Task<Reservation> ReserveAsync(Reservation reservation)
    {
        var response = await client.PostAsJsonAsync("/reservation", reservation);

        var result = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode) throw new Exception(result);

        var res = JsonSerializer.Deserialize<Reservation>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        return res;
    }
}