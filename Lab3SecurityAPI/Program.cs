using Lab3SecurityAPI.Data.Context;
using Lab3SecurityAPI.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

var builder = WebApplication.CreateBuilder(args);


#region Context

var connectionString = builder.Configuration.GetConnectionString("EmployeesDb");
builder.Services.AddDbContext<StudentContext>(options =>
    options.UseSqlServer(connectionString));

#endregion

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


#region Identity Manager

builder.Services.AddIdentity<Student, IdentityRole>(options =>
{
    options.Password.RequiredUniqueChars = 3;
    //options.Password.RequireNonAlphanumeric = false;
    //options.Password.RequireUppercase = false;
    //options.Password.RequireLowercase = false;
    options.Password.RequiredLength = 8;
    options.User.RequireUniqueEmail = true;
})
    .AddEntityFrameworkStores<StudentContext>();

#endregion

#region Authentication

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = "Stu";
    options.DefaultChallengeScheme = "Stu";
})
    .AddJwtBearer("Stu", options =>
    {
        var secretKeyString = builder.Configuration.GetValue<string>("SecretKey") ?? "";
        var secretKyInBytes = Encoding.ASCII.GetBytes(secretKeyString);
        var securityKey = new SymmetricSecurityKey(secretKyInBytes);

        options.TokenValidationParameters = new TokenValidationParameters()
        {
            IssuerSigningKey = securityKey,
            ValidateIssuer = false,
            ValidateAudience = false,
        };
    });

#endregion

#region Authorization

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AllowAdminsOnly",
        builder => builder.RequireClaim(ClaimTypes.Role, "admin"));

    options.AddPolicy("AllowUsersOnly",
        builder => builder.RequireClaim(ClaimTypes.Role, "user"));

    options.AddPolicy("AllowBoth",
        builder => builder.RequireClaim(ClaimTypes.Role, "user", "admin"));
});

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
