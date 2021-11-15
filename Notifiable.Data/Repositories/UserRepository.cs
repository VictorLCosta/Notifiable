using System;
using Notifiable.Data.Interfaces;
using Notifiable.Domain.Entities;

namespace Notifiable.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) 
            : base(context)
        {
        }
    }
}
