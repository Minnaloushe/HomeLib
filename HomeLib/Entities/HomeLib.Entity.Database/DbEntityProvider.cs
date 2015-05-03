using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using HomeLib.Entity.Interfaces.Storage;
using Dapper;

namespace HomeLib.Entity.Database
{
    public abstract class DbEntityProvider<T, TK, TKey> : IDbProvider<T, TK, TKey>where T : IBaseEntity<TKey> where TK : class, IBaseEntity<TKey>, T
    {
        private readonly IDbConnection _connection;

        protected IDbConnection Connection { get { return _connection; } }

        protected DbEntityProvider(IDbConnection connection)
        {
            _connection = connection;
        }

        public T GetById(TKey id)
        {
            var result = _connection.Query<TK>(GetRetreiveCommandText(), new {Id = id}, commandType: CommandType.StoredProcedure).SingleOrDefault();

            if (result == null)
                throw new EntityNotFoundException(id);

            return result;
        }

        public void Insert(T entity)
        {
            _connection.Execute(GetCreateCommandText(), entity, commandType: CommandType.StoredProcedure);
        }

        public void Update(T entity)
        {
            var val = _connection.ExecuteScalar<int>(GetUpdateCommandText(), entity,
                commandType: CommandType.StoredProcedure);
            if (val != 1)
                throw new EntityNotFoundException(entity.Id);
        }

        public void Delete(TKey id)
        {
            var val = _connection.ExecuteScalar<int>(GetDeleteCommandText(), new {Id = id},
                commandType: CommandType.StoredProcedure);
            if ( val != 1)
                throw new EntityNotFoundException(id);
        }

        internal virtual string GetTableName()
        {
            return typeof (TK).Name;
        }

        protected virtual string GetUpdateCommandText()
        {
            return typeof (TK).Name + "_Update";
        }

        protected virtual string GetCreateCommandText()
        {
            return typeof (TK).Name + "_Create";
        }

        protected virtual string GetDeleteCommandText()
        {
            return typeof (TK).Name + "_Delete";
        }

        protected virtual string GetRetreiveCommandText()
        {
            return typeof (TK).Name + "_Retreive";
        }

        public void Dispose()
        {
            _connection.Dispose();
        }

        #region Exceptions

        public class DbProviderException : Exception
        {

        }

        public class EntityNotFoundException : DbProviderException
        {
            public TKey EntityId { get; private set; }
            public EntityNotFoundException(TKey id)
            {
                EntityId = id;
            }
        }

        #endregion
    }

}
