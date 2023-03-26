using Hotel.Data;

namespace Hotel.Logic.Interfaces;

public interface IReservationLogic
{
    Task<Reservation> CreateAsync(Reservation reservation);
}