using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_abi.BL.Dtos.Tickets;

public class TicketChildReadDto
{
    public int Id { get; init; }
    public string Description { get; init; } = string.Empty;
    public int DevelopersCount { get; set; }
}
