using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mycFibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = 1;
            int number2 = 1;
            int number3;

            listBox1.Items.Add(number1);
            listBox1.Items.Add(number2);

            for (int i = 0;  i<=8; i++)
            {
                number3 = number1 + number2;
                number1 = number2;
                number2 = number3;
                listBox1.Items.Add(number3);
            }
        }
    }
}
