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
    public partial class Form2 : Form
    {
        private int[] getallen;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            string txt = txtInvoer.Text;
            // Controleer of zeven getallen opgegeven werden
            if(txt.Split(',').Where(x => int.TryParse(x, out _)).Select(Int32.Parse).Count() != 7)
            {
                MessageBox.Show("Geef 7 getallen op.", "Fout");
                return;
            }
            
            // Sla de getallen op
            getallen = txt.Split(',').Where(x => int.TryParse(x, out _)).Select(Int32.Parse).ToArray();

        }

        private void btnToonGetal_Click(object sender, EventArgs e)
        {
            int getal = Int32.Parse(txtKeuze.Text);
            if(getal > 0 && getal <= 7)
            {
                lblResultaat.Text = getallen[getal-1].ToString();
            }
        }
    }
}
