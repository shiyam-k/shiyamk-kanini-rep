using bigbangtestjwt.Models;
using bigbangtestjwt.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace bigbangtestjwt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration Configuration;

        public UserController(IUserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            Configuration = configuration;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(User model)
        {
            // Validate the model and create a new user
            // Save the user to the database

            await _userRepository.CreateUser(model);

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
        [Authorize(Roles = "user")]
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
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.Role, role)
            };

            string secretKey = Configuration["JWT:SecretKey"]; // Retrieve the secret key from configuration

            var symmetricKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            var credentials = new SigningCredentials(symmetricKey, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: Configuration["JWT:Issuer"],
                audience: Configuration["JWT:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddDays(1),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }

}
