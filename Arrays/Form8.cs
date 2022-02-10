using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form8 : Form
    {
        private int[] getallen;
        private int aantal;

        public Form8()
        {
            InitializeComponent();
            
        }
        private void btnAantal_Click(object sender, EventArgs e)
        {
            try
            {
                btnAantal.BackColor = Color.White;
                getallen = new int[20];
                aantal = Int32.Parse(txtAantal.Text);
                if (aantal > 20)
                {
                    MessageBox.Show("Geef een getal kleiner dan 20 in.", "Error", MessageBoxButtons.OK);
                }
                btnAantal.BackColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Geef een getal in.", "Error", MessageBoxButtons.OK);
            }
            
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            string txt = txtInvoer.Text;
            // Controleer of zeven getallen opgegeven werden
            if (txt.Split(',').Where(x => int.TryParse(x, out _)).Select(Int32.Parse).Count() != aantal)
            {
                MessageBox.Show("Geef " + aantal + " getallen op.", "Fout");
                return;
            }

            // Sla de getallen op
            getallen = txt.Split(',').Where(x => int.TryParse(x, out _)).Select(Int32.Parse).ToArray();

            int som = BerekenSom(getallen);
            double gemiddelde = BerekenGemiddelde(getallen);
            
            lblResSom.Text = som.ToString();
            lblResGem.Text = gemiddelde.ToString();

        }

        private int BerekenSom(int[] getallen)
        {
            return getallen.Sum();
        }

        private double BerekenGemiddelde(int[] getallen)
        {
            return Math.Round(getallen.Average(), 2);
        }
    }
}
