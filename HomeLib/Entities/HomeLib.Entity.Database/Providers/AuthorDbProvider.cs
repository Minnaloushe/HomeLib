using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using Dapper;
using HomeLib.Entity.Database.DTO;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.Providers
{
    public interface IAuthorDbProvider : IDbProvider<IAuthor, Author, Guid>, IPagedDbProvider<IAuthor, Author, Guid>
    {
    }

    public class AuthorDbProvider : DbEntityProvider<IAuthor, Author, Guid>, IAuthorDbProvider
    {
        public AuthorDbProvider(IDbConnection connection) : base(connection)
        {

        }

        public IEnumerable<IAuthor> GetPage(int pageSize, int skip = 0)
        {
            return new PagedDbProvider<IAuthor, Author, Guid>(Connection, GetTableName()).GetPage(pageSize, skip);
        }
    }
}