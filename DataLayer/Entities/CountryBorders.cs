using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    public class CountryBorders
    {
        public Guid CountryId { get; set; }
        public virtual Country Country { get; set; }

        public Guid BorderCountryId { get; set; }
        public virtual Country BorderCountry { get; set; }
    }
}
