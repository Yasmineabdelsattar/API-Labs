using lab2_abi.BL.Dtos.Departments;
using lab2_abi.BL.Dtos.Tickets;
using lab2_abi.DAL.Models;
using lab2_abi.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace lab2_abi.BL.Managers;

public class DepartmentsManager : IDepartmentsManager
{
    private readonly IUnitOfWork _unitOfWork;

    public DepartmentsManager(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }


    public List<DepartmentReadDto> GetAll()
    {
        List<Department> departmentsFromDb = _unitOfWork.DepartmentsRepo.GetAll();

        return departmentsFromDb
            .Select(d => new DepartmentReadDto
            {
                Id = d.Id,
                Name = d.Name,
            }).ToList();
    }

    public int Add(DepartmentAddDto departmentDto)
    {
        var department = new Department
        {
            Name = departmentDto.Name,
        };

        _unitOfWork.DepartmentsRepo.Add(department);  
        _unitOfWork.DepartmentsRepo.SaveChanges(); 

        return department.Id;
    }

    public DepartmentWithTicketsReadDto? GetByIdWithTickets(int id)
    {
        Department? department = _unitOfWork.DepartmentsRepo.GetByIdWithTickets(id);
        if (department is null)
        {
            return null;
        }

        return new DepartmentWithTicketsReadDto
        {
            Id = id,
            Name = department.Name,
            Tickets = department.Tickets.Select(p => new TicketChildReadDto
            {
                Id = p.Id,
                Description = p.Description,
                DevelopersCount = p.Developers.Count
            }).ToList()
        };
    }








    //public int Add(DepartmentAddDto department)
    //{
    //    throw new NotImplementedException();
    //}

    //public List<DepartmentReadDto> GetAll()
    //{
    //    throw new NotImplementedException();
    //}

    //public DepartmentWithTicketsReadDto? GetByIdWithTickets(int id)
    //{
    //    throw new NotImplementedException();
    //}
}
