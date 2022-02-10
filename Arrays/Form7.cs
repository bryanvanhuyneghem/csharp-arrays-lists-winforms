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
    public partial class Form7 : Form
    {
        private string[] getallen;

        public Form7()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            getallen = new string[10];

            for (int i = 1; i <= 10; i++)
            {
                getallen[i-1] = (i * 2).ToString();
            }

            richTxtOutput.Lines = getallen;


        }

    }
}
