using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork
    {
        public GeoStoreContext Context { get; }

        public UnitOfWork(GeoStoreContext context)
        {
            Context = context;
        }
        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();

        }
    }
}
