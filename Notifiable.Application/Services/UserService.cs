using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Notifiable.Application.Interfaces;
using Notifiable.Application.PasswordHasher;
using Notifiable.Application.ViewModels;
using Notifiable.Data.Transaction;
using Notifiable.Domain.Entities;

namespace Notifiable.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUow _uow;
        private readonly Hasher _hasher;
        private readonly IMapper _mapper;

        public UserService(IUow uow, Hasher hasher, IMapper mapper)
        {
            _uow = uow;
            _hasher = hasher;
            _mapper = mapper;
        }

        public async Task<IActionResult> AddAsync(UserViewModel model)
        {
            try
            {
                model.Validate();

                if(model.Invalid)
                    return new OkObjectResult(new { success = false, errors = model.Notifications });

                var user = _mapper.Map<User>(model);
                user.PasswordHash = await _hasher.HashPassword(model.ProvidedPassword);

                await _uow.Users.AddAsync(user);

                return new OkObjectResult(new { success = true, message = "Usuário criado com sucesso" });
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}
