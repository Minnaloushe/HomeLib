using System;
using System.Collections.Generic;
using System.Data;
using HomeLib.Entity.Database.DTO;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.Providers
{
    public interface ISerieDbProvider : IDbProvider<ISerie, Serie, Guid>, IPagedDbProvider<ISerie, Serie, Guid>
    {
        
    }

    public class SerieDbProvider : DbEntityProvider<ISerie, Serie, Guid>, ISerieDbProvider
    {
        public SerieDbProvider(IDbConnection connection) : base(connection)
        {
        }

        public IEnumerable<ISerie> GetPage(int pageSize, int skip = 0)
        {
            return new PagedDbProvider<ISerie, Serie, Guid>(Connection, GetTableName()).GetPage(pageSize, skip);
        }
    }
}