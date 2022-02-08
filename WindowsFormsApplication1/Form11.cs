using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        double result = 0;
        double wsp = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
                MessageBox.Show("Podaj swój wzrost!");
            if (checkBox1.Checked)
            {
                result = Double.Parse(textBox1.Text) - 100;
                label4.Text = result.ToString()+" kg";    
            }
            else if (checkBox2.Checked)
            {
                if (radioButton1.Checked)
                    wsp = 0.85;
                else if (radioButton2.Checked)
                    wsp = 0.9;
                else
                    MessageBox.Show("Zaznacz swoją płeć!");
                result = (Double.Parse(textBox1.Text) - 100) * wsp;
                label4.Text = result.ToString()+" kg";
            }
            else
                MessageBox.Show("Wybierz jedną z dostępnych opcji wagi!");
        }
    }
}
