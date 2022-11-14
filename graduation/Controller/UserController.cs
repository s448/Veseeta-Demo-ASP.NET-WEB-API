using graduation.Interface;
using graduation.Model;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace graduation.Controller
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _user;

        public UserController(IUser user)
        {
            _user = user;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> Get()
        {
            List<User> Users =  _user.GetUsers();
            return await Task.FromResult(Users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> Get(int id)
        {
            var user = Task.FromResult(_user.GetUserById(id));
            if(user == null)
            {
                return NotFound();  
            }
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<User>> Post(User user)
        {
            _user.AddUser(user);
            return await Task.FromResult(user);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<User>> Put(int id , User user)
        {
            if(id == user.UserId)
            {
                try
                {
                    _user.UpdateUser(user);
                }
                catch
                {
                    if (user != null)
                        return NotFound();
                    throw;
                }
            }
            else
            {
                return BadRequest("user and id doesn't match");
            }
            return await Task.FromResult(user);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> Delete(int id)
        {
            var user = _user.DeleteUser(id);
            return await Task.FromResult(user);
        }
    }
}
