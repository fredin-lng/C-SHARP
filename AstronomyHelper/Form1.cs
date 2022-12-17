using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Programmer: Alfredo Castillo
/// Program Objectinve: This program displays basic information for each planet in our solar system.
/// Date: 12/09/2021
/// </summary>


namespace AstronomyHelper
{
    public partial class Form1 : Form
    {
        // create an instance of solar system model
        private SolarSystemModel sm = new SolarSystemModel();

        // crate an instance of bindingsource
        BindingSource planetsBinding = new BindingSource();

        // declare variables
        public string planetType;
        public string planetDistance;
        public string planetMass;
        public string planetTemperature;

        public Form1()
        {
            InitializeComponent();

            // loop through each item in Planets list array and assign each planet name as a sub-menu in the Planet Menu
            foreach (var item in sm.Planets)
            {
                ToolStripItem subItem = new ToolStripMenuItem(item.PlanetName);
                subItem.Click += new EventHandler(menu_Click);
                planetsToolStripMenuItem.DropDownItems.Add(subItem);
            }

        }  

        void menu_Click(object sender, EventArgs e)
        {
            // create an instace for fPlanets
            frmPlanets fPlanets = new frmPlanets();

            // assign the sender text to string
            string sPlanet = sender.ToString(); ;

            // set fPlanet title
            fPlanets.Text = sPlanet;

            // loop through the list array
            for (int i = 0; i < sm.Planets.Count; i++)
            {
                if (sm.Planets[i].PlanetName.ToString() == sPlanet)
                {
                    fPlanets.PlanetType = sm.Planets[i].Type.ToString();
                    fPlanets.PlanetDistance = sm.Planets[i].Distance.ToString();
                    fPlanets.PlanetMass = sm.Planets[i].PlanetMass.ToString();
                    fPlanets.PlanetTemperature = sm.Planets[i].PlanetTemperature.ToString();
                    fPlanets.PlanetImage = sm.Planets[i].PlanetPicture;
                }
            }

            // hide Form1
            this.Hide();

            // show frmPlanets
            fPlanets.ShowDialog();

            // dispose frmPlanets intance
            fPlanets = null;

            // show Form1 again
            this.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display an about message
            MessageBox.Show("Developer: Alfredo Castillo\n\nDate Created: 12/09/2021\n\n" +
                "Summary: This is a simple program design to display the most basic\n\n" +
                "information of every planet in our solar system.","About", MessageBoxButtons.OK);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // kill application
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // kill application when form is closed
            Application.Exit();
        }
    }
}
