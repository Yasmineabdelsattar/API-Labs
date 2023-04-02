using lab2_abi.BL.Dtos.Departments;
using lab2_abi.BL.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lab2.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DepartmentsController : ControllerBase
{
    private readonly IDepartmentsManager _deptsManager;

    public DepartmentsController(IDepartmentsManager deptsManager)
    {
        _deptsManager = deptsManager;
    }

    [HttpGet]
    public ActionResult<List<DepartmentReadDto>> GetAll()
    {
        return _deptsManager.GetAll();
    }

    [HttpGet]
    [Route("{id}")]
    public ActionResult<DepartmentWithTicketsReadDto> GetByIdWithPatients(int id)
    {
        var deptDto = _deptsManager.GetByIdWithTickets(id);
        if (deptDto is null)
        {
            return NotFound();
        }
        return deptDto;
    }

    [HttpPost]
    public ActionResult Add(DepartmentAddDto deptDto)
    {
        _deptsManager.Add(deptDto);
        return NoContent();
    }
}
