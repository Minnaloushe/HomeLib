using System;
using System.Data;
using HomeLib.Entity.Database.DTO;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.Providers
{
    public interface IGenreDbProvider : IDbProvider<IGenre, Genre, Guid>
    {
        
    }
    public class GenreDbProvider : DbEntityProvider<IGenre, Genre, Guid>, IGenreDbProvider
    {
        public GenreDbProvider(IDbConnection connection) : base(connection)
        {
        }
    }
}