namespace HomeLib.Entity.Interfaces.Context
{
    public interface IContextEntity<T>
    {
        T Id { get; set; }
    }
}