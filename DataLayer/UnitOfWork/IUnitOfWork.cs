using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        GeoStoreContext Context { get; }
        void Commit();
    }
}
