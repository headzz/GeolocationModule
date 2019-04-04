using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.DomainModel.Entities
{
    public class Geolocation
    {
        public Guid Id{ get; set; }
        public string Location { get; set; }
    }
}
