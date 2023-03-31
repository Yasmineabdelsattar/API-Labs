using lab2_abi.BL.Dtos.Tickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_abi.BL.Managers;

public interface ITicketsManager
{
    List<TicketReadDto> GetAll();
    void Add(TicketAddDto ticket);
}
