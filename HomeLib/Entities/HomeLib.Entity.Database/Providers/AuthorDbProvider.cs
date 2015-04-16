using System;
using System.Data;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.Providers
{
    public class AuthorDbProvider : DbEntityProvider<IAuthor, Guid>
    {
        public AuthorDbProvider(IDbConnection connection) : base(connection)
        {

        }
    }
}