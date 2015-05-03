using System;
using System.Data;
using HomeLib.Entity.Database.DTO;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.Providers
{
    public interface ISettingDbProvider : IDbProvider<ISetting, Setting, Guid>
    {
        
    }

    public class SettingDbProvider : DbEntityProvider<ISetting, Setting, Guid>, ISettingDbProvider
    {
        public SettingDbProvider(IDbConnection connection) : base(connection)
        {
        }
    }
}