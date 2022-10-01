using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howest.DeVarens.Core.Entities
{
    public class Media : EntityBase
    {
        public string Title { get; set; }
        public string Path { get; set; }
        public Guid? ProductId { get; set; }
    }
}
