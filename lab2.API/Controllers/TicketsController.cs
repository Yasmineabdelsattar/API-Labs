using lab2_abi.BL.Dtos.Tickets;
using lab2_abi.BL.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lab2.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TicketsController : ControllerBase
{
    private readonly ITicketsManager _ticketsManager;

    public TicketsController(ITicketsManager ticketsManager)
    {
        _ticketsManager = ticketsManager;
    }

    [HttpGet]
    public ActionResult<List<TicketReadDto>> GetAll()
    {
        return _ticketsManager.GetAll();
    }

    [HttpPost]
    public ActionResult Add(TicketAddDto ticketDto)
    {
        _ticketsManager.Add(ticketDto);
        return NoContent();
    }
}
