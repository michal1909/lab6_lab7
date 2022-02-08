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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                label2.Text = "Twój ulubiony samochód to: " + comboBox1.SelectedItem.ToString();
            }
            else 
            {
                MessageBox.Show("Nie wybrałeś samochodu z listy!");
            }
        }
    }
}
