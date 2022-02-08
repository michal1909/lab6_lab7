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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        string sColor = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (rdoRed.Checked)
            { 
                sColor = rdoRed.Text;
            }
            if (rdoGreen.Checked)
            {
                sColor = rdoGreen.Text;
            }
            if (rdoBlue.Checked)
            {
                sColor = rdoBlue.Text;
            }
            MessageBox.Show("Twój ulubiony kolor to: "+sColor);
        }
    }
}
