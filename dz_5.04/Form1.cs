using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz_5._04
{
    public partial class Form1 : Form
    {
        static int count = 1;
        Random random;
        public Form1()
        {
            InitializeComponent();
            string mesbox = "Yes - Name \t No - Year \t Cancel - Exit";
            DialogResult d = MessageBox.Show(mesbox, Convert.ToString(mesbox.Length / 3), MessageBoxButtons.YesNoCancel);
            if (d == DialogResult.Yes)
            {
                mesbox = "Name - Dmytro";
                string mesbox2 = Convert.ToString(mesbox.Length / 3);
                MessageBox.Show(mesbox, mesbox2, MessageBoxButtons.OK);
                mesbox = "Random";
                mesbox2 = Convert.ToString(mesbox.Length / 3);
                MessageBox.Show(mesbox, mesbox2, MessageBoxButtons.OK);
            }
            else if (d == DialogResult.No)
            {
                mesbox = "Year = 2004";
                string mesbox2 = Convert.ToString(mesbox.Length / 3);
                MessageBox.Show(mesbox, mesbox2, MessageBoxButtons.OK);
                if (d == DialogResult.No)
                {
                    mesbox = "???";
                    mesbox2 = Convert.ToString(mesbox.Length / 3);
                    MessageBox.Show(mesbox, mesbox2, MessageBoxButtons.OK);
                }
            }

            random = new Random();
            while (true)
            {
                int tmp = random.Next(1, 2000);
                DialogResult d2 = MessageBox.Show($"Numer = {tmp}?", "Guess numer", MessageBoxButtons.YesNo);
                if (d2 == DialogResult.Yes)
                {
                    MessageBox.Show($"Tries tp guess = {count}", "Guess numer", MessageBoxButtons.OK);
                    break;
                }
                else if (d2 == DialogResult.No)
                {
                    count++;
                }
            }

        }
    }
}
