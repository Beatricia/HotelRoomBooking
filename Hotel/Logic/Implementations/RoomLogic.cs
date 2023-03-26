using Hotel.Data;
using Hotel.Logic.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Logic;

public class RoomsLogic : IRoomLogic
{
    private readonly DataBaseContext context;

    public RoomsLogic(DataBaseContext context)
    {
        this.context = context;
    }

    public async Task<IEnumerable<Room>> GetAsync()
    {
        var rooms = await context.Rooms.ToListAsync();
        return rooms;
    }
}