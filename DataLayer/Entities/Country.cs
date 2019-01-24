using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    public class Country: EntityAlpha
    {
        public Country()
        {
            Borders = new List<CountryBorders>();
            Currency = new List<CountryCurrencies>();
        }
        public String CommonName { get; set; }
        public String OfficialName { get; set; }
        public Boolean Independent { get; set; }
        public Boolean LandLocked { get; set; }
        public String IsoCode2 { get; set; }
        public String IsoCode3 { get; set; }
        public String CallingCode { get; set; }
        public String InternetDomain { get; set; }
        public Double Latitude { get; set; }
        public Double Longitude { get; set; }

        public virtual IList<CountryBorders> Borders { get; set; }
        public virtual IList<CountryCurrencies> Currency { get; set; }
        public virtual City Capital { get; set; }
        public virtual Region Region { get; set; }
    }
}
