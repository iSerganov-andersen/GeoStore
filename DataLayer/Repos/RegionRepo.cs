using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repos
{
    public class RegionRepo : BaseRepo<Region, Guid>
    {
        public RegionRepo(UnitOfWork.UnitOfWork uow)
            : base(uow)
        {

        }
    }
}
