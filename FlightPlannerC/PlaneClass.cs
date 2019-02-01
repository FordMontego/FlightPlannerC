using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlannerC
{
    public class Plane
    {
        private int Cruise_Speed,
            Max_Range,
            Max_Fuel,
            Empty_Weight,
            Aircraft_Max_TO,
            Cruise_Alt;

        public void Planes(int CruiseSpeed, int MaxRange, int MaxFuel, int EmptyWeight, int AircraftMaxTO, int CruiseAlt)
        {
            this.Cruise_Speed = CruiseSpeed;
            this.Max_Range = MaxRange;
            this.Max_Fuel = MaxFuel;
            this.Empty_Weight = EmptyWeight;
            this.Aircraft_Max_TO = AircraftMaxTO;
            this.Cruise_Alt = CruiseAlt;
        }

        public Plane(string strPlane)
        {
            if (strPlane == "Beechcraft Baron 58")
            {
                Planes(200, 1569, 2224, 3911, 5521, 10000);
            }
            else if (strPlane == "Beechcraft King Air 350")
            {
                Planes(315, 1765, 3610, 9090, 15000, 10000);
            }
            else if (strPlane == "Cessna C172SP Skyhawk")
            {
                Planes(124, 638, 318, 1665, 2550, 8000);
            }
            else if (strPlane == "Cessna C182S Skylane")
            {
                Planes(140, 968, 552, 1810, 3110, 8000);
            }
            else if (strPlane == "Cessna C208 Caravan Amphibian")
            {
                Planes(143, 638, 2224, 4895, 8035, 6000);
            }
            else if (strPlane == "Cessna C208B Grand Caravan")
            {
                Planes(164, 638, 2224, 4575, 8785, 7000);
            }
            else if (strPlane == "Mooney(Bravo)")
            {
                Planes(195, 1050, 570, 2189, 3368, 8000);
            }
            else
            {
                Planes(100, 500, 100, 1000, 2000, 3000);
            }
        }

        public int CruiseSpeed { get { return Cruise_Speed; } }
        public int MaxRange { get { return Max_Range; } }
        public int MaxFuel { get { return Max_Fuel; } }
        public int EmptyWeight { get { return Empty_Weight; } }
        public int MaxTakeOff { get { return Aircraft_Max_TO; } }
        public int CruisingAlt { get { return Cruise_Alt; } }

    }

}
