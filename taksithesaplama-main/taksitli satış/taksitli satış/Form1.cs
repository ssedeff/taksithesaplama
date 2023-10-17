using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taksitli_satış
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fiyat, taksit, tutar;
            fiyat=Convert.ToDouble(textBox1.Text);
            taksit = trackBar1.Value;
            tutar = fiyat / taksit;
            label3.Text = "TUTAR: " + tutar;
        }
    }
}
