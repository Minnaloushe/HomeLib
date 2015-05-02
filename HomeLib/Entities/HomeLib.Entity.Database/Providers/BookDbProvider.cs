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
    public class SerieDbProvider : DbEntityProvider<ISerie, Guid>
    {
        public SerieDbProvider(IDbConnection connection) : base(connection)
        {
        }
    }
    public class BookToAuthorLinkDbProvider : DbEntityProvider<IAuthorToBookLink, Guid>
    {
        public BookToAuthorLinkDbProvider(IDbConnection connection) : base(connection)
        {
        }
    }
}