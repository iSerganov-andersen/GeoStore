using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    public class CountryCurrencies
    {
        public Guid CountryId { get; set; }
        public virtual Country Country { get; set; }

        public Guid CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }
    }
}
