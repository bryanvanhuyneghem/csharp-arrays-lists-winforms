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
    public partial class Form1b : Form
    {
        private List<int> getallen;

        public Form1b()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            string txt = txtInvoer.Text;
            getallen = txt.Split(',').Where(x => int.TryParse(x, out _)).Select(Int32.Parse).ToList();

            StringBuilder sb = new StringBuilder();
            sb.Append(getallen[0]);
            int resultaat = getallen[0];

            for (int i = 1; i < getallen.Count; i++)
            {
                if (i % 2 == 1)
                {
                    sb.Append(" +");
                    resultaat += getallen[i];
                } else
                {
                    sb.Append(" -");
                    resultaat -= getallen[i];
                }
                sb.Append(" " + getallen[i]);

            }

            txtBewerking.Text = sb.ToString();

            lblRes.Text = resultaat.ToString();
        }
    }
}
