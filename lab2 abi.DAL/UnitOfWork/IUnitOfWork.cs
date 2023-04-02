using lab2_abi.DAL.Repos.DepartmentsRepo;
using lab2_abi.DAL.Repos.TicketsRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_abi.DAL.UnitOfWork;

public interface IUnitOfWork
{
    public ITicketsRepo TicketsRepo { get; }
    public IDepartmentsRepo DepartmentsRepo { get; }
}
