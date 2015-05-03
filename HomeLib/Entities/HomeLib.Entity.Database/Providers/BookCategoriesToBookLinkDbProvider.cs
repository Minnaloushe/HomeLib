using System;
using System.Data;
using HomeLib.Entity.Database.DTO;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.Providers
{
    public interface IBookCategoriesToBookLinkDbProvider :
        IDbProvider<IBookCategoriesToBookLink, BookCategoriesToBookLink, Guid>
    {
        
    }

    public class BookCategoriesToBookLinkDbProvider : DbEntityProvider<IBookCategoriesToBookLink, BookCategoriesToBookLink, Guid>, IBookCategoriesToBookLinkDbProvider
    {
        public BookCategoriesToBookLinkDbProvider(IDbConnection connection) : base(connection)
        {
        }
    }
}