using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta é uma mensagem de alerta.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Poderia informar seus dados para futuro contato?";
            string caption = "Pergunta";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {MessageBox.Show("OK Obrigado! Em breve entrarei em contato!", "Resposta SIM", MessageBoxButtons.OK);
            }
            else{MessageBox.Show("OK Sem problemas! ", "Resposta NÃO", MessageBoxButtons.OK);}
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("É isso mesmo que pensou?",
                "Pergunta", 
                MessageBoxButtons.YesNoCancel, 
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("opção sim");
            }
            else if (resultado == DialogResult.No)
            {
                MessageBox.Show("opção não");
            }
            else {
                MessageBox.Show("opção cancelada");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;
            valor1 = double.Parse(textBox1.Text);
            valor2 = double.Parse(textBox2.Text);
            resultado = valor1 + valor2;
            textBox3.Text = resultado.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;
            valor1 = double.Parse(textBox1.Text);
            valor2 = double.Parse(textBox2.Text);
            resultado = valor1 - valor2;
            textBox3.Text = resultado.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;
            valor1 = double.Parse(textBox1.Text);
            valor2 = double.Parse(textBox2.Text);
            resultado = valor1 * valor2;
            textBox3.Text = resultado.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;
            valor1 = double.Parse(textBox1.Text);
            valor2 = double.Parse(textBox2.Text);
            resultado = valor1 / valor2;
            textBox3.Text = resultado.ToString();
        }
    }
}
