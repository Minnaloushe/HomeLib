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
    public abstract class DbEntityProvider<T, TKey> : IDbProvider<T, TKey>, IDisposable where T : IBaseEntity<TKey>, new()
    {
        private readonly IDbConnection _connection;

        protected DbEntityProvider(IDbConnection connection)
        {
            _connection = connection;
        }

        public T GetById(TKey id)
        {
            return _connection.ExecuteScalar<T>(GetRetreiveCommandText(), new {Id = id});
        }

        public T Create()
        {
            return new T();
        }

        public void Insert(T entity)
        {
            _connection.Execute(GetCreateCommandText(), entity);
        }

        public void Update(T entity)
        {
            _connection.Execute(GetUpdateCommandText(), entity);
        }

        public void Delete(TKey id)
        {
            _connection.Execute(GetDeleteCommandText(), new {Id = id});
        }

        protected virtual string GetTableName()
        {
            return typeof (T).ToString();
        }

        protected virtual string GetUpdateCommandText()
        {
            return typeof (T) + "_Update";
        }

        protected virtual string GetCreateCommandText()
        {
            return typeof (T) + "_Create";
        }

        protected virtual string GetDeleteCommandText()
        {
            return typeof (T) + "_Delete";
        }

        protected virtual string GetRetreiveCommandText()
        {
            return typeof (T) + "_Retreive";
        }

        public void Dispose()
        {
            _connection.Dispose();
        }
    }
}
