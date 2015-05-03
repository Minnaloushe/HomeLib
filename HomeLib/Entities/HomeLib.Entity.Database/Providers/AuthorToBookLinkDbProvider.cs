using System;
using System.Data;
using HomeLib.Entity.Database.DTO;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.Providers
{
    public interface IAuthorToBookLinkDbProvider : IDbProvider<IAuthorToBookLink, AuthorToBookLink, Guid>
    {
        
    }

    public class AuthorToBookLinkDbProvider : DbEntityProvider<IAuthorToBookLink, AuthorToBookLink, Guid>, IAuthorToBookLinkDbProvider
    {
        public AuthorToBookLinkDbProvider(IDbConnection connection) : base(connection)
        {
        }
    }
}