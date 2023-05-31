using bigbangtestjwt.Models;
using Microsoft.EntityFrameworkCore;

namespace bigbangtestjwt.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TestDbContext _dbContext;

        public UserRepository(TestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> GetUserByUsername(string username)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<User> GetUserById(int userId)
        {
            return await _dbContext.Users.FindAsync(userId);
        }

        public async Task<User> CreateUser(User user)
        {
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
            return user;
        }
        public User AuthenticateUser(string username, string password)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Username == username);

            if (user != null && (password.Equals( user.Password)))
            {
                return user;
            }

            return null;
        }

        
    }
}
