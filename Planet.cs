using System;
using System.Collections.Generic;


namespace GalacticaAnna
{
    public enum PlanetType { Terrestial, Giant, Dwarf, Gas_Giant }
    class Planet : SpaceObjects
    {
        // Diameters are in meters
        public double Diameter { get; set; }
        //Rotation Period is in hours
        public double RotationPeriod {  get; set; }
        //Revolution Period is in days
        public double RevolutionPeriod {  get; set; }
        public object PlanetType { get;  set; }
        public object Type { get; internal set; }

        public List<Moon> moonList = new List<Moon>();
            public void Distance(Position first, Position second)

            {

                double distance = Math.Sqrt(Math.Pow(second.X - first.X, 2) + Math.Pow(second.Y - first.Y, 2));

                 
            }
    }
}
