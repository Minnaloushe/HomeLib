using System;
using System.Collections.Generic;
using System.Data;
using HomeLib.Entity.Database.DTO;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.Providers
{
    public interface IArchiveFileDbProvider : IDbProvider<IArchiveFile, ArchiveFile, Guid>, IPagedDbProvider<IArchiveFile, ArchiveFile, Guid>
    {
        
    }

    public class ArchiveFileDbProvider : DbEntityProvider<IArchiveFile, ArchiveFile, Guid>, IArchiveFileDbProvider
    {
        public ArchiveFileDbProvider(IDbConnection connection) : base(connection)
        {
        }

        public IEnumerable<IArchiveFile> GetPage(int pageSize, int skip = 0)
        {
            return new PagedDbProvider<IArchiveFile, ArchiveFile, Guid>(Connection, GetTableName()).GetPage(pageSize, skip);
        }
    }
}