using graduation.Model;

namespace graduation.Interface
{
    public interface IUser
    {
        public List<User> GetUsers();
        public User GetUserById(int id);
        public void AddUser(User user);
        public void UpdateUser(User user);
        public User DeleteUser(int id);
        public bool CheckUser(int id);
    }
}
