using System;
using System.Data;
using HomeLib.Entity.Database.DTO;

namespace HomeLib.Entity.Database.Providers
{
    public class BookDbProvider : DbEntityProvider<Book, Guid>
    {
        public BookDbProvider(IDbConnection connection) : base(connection)
        {
        }
    }
}