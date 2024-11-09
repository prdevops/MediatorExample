using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorExample.Entities
{
    public class ProductEntity
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public int Quanity { get; set; }
        public decimal Amount { get; set; }
    }
}
