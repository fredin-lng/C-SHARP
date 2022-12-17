using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstronomyHelper
{
    public partial class frmPlanets : Form
    {
        public static string pType;
        public frmPlanets()
        {
            InitializeComponent();
        }

        public string PlanetType
        {
            set { lblType.Text = value; }
        }
        public string PlanetDistance
        {
            set { lblDistance.Text = value; }
        }
        public string PlanetMass
        {
            set { lblMass.Text = value; }
        }
        public string PlanetTemperature
        {
            set {lblTemperature.Text = value; }
        }

        public Image PlanetImage
        {
            set { pictureBox1.Image = value; }
        }
    }
}
