using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    public interface IEntityAlpha<Key> where Key: struct
    {
        Key Id { get; set; }
        String Name { get; set; }
    }
}
