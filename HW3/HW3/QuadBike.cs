using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class QuadBike : Transport
    {
        public string CurrentTrack { get; }

        public QuadBike(double engineVolume, string transmission, double maxSpeed, string currentTrack)
            : base(engineVolume, transmission, maxSpeed)
        {
            this.CurrentTrack = currentTrack;
        }

        override public string GetFullInfo()
        {
            StringBuilder fullInfo = new StringBuilder(base.GetFullInfo());
            fullInfo.Append("Current track: " + CurrentTrack + "\n");
            return fullInfo.ToString();
        }
    }
}
