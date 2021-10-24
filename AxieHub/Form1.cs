using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AxieHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            uint X;
            X = Convert.ToUInt32(label1.Text);
            if (X <= 9)
                X += 1;
            else
                X = 10;

            label1.Text = X.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            uint X;
            X = Convert.ToUInt32(label1.Text);
            if (X > 0){
                X -= 1;
            } else {
                X = 0;
            }

            label1.Text = X.ToString();
        }
    }
}
