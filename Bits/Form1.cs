using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bits
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_toevoegen_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button_lijstopvragen_Click(object sender, EventArgs e)
        {

        }

        private void button_toevoeg_Click(object sender, EventArgs e)
        {
            Administratie Toevoeg = new Administratie();
            string helper;

            Toevoeg.AddKlant = textBox_toevoegen.Text;
            listBox1.Items.Add(Toevoeg.AddKlant);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_bewerken_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
