using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Contact : BaseEntity,IEntity
    {
        public string Message { get; set; }
        public DateTime AppointmentTime { get; set; }
    }
}
