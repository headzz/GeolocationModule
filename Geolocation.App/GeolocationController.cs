using Module.DomainModel.Entities;
using Module.DomainModel.Interfaces;
using Module.DomainService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeolocationApp
{
    public class GeolocationController
    {
        private static IGeolocation _geolocation;
        private GeolocationService _geolocationService = new GeolocationService(_geolocation);
        public Geolocation geolocation = new Geolocation();
        public _3G thirdGeneration = new _3G();
        public WiFi wifi = new WiFi();
        public GPS gps= new GPS();

        public string generateSignal() {
            string signalConnection = _geolocationService.GetSignal(wifi, thirdGeneration, gps);
                        
            if (wifi.availableData){
                signalConnection = wifi.Signal;
            }

            if (gps.availableData)
            {
                signalConnection = gps.Signal;
            }

            if (thirdGeneration.availableData)
            {
                signalConnection = thirdGeneration.Signal;
            }
            
            return signalConnection;
        }

        void generateLocation()
        {
            var initialize = generateSignal();

            if(initialize.Equals(wifi.Signal)){
                geolocation.Location = wifi.Location;
            }

            if (initialize.Equals(gps.Signal))
            {
                geolocation.Location = gps.Location;
            }

            if (initialize.Equals(thirdGeneration.Signal))
            {
                geolocation.Location = thirdGeneration.Location;
            }
        }
    }
}
