using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            int misir, su, kola, bilet, cay, tutar;
            misir = Convert.ToInt16(textBox1.Text);
            su = Convert.ToInt16(textBox2.Text);
            kola = Convert.ToInt16(textBox3.Text);
            cay = Convert.ToInt16(textBox4.Text);
            bilet = Convert.ToInt16(textBox5.Text);
            tutar = misir * 60 + su * 20 + kola * 50 + cay * 25 + bilet * 125;
            label13.Text = tutar.ToString() + " TL";
            //listBox1.Items.Add("Toplam borcunuz: " + tutar +" TL");
            kasatutar += tutar;
            label15.Text = kasatutar.ToString() + " TL";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox1.Focus();
        }
    }
}
