using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02.Models
{
    public class Moon : CelestialBody
    {
        public Planet ParentPlanet { get; set; }
        public string SurfaceFeatures { get; set; }
        public bool TidalLocking { get; set; }
        public bool SubsurfaceOcean { get; set; }
    }
}
