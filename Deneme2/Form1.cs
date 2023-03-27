using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "sabri" && textBox2.Text == "1234")
            {
                anasayfa anasayfa = new anasayfa();
                anasayfa.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Şifre Hatalıdır.");
            }
           
        }

        private void label7_Click(object sender, EventArgs e)
        {
            kaydol kaydol = new kaydol();
            kaydol.Show();
            this.Hide();
        }
    }
}
