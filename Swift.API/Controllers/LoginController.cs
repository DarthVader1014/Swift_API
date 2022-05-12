using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Swift.API.Models;
using Swift_API;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Swift.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class LoginController : ControllerBase
  {
    private readonly DataContext _dataContext;
    private readonly IConfiguration _configuration;
    //constructor
    public LoginController(DataContext dataContext, IConfiguration configuration)
    {
      _dataContext = dataContext;
      _configuration = configuration;
    }


    //Retrieve category info
    [HttpPost]
    public async Task<ActionResult<List<String>>> Post(Login login)
    {
      var customer = _dataContext.Customers.Where(x => x.Username == login.Username && x.Password == login.Password).FirstOrDefault();
      if (customer == null) return BadRequest("Not a valid user");

      return Ok(GenerateJwtToken(customer));
    }
    private string GenerateJwtToken(Customer customer)
    {
      // generate token that is valid for 7 days
      var tokenHandler = new JwtSecurityTokenHandler();
      var secret = Encoding.ASCII.GetBytes(_configuration["AppSettings:Secret"]);
      var tokenDescriptor = new SecurityTokenDescriptor
      {
        Subject = new ClaimsIdentity(new[] { new Claim("id", customer.Id.ToString()) }),
        Issuer = _configuration["Appsettings.Issuer"],
        Audience = _configuration["Appsettings.Audience"],
        Expires = DateTime.UtcNow.AddHours(1),
        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secret), SecurityAlgorithms.HmacSha256Signature)
      };
      var token = tokenHandler.CreateToken(tokenDescriptor);
      return tokenHandler.WriteToken(token);
    }

  }
}
