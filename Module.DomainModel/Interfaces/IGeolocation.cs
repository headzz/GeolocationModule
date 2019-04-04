using Module.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.DomainModel.Interfaces
{
    public interface IGeolocation
    {
        string GetSignal(WiFi wifi, _3G thirdGeneration, GPS gps);
        string GetLocation(WiFi wifi, _3G thirdGeneration, GPS gps);
    }
}
