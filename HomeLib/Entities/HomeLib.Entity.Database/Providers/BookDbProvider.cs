using System;
using System.Data;
using HomeLib.Entity.Database.DTO;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.Providers
{
    public class BookDbProvider : DbEntityProvider<IBook, Guid>
    {
        public BookDbProvider(IDbConnection connection) : base(connection)
        {
        }
    }
}