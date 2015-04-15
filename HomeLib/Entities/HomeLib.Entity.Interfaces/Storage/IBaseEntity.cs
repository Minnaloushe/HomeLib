namespace HomeLib.Entity.Interfaces.Storage
{
    public interface IBaseEntity<T>
    {
        T Id { get; set; }
    }
}