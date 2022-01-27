using ApplicationCore.Interfaces.Repository;
using System;

namespace ApplicationCore.Interfaces.UnitOfWork
{
    public interface IUnirOfWork : IDisposable
    {
        IUserRepository Users { get; }

        int Complete();

    }
}
