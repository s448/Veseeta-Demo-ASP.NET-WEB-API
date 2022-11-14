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
            User usr = new User();
            usr = (from u in _context.Users where u.UserEmail == user.UserEmail select u).FirstOrDefault();
            if(usr != null)
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
            else
            {
                return;
            }
        }

        public bool CheckUser(int id)
        {
            return _context.Users.Any(u => u.UserId == id);
        }

        public User DeleteUser(int id)
        {
            try
            {
                User user = _context.Users.Find(id);

                if(user != null)
                {
                    _context.Remove(user);
                    _context.SaveChanges();
                    return user;
                }
                else
                {
                    throw new ArgumentNullException();
                }

            }
            catch
            {
                throw;
            }
        }

        public User GetUserById(int id)
        {
            try
            {
                List<User> users = _context.Users.Where(i => i.UserId == id).Include(m => m.MRI_Results).
                    Include(s => s.ClinicReservations).ToList();

                User user = users.FirstOrDefault();
                if (user != null)
                {
                    return user;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        public List<User> GetUsers()
        {
            try
            {
                return _context.Users.Where(i => i.UserId ==0).Include(m => m.MRI_Results).
                    Include(s=>s.ClinicReservations).ToList();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateUser(User user)
        {
            try
            {
                _context.Entry(user).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
