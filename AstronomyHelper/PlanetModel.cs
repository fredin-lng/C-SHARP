using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace AstronomyHelper
{
    public class PlanetModel
    {
        public string PlanetName { get; set; }
        public string Type { get; set; }
        public string Distance { get; set; }
        public string PlanetMass { get; set; }
        public string PlanetTemperature { get; set; }
        public Image PlanetPicture { get; set; }    
    }
}
