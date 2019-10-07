using System;
using System.Threading.Tasks;
using Agenda.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Models.Services
{
    public interface IUserService
    {
        Task<ActionResult<UserToken>> CreateUser(UserRegisterViewModel model);
        Task<ActionResult<UserToken>> Login(UserLoginViewModel model);
    }
}
