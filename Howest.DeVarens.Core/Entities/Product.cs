using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howest.DeVarens.Core.Entities
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public ICollection<Media> Media { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Guid FormOfEducationId { get; set; }
        public FormOfEducation FormOfEducation { get; set; }
    }
}
