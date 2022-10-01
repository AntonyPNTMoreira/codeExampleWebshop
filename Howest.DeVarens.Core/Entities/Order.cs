using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howest.DeVarens.Core.Entities
{
    public class Order : EntityBase
    {
        public ICollection<OrderItem> OrderItems { get; set; }
        public DateTime? ShippingDate { get; set; }
        public bool IsOpen { get; set; }
    }
}
