using System;
using System.Threading.Tasks;
using Agenda.Models;
using Agenda.Models.Services;
using Agenda.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Controllers
{
    [Authorize]
    [ApiController]
    [Route("auth")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Logon";
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<ActionResult<UserToken>> CreateUser([FromBody] UserRegisterViewModel model)
        {
            return await _userService.CreateUser(model);
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<ActionResult<UserToken>> Login([FromBody] UserLoginViewModel model)
        {
            return await _userService.Login(model);
        }

    }

}
