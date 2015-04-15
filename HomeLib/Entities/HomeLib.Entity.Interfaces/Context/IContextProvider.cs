namespace HomeLib.Entity.Interfaces.Context
{
    public interface IContextProvider<T, TKey> where T: IContextEntity<TKey>
    {
        
    }
}