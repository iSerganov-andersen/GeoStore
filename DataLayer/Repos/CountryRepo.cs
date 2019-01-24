using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repos
{
    public class CountryRepo: BaseRepo<Country, Guid>
    {
        public CountryRepo(UnitOfWork.UnitOfWork uow)
            :base(uow)
        {

        }
    }
}
