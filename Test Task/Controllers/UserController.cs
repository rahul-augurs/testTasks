
using Microsoft.AspNetCore.Mvc;
using Test_Task_Domain;
using Test_Task_DTO.UserMaster;
using Test_Task_Service.IRepository;

namespace Test_Task.Controllers
{
    
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository user;

        public UserController(IUserRepository user)
        {
            this.user = user;
        }



        [HttpGet]
        [Route("api/UsersbyStatus/")]
        public IActionResult UsersbyStatus()
        {
            return Ok(user.GetByStatus("active"));
        }

        [HttpGet]
        [Route("api/Usersbystatusandgender")]
        public IActionResult UsersbyStatusandGender()
        {
            return Ok(user.GetByStatusandGender("inactive","female"));
        }

        [HttpPost]
        [Route("api/Userbyemail")]
        public IActionResult UserbyEmail(string email)
        {
            return Ok(user.GetByEmail(email));
        }

    }
}
