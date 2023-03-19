using lab1_API.Filters;
using lab1_API.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Reflection;

namespace lab1_API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarsController : ControllerBase
{
    private readonly ILogger<CarsController> _logger;
    public CarsController(ILogger<CarsController> logger)
    {
        _logger = logger;
    }

    // GET: api/Cars
    [HttpGet]
    public ActionResult<List<Car>> GetAll()
    {
        _logger.LogInformation($"Incoming request: {Request.Method} {Request.Path}");
        return Car.GetCars(); //Status Code 200
    }

    // GET: api/Cars/5
    [HttpGet]
    [Route("{id:int}")]
    public ActionResult<Car> GetById(int id)
    {
        var car = Car.GetCars().FirstOrDefault(m => m.Id == id);
        if (car is null)
        {
            return NotFound(new GeneralResponse("Resource is missing"));
        }
        return car;
    }

    // POST: api/Cars
    [HttpPost]
    [Route("v1")]
    public ActionResult Add(Car car)
    {
        car.Id = new Random().Next(1, 1000); //Assign Random Id for the car
        car.Type = "Gas";
        Car.GetCars().Add(car);
        return CreatedAtAction(
            actionName: nameof(GetById),
            routeValues: new { id = car.Id },
            value: new GeneralResponse("Resource is added"));
    }

    //POST: v2
    [HttpPost]
    [Route("v2")]
    [ServiceFilter(typeof(ValidateCarTypeAttribute))]
    public ActionResult AddV2(Car car)
    {
        car.Id = new Random().Next(1, 1000); //Assign Random Id for the car
        Car.GetCars().Add(car);
        return CreatedAtAction(
            actionName: nameof(GetById),
            routeValues: new { id = car.Id },
            value: new GeneralResponse("Resource is added"));
    }


    // PUT: api/Cars/6
    [HttpPut]
    [Route("{id:min(1)}")]
    public ActionResult Edit(Car car, int id)
    {
        if (id != car.Id)
        {
            return BadRequest(new GeneralResponse("Ids don't match"));
        }

        var carToEedit = Car.GetCars()
            .FirstOrDefault(m => m.Id == id);

        if (carToEedit is null)
        {
            return NotFound(new GeneralResponse("Resource is missing"));
        }

        carToEedit.Name = car.Name;
        carToEedit.Model = car.Model;
        carToEedit.ProductionDate = car.ProductionDate;

        return NoContent();
    }

    // DELETE: api/Cars/6
    [HttpDelete]
    [Route("{id}")]
    public ActionResult Delete(int id)
    {
        var carToDelete = Car.GetCars()
            .FirstOrDefault(m => m.Id == id);

        if (carToDelete is null)
        {
            return NotFound(new GeneralResponse("Resource is missing"));
        }

        Car.GetCars().Remove(carToDelete);

        return NoContent();
    }

    //////////////////////////////////////////////////////////////////////////////////////
    
}
