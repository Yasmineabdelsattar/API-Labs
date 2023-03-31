using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_abi.DAL.Models;

public class Department
{
    public int Id { get; set; } 
    public string Name { get; set; } = String.Empty;

    public ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();
}
