using graduation.Interface;
using graduation.Model;
using Microsoft.AspNetCore.Mvc;

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
    }
}
