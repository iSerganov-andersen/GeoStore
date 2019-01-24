using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repos
{
    public class CurrencyRepo : BaseRepo<Currency, Guid>
    {
        public CurrencyRepo(UnitOfWork.UnitOfWork uow)
            : base(uow)
        {

        }
    }
}
