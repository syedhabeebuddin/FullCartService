using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCart.Infrastructure.Database.Entities
{
    public class Inventory : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
    }
}
