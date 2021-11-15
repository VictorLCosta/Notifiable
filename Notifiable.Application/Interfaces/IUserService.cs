using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Notifiable.Application.ViewModels;

namespace Notifiable.Application.Interfaces
{
    public interface IUserService
    {
        Task<IActionResult> AddAsync(UserViewModel model);
    }
}
