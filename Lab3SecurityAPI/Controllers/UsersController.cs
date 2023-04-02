using Lab3SecurityAPI.Data.Models;
using Lab3SecurityAPI.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Lab3SecurityAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly UserManager<Student> _userManager;

    public UsersController(IConfiguration configuration, UserManager<Student> userManager)
    {
        _configuration = configuration;
        _userManager = userManager;
    }

    #region Login

    [HttpPost]
    [Route("Login")]
    public async Task<ActionResult<TokenDto>> Login(LoginDto credentials)
    {
        Student? student = await _userManager.FindByNameAsync(credentials.UserName);
        if (student is null)
        {
            return BadRequest(new { Message = "User Not Found" });
        }

        var isPasswordCorrect = await _userManager.CheckPasswordAsync(student, credentials.Password);
        if (!isPasswordCorrect)
        {
            return Unauthorized();
        }

        var claims = await _userManager.GetClaimsAsync(student);
        DateTime exp = DateTime.Now.AddMinutes(20);

        var tokenString = GenerateToken(claims, exp);
        return new TokenDto(tokenString);
    }

    #endregion

    #region Register for user

    [HttpPost]
    [Route("RegisterUser")]
    public async Task<ActionResult> RegisterU(RegisterDto registerDto)
    {
        var student = new Student
        {
            UserName = registerDto.UserName,
            Email = registerDto.Email,
            PerformanceRate = 20
        };

        var studentCreationResult = await _userManager.CreateAsync(student, registerDto.Password);
        if (!studentCreationResult.Succeeded)
        {
            return BadRequest(studentCreationResult.Errors);
        }

        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, student.Id),
            new Claim(ClaimTypes.Role, "user"),
        };

        await _userManager.AddClaimsAsync(student, claims);

        return NoContent();
    }

    #endregion


    #region Register for admin

    [HttpPost]
    [Route("RegisterAdmin")]
    public async Task<ActionResult> RegisterA(AdminRegDto registerDto)
    {
        var student = new Student
        {
            UserName = registerDto.UserName,
            Email = registerDto.Email,
            PerformanceRate = 20
        };

        var studentCreationResult = await _userManager.CreateAsync(student, registerDto.Password);
        if (!studentCreationResult.Succeeded)
        {
            return BadRequest(studentCreationResult.Errors);
        }

        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, student.Id),
            new Claim(ClaimTypes.Role, "admin"),
        };

        await _userManager.AddClaimsAsync(student, claims);

        return NoContent();
    }

    #endregion



    #region Helpers

    private string GenerateToken(IList<Claim> claimsList, DateTime exp)
    {
        var secretKeyString = _configuration.GetValue<string>("SecretKey") ?? string.Empty;
        var secretKeyInBytes = Encoding.ASCII.GetBytes(secretKeyString);
        var securityKey = new SymmetricSecurityKey(secretKeyInBytes);

        var signingCredentials = new SigningCredentials(securityKey,
            SecurityAlgorithms.HmacSha256Signature);


        var jwt = new JwtSecurityToken(
            claims: claimsList,
            expires: exp,
            signingCredentials: signingCredentials);

        var tokenHandler = new JwtSecurityTokenHandler();
        var tokenString = tokenHandler.WriteToken(jwt);

        return tokenString;
    }

    #endregion
}
