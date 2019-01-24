using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    public class Region: EntityAlpha
    {
        public Region()
        {
            Countries = new List<Country>();
        }
        public Double Area { get; set; }

        public virtual IList<Country> Countries { get; set; }
    }
}
