using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text= trackBar1.Value.ToString();
            this.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
            this.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar1.Value.ToString();
            this.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int k = r.Next(256);
            int y = r.Next(256);
            int m = r.Next(256);
            this.BackColor = Color.FromArgb(k, y, m);
            label1.Text = k.ToString();
            label2.Text = y.ToString();
            label3.Text = m.ToString();
        }
    }
}
