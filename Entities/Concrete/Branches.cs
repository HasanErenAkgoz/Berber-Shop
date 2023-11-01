using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Branches : BaseEntity,IEntity
    {
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
    }
}
