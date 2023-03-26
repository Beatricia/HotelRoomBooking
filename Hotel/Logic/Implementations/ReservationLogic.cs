using Hotel.Data;
using Hotel.Logic.Interfaces;

namespace Hotel.Logic;

public class ReservationLogic : IReservationLogic
{
    private readonly DataBaseContext context;

    public ReservationLogic(DataBaseContext context)
    {
        this.context = context;
    }

    public async Task<Reservation> CreateAsync(Reservation reservation)
    {
        if (!IsRoomAlreadyBooked(reservation))
        {
            var newReservation = await context.Reservations.AddAsync(reservation);
            await context.SaveChangesAsync();
            return newReservation.Entity;
        }

        throw new Exception("Room is already booked!");
    }

    private bool IsRoomAlreadyBooked(Reservation reservation)
    {
        var existingReservations = context.Reservations.Where(r =>
            r.ResourceId == reservation.ResourceId && r.DateTo >= reservation.DateFrom);

        foreach (var r in existingReservations) Console.WriteLine(r);

        if (existingReservations.Equals(null) || !existingReservations.Any())
        {
            Console.WriteLine("The room is not reserved");
            return false;
        }

        Console.WriteLine("Room is reserved");
        return true;
    }
}