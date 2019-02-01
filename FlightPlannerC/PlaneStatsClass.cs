using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlannerC
{

    class PlaneStats
    {
        private Plane plane;

        public Plane Specs
        {
            get { return plane; }
            set { plane = value; }
        }

        public int CruiseSpeed { get { return plane.CruiseSpeed; } }
        public int MaxRange { get { return plane.MaxRange; } }
        public int MaxFuel { get { return plane.MaxFuel; } }
        public int EmptyWeight { get { return plane.EmptyWeight; } }
        public int MaxTakeOff { get { return plane.MaxTakeOff; } }
        public int CruisingAlt { get { return plane.CruisingAlt; } }
    }

}
