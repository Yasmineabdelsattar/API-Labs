using Lab3SecurityAPI.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Lab3SecurityAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    private readonly UserManager<Student> _userManager;

    public ValuesController(UserManager<Student> userManager)
    {
        _userManager = userManager;
    }

    [HttpGet]
    [Authorize]
    [Authorize(Policy = "AllowBoth")]
    public async Task<ActionResult> GetUserInfo()
    {
        Student? user = await _userManager.GetUserAsync(User);
        return Ok(new string[] { user!.UserName!, user.Email! ,user!.PerformanceRate.ToString() });
    }
    
    [HttpGet]
    [Route("admin-only")]
    [Authorize(Policy = "AllowAdminsOnly")]
    public async Task<ActionResult> GetInfoForAdmins()
    {
        Student? user = await _userManager.GetUserAsync(User);
        return Ok(new string[] { user!.UserName!,user!.PerformanceRate.ToString() });
    }

    [HttpGet]
    [Route("user-only")]
    [Authorize(Policy = "AllowUsersOnly")]
    public async Task<ActionResult> GetNamesForUsers()
    {
        Student? user = await _userManager.GetUserAsync(User);
        return Ok(new string[] { user!.UserName!, user!.PerformanceRate.ToString() });
    }

}
