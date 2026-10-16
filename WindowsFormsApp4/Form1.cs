using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtA.Text, out int a) &&
       int.TryParse(txtB.Text, out int b))
            {
                lblNetice.Text = "Nəticə: " + (a - b);
            }
            else
            {
                lblNetice.Text = "Düzgün ədəd daxil edin!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtA.Text, out int a) &&
       int.TryParse(txtB.Text, out int b))
            {
                lblNetice.Text = "Nəticə: " + (a * b);
            }
            else
            {
                lblNetice.Text = "Düzgün ədəd daxil edin!";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtA.Text, out int a) &&
                int.TryParse(txtB.Text, out int b))
            {
                lblNetice.Text = "Nəticə: " + (a + b);
            }
            else
            {
                lblNetice.Text = "Düzgün ədəd daxil edin!";
            }
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtA.Text, out int a) &&
       int.TryParse(txtB.Text, out int b))
            {
                if (b == 0)
                {
                    lblNetice.Text = "Sıfıra bölmək olmaz!";
                }
                else
                {
                    lblNetice.Text = "Nəticə: " + ((double)a / b);
                }
            }
            else
            {
                lblNetice.Text = "Düzgün ədəd daxil edin!";
            }
        }
    }
}
