using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02.Models
{
    public class CelestialBody
    {
        public string Name { get; set; }
        public double Mass { get; set; }
        public double Diameter { get; set; }
        public double OrbitDistance { get; set; }
        public double OrbitPeriod { get; set; }
        public double RotationPeriod { get; set; }
        public string AtmosphericComposition { get; set; }
        public double AverageTemperature { get; set; }
    }
}
