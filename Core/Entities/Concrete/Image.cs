using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Image : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
    }
}
