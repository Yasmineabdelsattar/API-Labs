using lab2_abi.DAL.Context;
using lab2_abi.DAL.Models;
using lab2_abi.DAL.Repos.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_abi.DAL.Repos.TicketsRepo;

public class TicketsRepo: GenericRepo<Ticket>, ITicketsRepo
{
    private readonly TicketContext _context;

    public TicketsRepo(TicketContext context) : base(context)
    {
        _context = context;
    }

    public List<Ticket> GetTicketsByDepartmentId(int deptId)
    {
        return _context.Tickets
            .Where(p => p.DepartmentId == deptId)
            .ToList();
    }
}
