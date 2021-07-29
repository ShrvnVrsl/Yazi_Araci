using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazi_araci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Left;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.Name, textBox1.Font.Size, textBox1.Font.Style ^ FontStyle.Bold);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.Name, textBox1.Font.Size, textBox1.Font.Style ^ FontStyle.Underline);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.Name, textBox1.Font.Size, textBox1.Font.Style ^ FontStyle.Italic);
        }

        private void orange_Click(object sender, EventArgs e)
        {

            textBox1.ForeColor = Color.Orange;
        }

        private void kirmizi_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void sari_Click(object sender, EventArgs e)
        {

            textBox1.ForeColor = Color.Yellow;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.Name, textBox1.Font.Size+4, textBox1.Font.Style );
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.Name, textBox1.Font.Size - 4, textBox1.Font.Style);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
