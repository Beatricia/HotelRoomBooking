using Hotel.Data;
using Hotel.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DefaultNamespace;

[ApiController]
[Route("[controller]")]
public class RoomController : ControllerBase
{
    private readonly IRoomLogic roomsLogic;

    public RoomController(IRoomLogic roomsLogic)
    {
        this.roomsLogic = roomsLogic;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Room>>> GetAsync()
    {
        try
        {
            var rooms = await roomsLogic.GetAsync();
            return Ok(rooms);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
}