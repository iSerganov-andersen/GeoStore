using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    public class Currency: EntityAlpha
    {
        public Currency()
        {
            Countries = new List<CountryCurrencies>();
        }
        public String Code { get; set; }

        public virtual IList<CountryCurrencies> Countries { get; set; }
    }
}
