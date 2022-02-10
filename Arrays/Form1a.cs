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
    public partial class Form1a : Form
    {
        private List<int> getallen;

        public Form1a()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            string txt = txtInvoer.Text;
            getallen = txt.Split(',').Where(x => int.TryParse(x, out _)).Select(Int32.Parse).ToList();


            lblResultaat.Text = getallen.Sum().ToString(); 
        }
    }
}
