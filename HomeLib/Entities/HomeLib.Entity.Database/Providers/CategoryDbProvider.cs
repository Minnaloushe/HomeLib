using System;
using System.Data;
using HomeLib.Entity.Database.DTO;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.Providers
{
    public interface ICategoryDbProvider : IDbProvider<ICategory, Category, Guid>
    {
        
    }
    public class CategoryDbProvider : DbEntityProvider<ICategory, Category, Guid>, ICategoryDbProvider
    {
        public CategoryDbProvider(IDbConnection connection) : base(connection)
        {
        }
    }
}