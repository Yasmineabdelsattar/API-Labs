using Lab3SecurityAPI.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab3SecurityAPI.Data.Context;

public class StudentContext: IdentityDbContext<Student>
{
	public StudentContext(DbContextOptions<StudentContext> options):base(options){}


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Student>().ToTable("Students");
    }
}
