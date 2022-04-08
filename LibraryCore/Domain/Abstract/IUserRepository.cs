using LibraryCore.Domain.Entities;
using System;

namespace LibraryCore.Domain.Abstract
{
    public interface IUserRepository : IRepository<User>
    {
        User FindByUsername(string username);
    }
}
