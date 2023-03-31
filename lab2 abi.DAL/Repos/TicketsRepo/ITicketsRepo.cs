using lab2_abi.DAL.Models;
using lab2_abi.DAL.Repos.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_abi.DAL.Repos.TicketsRepo;

public interface ITicketsRepo: IGenericRepo<Ticket>
{
    List<Ticket> GetTicketsByDepartmentId(int deptId);
}

