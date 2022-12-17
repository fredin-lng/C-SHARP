using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


/// <summary>
/// Programmer: Alfredo Castillo
/// Program Objectinve: This program convert us currency to a different countrys currency. Only for Mark, Yen, Canadian, Pounds. 
/// Date: 09/20/2021
/// </summary>


namespace Currency_Converter
{
    public partial class Form1 : Form
    {
        /// <summary>
        ///  specify global parameters
        /// </summary>
        bool isNumeric;
        double acValue;
        double currency;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /// disable buttons on application start up
            btnCanadian.Enabled = false;
            btnMarks.Enabled = false;
            btnMarks.Enabled = false;
            btnPound.Enabled = false;
            btnYen.Enabled = false;
        }

        private void btnPound_Click(object sender, EventArgs e)
        {
            ///Globalization library you can use culture
            ///information to use the format the currency for different
            ///countries.
            CultureInfo culInfo = new CultureInfo("en-GB");

            /// try to convert to a numeric value
            isNumeric = double.TryParse(txtUS.Text, out acValue);

            /// if numeric value, convert currency amount to yen. else clear us text box and converted text box.
            if (isNumeric)
            {                
                currency = Convert.ToDouble(txtUS.Text) * 0.73;

                txtCurrencyConverter.Text = currency.ToString("C", culInfo);

                lblCurrencyConverter.Text = "Pounds";
                picCurrency.Image = Properties.Resources.uk;
            }
            else
            {
                reset();
            }
        }

        private void btnCanadian_Click(object sender, EventArgs e)
        {
            ///Globalization library you can use culture
            ///information to use the format the currency for different
            ///countries.
            CultureInfo culInfo = new CultureInfo("en-GB");

            /// try to convert to a numeric value
            isNumeric = double.TryParse(txtUS.Text, out acValue);

            /// if numeric value, convert currency amount to yen. else clear us text box and converted text box.
            if (isNumeric)
            {
                currency = Convert.ToDouble(txtUS.Text) * 1.28;

                txtCurrencyConverter.Text = currency.ToString("C", culInfo);

                lblCurrencyConverter.Text = "Canadian";
                picCurrency.Image = Properties.Resources.canada;
            }
            else
            {
                reset();
            }
        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            ///Globalization library you can use culture
            ///information to use the format the currency for different
            ///countries.
            CultureInfo culInfo = new CultureInfo("en-GB");

            /// try to convert to a numeric value
            isNumeric = double.TryParse(txtUS.Text, out acValue);

            /// if numeric value, convert currency amount to yen. else clear us text box and converted text box.
            if (isNumeric)
            {
                currency = Convert.ToDouble(txtUS.Text) * 1.66712;

                txtCurrencyConverter.Text = currency.ToString("C", culInfo);

                lblCurrencyConverter.Text = "DEM";
                picCurrency.Image = Properties.Resources.germany;
            }
            else
            {
                reset();
            }
        }

        private void btnYen_Click(object sender, EventArgs e)
        {
            ///Globalization library you can use culture
            ///information to use the format the currency for different
            ///countries.
            CultureInfo culInfo = new CultureInfo("en-GB");
            
            /// try to convert to a numeric value
            isNumeric = double.TryParse(txtUS.Text, out acValue);

            /// if numeric value, convert currency amount to yen. else clear us text box and converted text box.
            if (isNumeric)
            {
                currency = Convert.ToDouble(txtUS.Text) * 109.88;
                txtCurrencyConverter.Text = currency.ToString("C", culInfo);

                lblCurrencyConverter.Text = "Yen";
                picCurrency.Image = Properties.Resources.japan;
            }
            else
            {
                reset();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            /// clears out the all the textboxes and the converted flag image
            txtUS.Text = "";
            txtCurrencyConverter.Text = "";
            picCurrency.Image = Properties.Resources.MONEY;
            txtUS.Select();
        }

        private void reset()
        {
            /// clears out the all the textboxes and the currency converted flag image
            //MessageBox.Show("Only numbers allowed!", " Input Error");
            txtUS.Text = "";
            txtCurrencyConverter.Text = "";
            picCurrency.Image = Properties.Resources.MONEY;
            txtUS.Select();
        }

        public bool isUsCurrencyEmpty()
        {
            /// check if us currency text box is empty and return true if empty, false if not empty
            if (String.IsNullOrWhiteSpace(txtUS.Text) || txtUS.Text.Trim().Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtUS_TextChanged(object sender, EventArgs e)
        {
            
            /// enables buttons if us currency text box is not empty
            if (isUsCurrencyEmpty() == false)
            {
                btnCanadian.Enabled = true;
                btnMarks.Enabled = true;
                btnMarks.Enabled = true;
                btnPound.Enabled = true;
                btnYen.Enabled = true;
            }
            /// enables buttons if us currency text box is not empty
            else
            {
                btnCanadian.Enabled = false;
                btnMarks.Enabled = false;
                btnMarks.Enabled = false;
                btnPound.Enabled = false;
                btnYen.Enabled = false;
            }
            isNumeric = double.TryParse(txtUS.Text, out acValue);

            /// displays error if a character other than a numberic is entered
            if (!isNumeric && txtUS.Text != "")
            {
                MessageBox.Show("Only Numbers allowed", "Invalid Input");
                txtUS.Text = "";
            }
        }        
    }
}
