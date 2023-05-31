using bigbangtestjwt.Models;

namespace bigbangtestjwt.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUserByUsername(string username);
        Task<List<User>> GetAllUsers();
        Task<User> GetUserById(int userId);
        Task<User> CreateUser(User user);
        User AuthenticateUser(string username, string password);
    }
}
