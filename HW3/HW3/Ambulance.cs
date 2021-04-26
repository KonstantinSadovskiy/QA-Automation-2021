using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Ambulance : Transport
    {
        public bool _isInUse { get; }

        public Ambulance(double engineVolume, string transmission, double maxSpeed, bool _isInUse)
            : base(engineVolume, transmission, maxSpeed)
        {
            this._isInUse = _isInUse;
        }

        override public string GetFullInfo()
        {
            StringBuilder fullInfo = new StringBuilder(base.GetFullInfo());
            if (_isInUse)
            {
                fullInfo.Append("In use.\n");
            }
            else
            {
                fullInfo.Append("Not in use.\n");
            }
            return fullInfo.ToString();
        }
    }
}
