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
    public partial class Form9 : Form
    {
        private List<string> woorden;
        public Form9()
        {
            InitializeComponent();
        }

        private void btnZoek_Click(object sender, EventArgs e)
        {
            woorden = richtxtWoorden.Lines.ToList();
            lblWoord.Text = vindAlfabetischEersteWoord(woorden);
        }

        private string vindAlfabetischEersteWoord(List<string> woorden)
        {
            woorden.Sort();
            return woorden[0];
        }
    }
}
