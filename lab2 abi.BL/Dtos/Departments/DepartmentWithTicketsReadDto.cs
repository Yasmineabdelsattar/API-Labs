using lab2_abi.BL.Dtos.Tickets;
using lab2_abi.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_abi.BL.Dtos.Departments;

public record DepartmentWithTicketsReadDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public required List<TicketChildReadDto> Tickets { get; init; } = new();
}
