using Hotel.Data;

namespace Hotel.HttpClients.ClientInterfaces;

public interface IReservationService
{
    Task<Reservation> ReserveAsync(Reservation res);
}