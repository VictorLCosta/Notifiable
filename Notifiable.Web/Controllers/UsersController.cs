using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Notifiable.Application.Interfaces;
using Notifiable.Application.ViewModels;

namespace Notifiable.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserViewModel model)
        {
            var result = await _userService.AddAsync(model);
            return result;
        }
    }
}
