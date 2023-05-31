using JWT_API25523.Models;
using JWT_API25523;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWT_API25523.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        /*private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            // Validate the model and create a new user
            // Save the user to the database

            await _userRepository.CreateUser(model.Username, model.Password, model.Role);

            return Ok("User registered successfully.");
        }

        [HttpPost("login")]
        public IActionResult Login(LoginModel model)
        {
            // Validate the model and perform authentication
            // Generate a JWT token for the authenticated user

            var user = _userRepository.AuthenticateUser(model.Username, model.Password);

            if (user == null)
            {
                return Unauthorized("Invalid credentials.");
            }

            var token = GenerateJwtToken(user.Username, user.Role);
            return Ok(new { token });
        }

        [HttpGet("getusersdata")]
        [Authorize(Roles = "admin")]
        public IActionResult GetUsersData()
        {
            // Only accessible by users with the "admin" role

            var users = _userRepository.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("getuserdatabyid/{id}")]
        [Authorize(Roles = "admin")]
        public IActionResult GetUserDataById(int id)
        {
            // Only accessible by users with the "admin" role

            var user = _userRepository.GetUserById(id);
            if (user == null)
            {
                return NotFound("User not found.");
            }

            return Ok(user);
        }

        private string GenerateJwtToken(string username, string role)
        {
            // Generate and return a JWT token with the specified username and role

            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, username),
            new Claim(ClaimTypes.Role, role)
        };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("YourSecretKey"));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: "YourIssuer",
                audience: "YourAudience",
                claims: claims,
                expires: DateTime.UtcNow.AddDays(1),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }*/
    }

}
