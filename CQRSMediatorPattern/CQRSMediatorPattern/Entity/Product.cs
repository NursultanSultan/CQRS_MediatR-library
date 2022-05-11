using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSMediatorPattern.Entity
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Qunetity { get; set; }

        public decimal Price { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
