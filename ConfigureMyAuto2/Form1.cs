using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigureMyAuto2
{
    public partial class Form1 : Form
    {
        int priceOfCar;
        public Form1()
        {
            InitializeComponent();
        }

        private void car1_CheckedChanged(object sender, EventArgs e)
        {
            picBox.Image = ConfigureMyAuto2.Properties.Resources.Rkiwd;
            priceOfCar = 10340;
            price.Text = priceOfCar + "€";
            if (Chains.Checked)
            {
                priceOfCar += 100;
                price.Text = priceOfCar.ToString() + "€";
            }
            if (fLights.Checked)
            {
                priceOfCar += 450;
                price.Text = priceOfCar.ToString() + "€";
            }
            if (abs.Checked)
            {
                priceOfCar += 500;
                price.Text = priceOfCar.ToString() + "€";
            }
        }

        private void car2_CheckedChanged(object sender, EventArgs e)
        {
            picBox.Image = ConfigureMyAuto2.Properties.Resources.Tcorolla;
            priceOfCar = 20190;
            price.Text = priceOfCar + "€";
            if (Chains.Checked)
            {
                priceOfCar += 100;
                price.Text = priceOfCar.ToString() + "€";
            }
            if (fLights.Checked)
            {
                priceOfCar += 450;
                price.Text = priceOfCar.ToString() + "€";
            }
            if (abs.Checked)
            {
                priceOfCar += 500;
                price.Text = priceOfCar.ToString() + "€";
            }
        }

        private void car3_CheckedChanged(object sender, EventArgs e)
        {
            picBox.Image = ConfigureMyAuto2.Properties.Resources.Sswift;
            priceOfCar = 15990;
            price.Text = priceOfCar + "€";
            if (Chains.Checked)
            {
                priceOfCar += 100;
                price.Text = priceOfCar.ToString() + "€";
            }
            if (fLights.Checked)
            {
                priceOfCar += 450;
                price.Text = priceOfCar.ToString() + "€";
            }
            if (abs.Checked)
            {
                priceOfCar += 500;
                price.Text = priceOfCar.ToString() + "€";
            }
        }

        private void abs_CheckedChanged(object sender, EventArgs e)
        {
            if (abs.Checked)
            {
                priceOfCar += 500;
                price.Text = priceOfCar.ToString() + "€";
            }
            else
            {
                priceOfCar -= 500;
                price.Text = priceOfCar.ToString() + "€";
            }
        }

        private void fLights_CheckedChanged(object sender, EventArgs e)
        {
            if (fLights.Checked)
            {
                priceOfCar += 450;
                price.Text = priceOfCar.ToString() + "€";
            }
            else
            {
                priceOfCar -= 450;
                price.Text = priceOfCar.ToString() + "€";
            }
        }

        private void Chains_CheckedChanged(object sender, EventArgs e)
        {
            if (Chains.Checked)
            {
                priceOfCar += 100;
                price.Text = priceOfCar.ToString() + "€";
            }
            else
            {
                priceOfCar -= 100;
                price.Text = priceOfCar.ToString() + "€";
            }
        }

        private void calcDiss_Click(object sender, EventArgs e)
        {

            if (abs.Checked && fLights.Checked && Chains.Checked)
            {
                priceOfCar = priceOfCar - (int)(priceOfCar * 0.10);
                price.Text = priceOfCar.ToString() + "€";
            }
            else if (Cash.Checked)
            {
                priceOfCar = priceOfCar - (int)(priceOfCar * 0.05);
                price.Text = priceOfCar.ToString() + "€";
            }
            else if (abs.Checked && fLights.Checked && Chains.Checked && Cash.Checked)
            {
                priceOfCar = priceOfCar - (int)(priceOfCar * 0.15);
                price.Text = priceOfCar.ToString() + "€";
            }

        }

        private void reset_Click(object sender, EventArgs e)
        {
            car1.Checked = true;
            if (Chains.Checked)
            {
                priceOfCar += 100;
                price.Text = priceOfCar.ToString() + "€";
            }
            if (fLights.Checked)
            {
                priceOfCar += 450;
                price.Text = priceOfCar.ToString() + "€";
            }
            if (abs.Checked)
            {
                priceOfCar += 500;
                price.Text = priceOfCar.ToString() + "€";
            }
        }
    }
}
