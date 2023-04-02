using lab2_abi.BL.Dtos.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_abi.BL.Managers;

public interface IDepartmentsManager
{
    List<DepartmentReadDto> GetAll();
    int Add(DepartmentAddDto department);
    DepartmentWithTicketsReadDto? GetByIdWithTickets(int id);
}
