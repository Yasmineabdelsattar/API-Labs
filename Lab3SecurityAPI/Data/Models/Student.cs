using Microsoft.AspNetCore.Identity;

namespace Lab3SecurityAPI.Data.Models;

public class Student: IdentityUser
{
    public int PerformanceRate { get; set; }
}
