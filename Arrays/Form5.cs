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
    public partial class Form5 : Form
    {
        private int[] getallen;

        public Form5()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            string txt = txtInvoer.Text;
            // Controleer of zeven getallen opgegeven werden
            if (txt.Split(',').Where(x => int.TryParse(x, out _)).Select(Int32.Parse).Count() != 10)
            {
                MessageBox.Show("Geef 10 getallen op.", "Fout");
                return;
            }

            // Sla de getallen op
            getallen = txt.Split(',').Where(x => int.TryParse(x, out _)).Select(Int32.Parse).ToArray();

            VindEvenGetallen(getallen);

        }

        private void VindEvenGetallen(int[] getallen)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < getallen.Length; i++)
            {
                if (getallen[i] % 2 == 0)
                {
                    sb.Append(getallen[i] + " ");
                }
                
            }
            lblResultaat.Text = sb.ToString().Trim(' ');
        }
    }
}
