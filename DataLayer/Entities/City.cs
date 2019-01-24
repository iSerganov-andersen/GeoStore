using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    public class City: EntityAlpha
    {
        
        public Double Area { get; set; }
        public Double Population { get; set; }
        public Boolean HasSeaPort { get; set; }

        public Guid CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}
