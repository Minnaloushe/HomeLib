using System;
using System.Data;
using HomeLib.Entity.Database.DTO;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.Providers
{
    public interface IArchiveFileDbProvider : IDbProvider<IArchiveFile, ArchiveFile, Guid>
    {
        
    }

    public class ArchiveFileDbProvider : DbEntityProvider<IArchiveFile, ArchiveFile, Guid>, IArchiveFileDbProvider
    {
        public ArchiveFileDbProvider(IDbConnection connection) : base(connection)
        {
        }
    }
}