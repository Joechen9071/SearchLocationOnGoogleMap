using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchLocationOnGoogleMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string add = "";
            string urladd = "https://www.google.com/maps/place/";
            if (!Country.Text.Equals(""))
            {
                if (add.Equals("")) {
                    add = add + Country.Text + ",";
                }
                else
                {
                    add = add + "+" + Country.Text + ",";
                }
            }
            if (!state.Text.Equals(""))
            {
                if (add.Equals(""))
                {
                    add = add + state.Text + ",";
                }
                else
                {
                    add = add + "+" + state.Text + ",";
                }
            }
            if (!city.Text.Equals(""))
            {
                if (add.Equals(""))
                {
                    add = add + city.Text + ",";
                }
                else
                {
                    add = add + "+" + city.Text + ",";
                }
            }
            if (!zip.Text.Equals(""))
            {
                if (add.Equals(""))
                {
                    add = add + zip.Text + ",";
                }
                else
                {
                    add = add + "+" + zip.Text + ",";
                }
            }
            urladd = urladd + add;

            webBrowser1.Navigate(urladd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
            webBrowser1.Navigate(Urladdress.Text);
        }
    }
}
