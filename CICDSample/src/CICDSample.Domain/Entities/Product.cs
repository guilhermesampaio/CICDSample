using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CICDSample.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public decimal Price { get; set; }

    }
}
