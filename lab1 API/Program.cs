using lab1_API.Filters;
using lab1_API.Models;
using Microsoft.AspNetCore.HttpLogging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ValidateCarTypeAttribute>();




var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Use(async (context, next) =>
{
    RequestCounterMiddleware.Counter++;

    await next(context);
});

app.Use(async (context, next) =>
{
    // Request Logic
    if (!context.Request.IsHttps)
    {
        await context.Response.WriteAsJsonAsync(new GeneralResponse("Use HTTPS"));
        return;
    }
    Console.WriteLine("Hello Request");
    await next(context);
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
