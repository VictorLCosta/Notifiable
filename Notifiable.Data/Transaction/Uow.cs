using System;
using System.Threading.Tasks;
using Notifiable.Data.Interfaces;
using Notifiable.Data.Repositories;

namespace Notifiable.Data.Transaction
{
    public class Uow : IUow
    {
        public IUserRepository Users { get; }

        private readonly ApplicationDbContext _context;

        public Uow(ApplicationDbContext context)
        {
            _context = context;

            Users = new UserRepository(_context);
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }

        public async void Dispose()
        {
            await Disposing(true);
        }

        protected virtual async Task Disposing(bool active)
        {
            if(active)
            {
                await _context.DisposeAsync();
            }
        }

    }
}
