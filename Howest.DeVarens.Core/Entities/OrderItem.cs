using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howest.DeVarens.Core.Entities
{
    public class OrderItem : EntityBase
    {
        public int Quantity { get; set; }
        public Guid? ProductId { get; set; }
        public Product Product { get; set; }
        public Guid? OrderId { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
