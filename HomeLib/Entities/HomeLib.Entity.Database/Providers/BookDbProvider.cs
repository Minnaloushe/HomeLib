using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using HomeLib.Entity.Database.DTO;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.Providers
{
    public interface IBookDbProvider : IDbProvider<IBook, Book, Guid>, IPagedDbProvider<IBook, Book, Guid>
    {
        
    }

    public class BookDbProvider : DbEntityProvider<IBook, Book, Guid>, IBookDbProvider
    {
        public BookDbProvider(IDbConnection connection) : base(connection)
        {
        }

        public IEnumerable<IBook> GetPage(int pageSize, int skip = 0)
        {
            return new PagedDbProvider<IBook, Book, Guid>(Connection, GetTableName()).GetPage(pageSize, skip);
        }
    }
}