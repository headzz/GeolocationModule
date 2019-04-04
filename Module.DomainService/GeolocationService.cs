using Module.DomainModel.Entities;
using Module.DomainModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.DomainService
{
    public class GeolocationService
    {
        private IGeolocation _geolocation;

        public GeolocationService(IGeolocation geolocation)
        {
            _geolocation = geolocation;
        }

        public string GetSignal(WiFi wifi, _3G thirdGeneration, GPS gps)
        {
            return _geolocation.GetSignal(wifi, thirdGeneration, gps);
        }

        public string GetLocation(WiFi wifi, _3G thirdGeneration, GPS gps)
        {
            return _geolocation.GetLocation(wifi, thirdGeneration, gps);
        }
    }
}
