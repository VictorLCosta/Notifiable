using System;
using System.Threading.Tasks;
using Notifiable.Data.Interfaces;

namespace Notifiable.Data.Transaction
{
    public interface IUow : IDisposable
    {
        IUserRepository Users { get; }

        Task Commit();
    }
}
