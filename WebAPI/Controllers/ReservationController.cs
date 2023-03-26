using Hotel.Data;
using Hotel.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DefaultNamespace;

[ApiController]
[Route("[controller]")]
public class ReservationController : ControllerBase
{
    private readonly IReservationLogic reservationLogic;

    public ReservationController(IReservationLogic reservationLogic)
    {
        this.reservationLogic = reservationLogic;
    }

    [HttpPost]
    public async Task<ActionResult<Reservation>> CreateAsync([FromBody] Reservation reservation)
    {
        try
        {
            var res = await reservationLogic.CreateAsync(reservation);
            return res;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
}