using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VucutKitleIndeks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy = Convert.ToDouble(textBox1.Text);
            double kilo = Convert.ToDouble(textBox2.Text);
            double vki0;
            double vki1;
            double vki2;
            double vki3;
            double vki4;

            vki0 = kilo / (boy * boy);
            vki1 = kilo / (boy * boy);
            vki2 = kilo / (boy * boy);
            vki3 = kilo / (boy * boy);
            vki4 = kilo / (boy * boy);
            

            textBox3.Text = vki1.ToString("0.##");

           

            if(vki1>=18.5 || vki1 <= 24.99)
            {
                label5.Text = "NORMAL";
            }

            if(25<=vki2 || 29 <= vki2)
            {
                label5.Text = "FAZLA KİLOLU";
            }

            if(30<=vki3 || 39 <= vki3)
            {
                label5.Text = "OBEZ";
            }
            if (vki4>=40)
            {
                label5.Text = "MORBİD OBEZ";

            }
            else
            {
                label5.Text = "ZAYIF";
            }
            
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label5.Text = "";
        }
    }
}
