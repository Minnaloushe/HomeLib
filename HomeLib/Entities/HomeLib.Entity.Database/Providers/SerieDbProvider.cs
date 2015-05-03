using System;
using System.Data;
using HomeLib.Entity.Database.DTO;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.Providers
{
    public interface ISerieDbProvider : IDbProvider<ISerie, Serie, Guid>
    {
        
    }

    public class SerieDbProvider : DbEntityProvider<ISerie, Serie, Guid>, ISerieDbProvider
    {
        public SerieDbProvider(IDbConnection connection) : base(connection)
        {
        }
    }
}