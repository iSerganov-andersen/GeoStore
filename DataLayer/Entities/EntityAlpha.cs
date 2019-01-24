using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    public class EntityAlpha : IEntityAlpha<Guid>
    {
        public Guid Id { get ; set; }
        public string Name { get; set; }
    }
}
