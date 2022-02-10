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
    public partial class Form10 : Form
    {
        private List<int> fibonacciGetallen;
        private static int AANTAL = 20;
        public Form10()
        {
            InitializeComponent();
        }

        private void btnFib_Click(object sender, EventArgs e)
        {
            fibonacciGetallen = berekenFibonacci(AANTAL);
            StringBuilder sb = new StringBuilder();
            foreach (int fibonacci in fibonacciGetallen)
            {
                sb.Append(fibonacci + " ");
            }
            txtFib.Text = sb.ToString().Trim();
        }

        private List<int> berekenFibonacci(int aantal)
        {
            List<int> fib_getallen = new List<int>(aantal);
            // Som van twee voorgaande getallen geeft volgende getal
            int a = 0; // eerste getal
            int b = 1; // tweede getal
            int c = 0; // nieuwe getal

            // Voeg eerste twee getallen toe
            fib_getallen.Add(a);
            fib_getallen.Add(b);

            for (int i = 2; i < aantal; i++)
            {
                c = a + b; // bereken nieuwe getal
                fib_getallen.Add(c); // Voeg nieuwste getal toe

                a = b; // bepaal nieuwe eerste getal
                b = c; // bepaal nieuwe tweede getal
            }
            return fib_getallen;
        }
    }
}
