using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dnes = new DateTime();
                string[] datum = new string[2];
                List<DateTime> list = new List<DateTime>();
                DateTime max = new DateTime();
                for (int i = 0; i < textBox1.Lines.Count(); i++)
                {
                    string zaznam = textBox1.Lines[i];
                    datum = zaznam.Split(';');
                    list.Add(DateTime.Parse(datum[2]));
                }
                max = list[0];
                for (int j = 1; j < list.Count; j++)
                {
                    if (dnes - list[j] > dnes - max)
                    {
                        max = list[j];
                    }
                }
                label1.Text = "Nejstarší člověk se narodil: " + max.ToShortDateString();
            }
            catch 
            {
                MessageBox.Show("Neplatný tvar!");
            }
        }

    }
}
