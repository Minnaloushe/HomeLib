using System;
using System.Data;
using HomeLib.Entity.Database.DTO;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.Providers
{
    public interface IBookDbProvider : IDbProvider<IBook, Book, Guid>
    {
        
    }

    public class BookDbProvider : DbEntityProvider<IBook, Book, Guid>, IBookDbProvider
    {
        public BookDbProvider(IDbConnection connection) : base(connection)
        {
        }
    }
}