using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExerciciosTPA
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double c, f, I, result;
            I = 10;
            c = Convert.ToDouble(txtcelsius.Text);
            f = (c * 9 / 5) + 32;
            while (I <= 100)
            {
                result = f + I;
                txtfarenheit.Text = String.Concat(txtfarenheit.Text +"\r\n"+ result.ToString());
                I = I + 10;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcelsius.Clear();
            txtfarenheit.Clear();
            txtcelsius.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            this.Hide();
            inicio.Show();
        }

        private void btnrepita_Click(object sender, EventArgs e)
        {
            double c, f, I, result;
            I = 10;
            c = Convert.ToDouble(txtcelsius.Text);
            f = (c * 9 / 5) + 32;
            do
            {
                result = f + I;
                txtfarenheit.Text = String.Concat(txtfarenheit.Text + "\r\n" + result.ToString());
                I = I + 10;
            } while (I <= 100);

        }

        private void btnpara_Click(object sender, EventArgs e)
        {
            double c, f, I, result;
            c = Convert.ToDouble(txtcelsius.Text);
            f = (c * 9 / 5) + 32;

            for (I = 10; I <= 100; )
            { 
                result = f + I;
                txtfarenheit.Text = String.Concat(txtfarenheit.Text + "\r\n" + result.ToString());
                I = I + 10;
            } 
        }
    }
}
