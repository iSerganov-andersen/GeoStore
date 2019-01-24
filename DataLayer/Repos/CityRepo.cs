using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repos
{
    public class CityRepo : BaseRepo<City, Guid>
    {
        public CityRepo(UnitOfWork.UnitOfWork uow)
            : base(uow)
        {

        }
    }
}
