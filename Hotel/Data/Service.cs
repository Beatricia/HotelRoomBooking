using Hotel.Data;
using Microsoft.EntityFrameworkCore;

public class Service
{
    private readonly DataBaseContext context;

    public Service(DataBaseContext context)
    {
        this.context = context;
    }

    public async Task<Room> CreateRoomAsync(Room room)
    {
        var newRoom = await context.Rooms.AddAsync(room);
        await context.SaveChangesAsync();
        return newRoom.Entity;
    }

    public async Task<IEnumerable<Room>> GetAllRoomsAsync()
    {
        var rooms = await context.Rooms.ToListAsync();
        return rooms;
    }

    public async Task<Reservation> CreateReservationAsync(Reservation res)
    {
        var newReservation = await context.Reservations.AddAsync(res);
        await context.SaveChangesAsync();
        return newReservation.Entity;
    }
}