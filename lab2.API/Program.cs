using lab2_abi.BL.Managers;
using lab2_abi.DAL.Context;
using lab2_abi.DAL.Repos.DepartmentsRepo;
using lab2_abi.DAL.Repos.TicketsRepo;
using lab2_abi.DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


#region Database

var connectionString = builder.Configuration.GetConnectionString("TicketsDbAPI");
builder.Services.AddDbContext<TicketContext>(options =>
    options.UseSqlServer(connectionString));

#endregion

#region Repos

builder.Services.AddScoped<ITicketsRepo, TicketsRepo>();
builder.Services.AddScoped<IDepartmentsRepo, DepartmentsRepo>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

#endregion

#region Managers

builder.Services.AddScoped<ITicketsManager, TicketsManager>();
builder.Services.AddScoped<IDepartmentsManager, DepartmentsManager>();

#endregion




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
