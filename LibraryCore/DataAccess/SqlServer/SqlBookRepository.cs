using LibraryCore.Domain.Abstract;
using LibraryCore.Domain.Entities;
using System.Collections.Generic;

namespace LibraryCore.DataAccess.SqlServer
{
    public class SqlBookRepository : SqlBaseRepository ,  IBookRepository
    {
        public SqlBookRepository(SqlContext context) : base(context)
        {
        }

        public int Add(Book obj)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Book FindById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Book> Get()
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Book obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
