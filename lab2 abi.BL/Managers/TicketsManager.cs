using lab2_abi.BL.Dtos.Tickets;
using lab2_abi.DAL.Models;
using lab2_abi.DAL.Repos.TicketsRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace lab2_abi.BL.Managers;

public class TicketsManager: ITicketsManager
{
    private readonly ITicketsRepo _ticketsRepo;

    public TicketsManager(ITicketsRepo ticketsRepo)
    {
        _ticketsRepo = ticketsRepo;
    }

    public List<TicketReadDto> GetAll()
    {
        List<Ticket> doctorsFromDb = _ticketsRepo.GetAll();

        return doctorsFromDb
            .Select(d => new TicketReadDto
            {
                Id = d.Id,
                Description = d.Description,
                Severity = d.Severity,
            }).ToList();
    }

    public void Add(TicketAddDto ticketDto)
    {
        var ticket = new Ticket
        {
            DepartmentId = ticketDto.DepartmentId,
            Description = ticketDto.Description,
            EstimationCost = ticketDto.EstimationCost,
           
        };

        _ticketsRepo.Add(ticket);
        _ticketsRepo.SaveChanges();
    }
}
