using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using HomeLib.Entity.Database.DTO;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.Providers
{
    public interface IAuthorDbProvider : IDbProvider<IAuthor, Author, Guid>
    {
        IEnumerable<IAuthor> GetPage(int pageSize, int skip = 0);
    }

    public class AuthorDbProvider : DbEntityProvider<IAuthor, Author, Guid>, IAuthorDbProvider
    {
        public AuthorDbProvider(IDbConnection connection) : base(connection)
        {

        }

        public IEnumerable<IAuthor> GetPage(int pageSize, int skip = 0)
        {
            return Connection.Query<Author>(GetTableName() + "_GetPage", new {pageSize, skip}, commandType: CommandType.StoredProcedure);
        }
    }
}