namespace HomeLib.Entity.Interfaces.Storage
{
    public interface IBaseEntity<T>
    {
        T Id { get; set; }
    }

    public interface IDbEntity
    {
        string TableName { get; }
        string CreateCommand { get; }
        string UpdateCommand { get; }
        string DeleteCommand { get; }
        string RetreiveCommand { get; }
    }
}