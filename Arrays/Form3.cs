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
    public partial class Form3 : Form
    {
        private List<int> getallen;

        public Form3()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            string txt = txtInvoer.Text;
            getallen = txt.Split(',').Where(x => int.TryParse(x, out _)).Select(Int32.Parse).ToList();

            // Gebruik StringBuilder om resultaat te maken
            StringBuilder sb = new StringBuilder();
            sb.Append(getallen[getallen.Count-1]);

            for (int i = getallen.Count-2; i >= 0; i--)
            {
                sb.Append(" " + getallen[i]);
            }
            lblOutput.Text = sb.ToString();
        }
    }
}
