using graduation.Interface;
using graduation.Model;
using Microsoft.EntityFrameworkCore;

namespace graduation.Repository
{
    public class UserRepo : IUser
    {
        private readonly AppDbContext _context;

        public UserRepo(AppDbContext context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            try
            {
               _context.Users.Add(user);
               _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public bool CheckUser(int id)
        {
            throw new NotImplementedException();
        }

        public User DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            try
            {
                return _context.Users.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
