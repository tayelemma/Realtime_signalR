using Realtime_signalR.Models;
namespace Realtime_signalR.Data
{
    public class UserRepository : IUserRepository 
    {
        AppDbContext _context;

        public UserRepository(IConfiguration config)
        {
            _context = new AppDbContext(config);
        }
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
        public void AddEntity<T>(T entityToAdd)
        {
            if (entityToAdd != null)
            {
                _context.Add(entityToAdd);
            }
        }
        public void RemoveEntity<T>(T entityToRemove)
        {
            if (entityToRemove != null)
            {
                _context.Remove(entityToRemove);
            }
        }
        public IEnumerable<User> GetUsers()
        {
            return _context.Users.ToList();
        }
        public User GetSingleUser(Guid userId)
        {
            return _context.Users.FirstOrDefault(u => u.userId == userId)!;
        }
    }
}
