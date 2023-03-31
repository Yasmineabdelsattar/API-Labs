using lab2_abi.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_abi.BL.Dtos.Tickets;

public class TicketReadDto
{
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public Severity? Severity { get; set; }
}
