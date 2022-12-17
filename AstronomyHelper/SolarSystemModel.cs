using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstronomyHelper
{
    public class SolarSystemModel
    {
        public List<PlanetModel> Planets { get; set; }

        public SolarSystemModel()
        {
            Planets = new List<PlanetModel>();
            SetUpData();
        }

        public void SetUpData()
        {
            Planets.Add(new PlanetModel { PlanetName = "Mercury", Type = "Terrestial", Distance = "Average distance from the sun 0.387 AU", PlanetMass = "Mass 3.31 X 10^24 kg", PlanetTemperature = "Surface temperature -173°C to 430°C", PlanetPicture = Properties.Resources.mercury });
            Planets.Add(new PlanetModel { PlanetName = "Venus", Type = "Terrestial", Distance = "Average distance from the sun 0.7233 AU", PlanetMass = "Mass 4.87 X 10^24 kg", PlanetTemperature = "Surface temperature 472°C", PlanetPicture = Properties.Resources.venus });
            Planets.Add(new PlanetModel { PlanetName = "Earth", Type = "Terrestial", Distance = "Average distance from the sun 1 AU", PlanetMass = "Mass 5.967 X 10^24 kg", PlanetTemperature = "Surface temperature 50°C to 50°C", PlanetPicture = Properties.Resources.earth });
            Planets.Add(new PlanetModel { PlanetName = "Mars", Type = "Terrestial", Distance = "Average distance from the sun 1.5237 AU", PlanetMass = "Mass 0.6424 X 10^24 kg", PlanetTemperature = "Surface temperature 140°C to 20°C", PlanetPicture = Properties.Resources.mars });
            Planets.Add(new PlanetModel { PlanetName = "Jupiter", Type = "Jovian", Distance = "Average distance from the sun 5.2028 AU", PlanetMass = "Mass 1.899 X 10^27 kg", PlanetTemperature = "Temperature at cloud tops 110°C", PlanetPicture = Properties.Resources.jupiter });
            Planets.Add(new PlanetModel { PlanetName = "Saturn", Type = "Jovian", Distance = "Average distance from the sun 9.5388 AU", PlanetMass = "Mass 5.69 X 10^26 kg", PlanetTemperature = "Temperature at cloud tops 180°C", PlanetPicture = Properties.Resources.satrun });
            Planets.Add(new PlanetModel { PlanetName = "Uranus", Type = "Jovian", Distance = "Average distance from the sun 19.18 AU", PlanetMass = "Mass 8.69 X 10^25 kg", PlanetTemperature = "Temperature at cloud tops 220°C", PlanetPicture = Properties.Resources.neptune });
            Planets.Add(new PlanetModel { PlanetName = "Neptune", Type = "Jovian", Distance = "Average distance from the sun 30.0611 AU", PlanetMass = "Mass 1.03 X 10^26 kg", PlanetTemperature = "Temperature at cloud tops 216°C", PlanetPicture = Properties.Resources.uranus });
            Planets.Add(new PlanetModel { PlanetName = "Pluto", Type = "Type Low density", Distance = "Average distance from the sun 39.44 AU", PlanetMass = "Mass 1.2 X 10^22 kg", PlanetTemperature = "Temperature at cloud tops 230°C", PlanetPicture = Properties.Resources.pluto });
        }
    }
}
