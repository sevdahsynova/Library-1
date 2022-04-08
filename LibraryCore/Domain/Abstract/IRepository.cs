using LibraryCore.Domain.Entities;
using System.Collections.Generic;

namespace LibraryCore.Domain.Abstract
{
    // generic repository interface
    public interface IRepository<T>  where T : BaseEntity
    {
        int Add(T obj);
        bool Update(T obj);
        bool Delete(int id);
        T FindById(int id);
        List<T> Get();
    }
}
