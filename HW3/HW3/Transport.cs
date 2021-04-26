using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    abstract class Transport
    {
        public double EngineVolume { get; }
        public string Transmission { get; }
        public double MaxSpeed { get; }

        public Transport(double engineVolume, string transmission, double maxSpeed)
        {
            this.EngineVolume = engineVolume;
            this.Transmission = transmission;
            this.MaxSpeed = maxSpeed;
        }
            
        virtual public string GetFullInfo()
        {
            StringBuilder fullInfo = new StringBuilder();

            fullInfo.Append("Engine volume: " + EngineVolume.ToString() + "\n");
            fullInfo.Append("Transmission: " + Transmission + "\n");
            fullInfo.Append("Maximum speed: " + MaxSpeed.ToString() + "\n");

            return fullInfo.ToString();
        }
    }
}
