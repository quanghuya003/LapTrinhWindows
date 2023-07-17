using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 objForm03 = new Form3();
            objForm03.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 objForm02 = new Form2();
            objForm02.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 objForm04 = new Form4();
            objForm04.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 objForm05 = new Form5();
            objForm05.ShowDialog();
        }
    }
}
