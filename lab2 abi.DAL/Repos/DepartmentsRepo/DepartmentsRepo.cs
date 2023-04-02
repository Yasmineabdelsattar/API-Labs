using lab2_abi.DAL.Context;
using lab2_abi.DAL.Models;
using lab2_abi.DAL.Repos.GenericRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace lab2_abi.DAL.Repos.DepartmentsRepo;

public class DepartmentsRepo: GenericRepo<Department>, IDepartmentsRepo
{
    private readonly TicketContext _context;

    public DepartmentsRepo(TicketContext context) : base(context)
    {
        _context = context;
    }

    public Department? GetByIdWithTickets(int id)
    {
        return _context.Departments
            .Include(d => d.Tickets)
                .ThenInclude(p => p.Developers)
            .FirstOrDefault(d => d.Id == id);
    }

    public List<Department> GetDepartmentsByName(string name)
    {
        return _context.Departments
            .Where(d => d.Name == name)
            .ToList();
    }
}
