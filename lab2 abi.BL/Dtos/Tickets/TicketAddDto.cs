using lab2_abi.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_abi.BL.Dtos.Tickets;

public class TicketAddDto
{
    public string Description { get; set; } = string.Empty;
    public decimal EstimationCost { get; set; }
    public int DepartmentId { get; set; }


}
