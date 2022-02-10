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
    public partial class Form4 : Form
    {
        private int[] getallen;

        public Form4()
        {
            InitializeComponent();
        }

        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    int aantal = Int32.Parse(txtInput.Text);
                    getallen = new int[aantal];

                    for (int i = 0; i < getallen.Length; i++)
                    {
                        int getal;
                        while(!Int32.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Geef getal nummer " + (i + 1) + " op:", "Geef uw getallen in."), out getal)) 
                        {
                            // Blijf dezelfde vraag stellen tot er een geldig cijfer ingegeven wordt.
                        }
                        getallen[i] = getal;   
                    }

                    // Blijf vragen stellen
                    while (true)
                    {
                        string response = "";
                        int zoekgetal = -1;
                        bool succes = false;

                        do
                        {
                            response = Microsoft.VisualBasic.Interaction.InputBox("Geef een getal op en ik zeg je of het voorkomt. Geef \"END\" op om te stoppen.", "Getalzoeker");
                            // Stop het programma
                            if (response == "END")
                            {
                                System.Environment.Exit(0);
                            }
                            // Controleer of het een getal is
                            succes = Int32.TryParse(response, out zoekgetal);
                        } while (!succes);

                        // Zoek het getal in onze array
                        if (getallen.Contains(zoekgetal))
                        {
                            MessageBox.Show("Getal " + response + " gevonden!");
                        } else
                        {
                            MessageBox.Show("Getal niet gevonden! Probeer nog eens?");
                        }
                        succes = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Geef een strikt positief getal op.", "Fout");
                }
                
            }
        }
    }
}
