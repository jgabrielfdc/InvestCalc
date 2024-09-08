using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorInv=double.Parse(textBox1.Text);
            double porcentagem=double.Parse(textBox2.Text);
            int tempo=int.Parse(textBox3.Text);

            try
            {
                    for (int i = 0; i < tempo; i++)
                    {
                        valorInv *= (porcentagem / 100 + 1);
                    }
                    textBox4.Text = "R$" + valorInv.ToString();
                }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Efetuar o calculo, Tente Novamente");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
