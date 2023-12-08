using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02.Models
{
    public class Planet : CelestialBody
    {
        public List<Moon> Moons { get; set; }
        public bool RingSystem { get; set; }
        public double MagneticFieldStrength { get; set; }
        public double SurfaceGravity { get; set; }
        public bool Habitable { get; set; }
    }
}
