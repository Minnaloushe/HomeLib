using System.Collections.Generic;

namespace HomeLib.Entity.Interfaces.Context
{
    public interface IManyToManyLinkedProperty<T> : ICollection<T>
    {
        void Load();
    }
}