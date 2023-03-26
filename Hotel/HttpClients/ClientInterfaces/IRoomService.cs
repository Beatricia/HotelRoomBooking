using Hotel.Data;

namespace Hotel.HttpClients.ClientInterfaces;

public interface IRoomService
{
    Task<ICollection<Room>> GetAsync();
}