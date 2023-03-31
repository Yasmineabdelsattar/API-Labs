using lab2_abi.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace lab2_abi.DAL.Context;

public class TicketContext: DbContext
{
    public DbSet<Ticket> Tickets => Set<Ticket>();
    public DbSet<Department> Departments => Set<Department>();
    public DbSet<Developer> Developers => Set<Developer>();

    public TicketContext(DbContextOptions<TicketContext> options) :base(options){}


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Seeding 
        var departments = JsonSerializer.Deserialize<List<Department>>("""[{"Id":1,"Name":"Diabetes"},{"Id":2,"Name":"Hypertension"},{"Id":3,"Name":"Asthma"},{"Id":4,"Name":"Depression"},{"Id":5,"Name":"Arthritis"},{"Id":6,"Name":"Allergy"},{"Id":7,"Name":"Flu"}]""") ?? new();
        var tickets = JsonSerializer.Deserialize<List<Ticket>>("""[{"Id":1,"Description":"Jessie","Severity":0,"EstimationCost":27064,"DepartmentId":1},{"Id":2,"Description":"Jessie","Severity":0,"EstimationCost":27064,"DepartmentId":2},{"Id":3,"Description":"Jessie","Severity":1,"EstimationCost":27064,"DepartmentId":3},{"Id":4,"Description":"Jessie","Severity":1,"EstimationCost":27064,"DepartmentId":5},{"Id":5,"Description":"Jessie","Severity":0,"EstimationCost":27064,"DepartmentId":6},{"Id":6,"Description":"Jessie","Severity":0,"EstimationCost":27064,"DepartmentId":5},{"Id":7,"Description":"Jessie","Severity":0,"EstimationCost":27064,"DepartmentId":2},{"Id":10,"Description":"Jessie","Severity":0,"EstimationCost":27064,"DepartmentId":1}]""") ?? new();
        var developers = JsonSerializer.Deserialize<List<Developer>>("""[{"Id":1,"Name":"Dana"},{"Id":2,"Name":"Isaac"},{"Id":3,"Name":"Damon"},{"Id":4,"Name":"Miriam"},{"Id":5,"Name":"Terence"},{"Id":6,"Name":"Roosevelt"},{"Id":7,"Name":"Eduardo"},{"Id":8,"Name":"Wilbert"},{"Id":9,"Name":"Tasha"}]""") ?? new();




        #region seeding
        //var departments = JsonSerializer.Deserialize<List<Department>>("""[{"Id":1,"Name":"Automotive \u0026 Baby"},{"Id":2,"Name":"Beauty \u0026 Health"},{"Id":3,"Name":"Electronics"}]""") ?? new();
        //var tickets = JsonSerializer.Deserialize<List<Ticket>>("""[{"Id":20,"Description":"Harum hic impedit dolore voluptate placeat.","Severity":1,"EstimationCost":200,"DepartmentId":1},{"Id":12,"Description":"Rerum totam est quo possimus sunt sunt ad.","Severity":0,"EstimationCost":400,"DepartmentId":2},{"Id":2,"Description":"Id cumque explicabo beatae.","Severity":1,"EstimationCost":200,"DepartmentId":3},{"Id":3,"Description":"Consectetur beatae dolorem voluptates occaecati.","Severity":0,"EstimationCost":300,"DepartmentId":3},{"Id":4,"Description":"Nulla est doloribus ut non aspernatur vero dolores.","Severity":2,"EstimationCost":200,"DepartmentId":3},{"Id":5,"Description":"Et praesentium est ipsum eligendi rerum itaque voluptate quia.","Severity":1,"EstimationCost":200,"DepartmentId":2},{"Id":6,"Description":"Optio non debitis ut molestiae dolorem ad.","Severity":2,"EstimationCost":100,"DepartmentId":3},{"Id":7,"Description":"Dolor quae iure quas error est.","Severity":2,"EstimationCost":200,"DepartmentId":1},{"Id":8,"Description":"Iste molestiae aut inventore necessitatibus necessitatibus perspiciatis sit.","Severity":2,"EstimationCost":200,"DepartmentId":2},{"Id":9,"Description":"Voluptas expedita placeat ad sint consequuntur.","Severity":0,"EstimationCost":200,"DepartmentId":2},{"Id":10,"Description":"Voluptates qui sed aliquid laudantium in.","Severity":0,"EstimationCost":200,"DepartmentId":1},{"Id":11,"Description":"Placeat non repellat qui libero.","Severity":1,"EstimationCost":200,"DepartmentId":3},{"Id":12,"Description":"Debitis vero laborum asperiores deserunt nihil tempora quia.","Severity":2,"EstimationCost":200,"DepartmentId":3},{"Id":13,"Description":"Voluptatibus a et natus ipsa at quis rem dolores.","Severity":0,"EstimationCost":500,"DepartmentId":1},{"Id":14,"Description":"Dolorem qui animi sint ad facere ut ullam voluptatem repellendus.","Severity":1,"EstimationCost":200,"DepartmentId":1},{"Id":15,"Description":"Sint suscipit delectus accusamus distinctio earum aliquam.","Severity":2,"EstimationCost":200,"DepartmentId":2},{"Id":16,"Description":"Et vel tempora.","Severity":0,"EstimationCost":200,"DepartmentId":2},{"Id":17,"Description":"Aut atque officiis numquam mollitia voluptas dolore.","Severity":1,"EstimationCost":200,"DepartmentId":2},{"Id":18,"Description":"Ipsum mollitia sit officiis sapiente natus.","Severity":2,"EstimationCost":300,"DepartmentId":3},{"Id":19,"Description":"Inventore aut reprehenderit vitae ratione dolorum harum.","Severity":2,"EstimationCost":400,"DepartmentId":1}]""") ?? new();
        //var developers = JsonSerializer.Deserialize<List<Developer>>("""[{"Id":1,"Name":"Freddie"},{"Id":2, "Name":"Sophia"},{"Id":3,"Name":"Angela"},{ "Id":4,"Name":"Jamie"},{ "Id":5,"Name":"Geoffrey"}]""") ?? new();
        #endregion




        modelBuilder.Entity<Department>().HasData(departments);
        modelBuilder.Entity<Ticket>().HasData(tickets);
        modelBuilder.Entity<Developer>().HasData(developers);
       
        #endregion
    }
}
