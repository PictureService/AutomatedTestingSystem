using System;
using System.Collections.Generic;

namespace AutomatedTestingSystem.DatabaseRepository
{
    public abstract class Repository<T> where T : class
    {
        internal virtual int Create(T item)
        {
            throw new NotImplementedException();
        }

        internal virtual T Read(int id)
        {
            throw new NotImplementedException();
        }

        internal virtual IReadOnlyCollection<T> ReadAll(Filter filter)
        {
            throw new NotImplementedException();
        }

        internal virtual void Update(T item)
        {
            throw new NotImplementedException();
        }

        internal virtual void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
