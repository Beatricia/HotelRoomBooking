using Hotel.Data;

namespace Hotel.Logic.Interfaces;

public interface IRoomLogic
{
    Task<IEnumerable<Room>> GetAsync();
}