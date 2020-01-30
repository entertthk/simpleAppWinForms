using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            int randomnum = rnd.Next(1, 100);

            if (randomnum < 50)
                {
                Console.Beep();
                textBox1.Text = randomnum.ToString();
                }
            else
            {
                {
                    Console.Beep();
                    Console.Beep();
                    textBox1.Text = randomnum.ToString();
                }
            }
            
        }
    }
}
