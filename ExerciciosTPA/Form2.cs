using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExerciciosTPA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void btnenquanto_Click(object sender, EventArgs e)
        {
            double num, I, result;

            num = Convert.ToDouble(txtnum.Text);
            I = 1;
            while (I<=10)
            {
                result = num * I;
                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + result.ToString());
                I++;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresult.Clear();
            txtnum.Focus();


        }

        private void btnrepita_Click(object sender, EventArgs e)
        {
            double num, I, result;
            num = Convert.ToDouble(txtnum.Text);
            I = 1;
            do
            {
                
                result = num * I;
                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + result.ToString());
                I++;
            } while (I < 11);
        }

        private void btnvoltar_Click_1(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            this.Hide();
            inicio.Show();
        }

        private void btnpara_Click(object sender, EventArgs e)
        {
            double num, I, result;

            for (I = 1; I <= 10; I++)
            {
                num = Convert.ToDouble(txtnum.Text);
                result = num * I;
                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + result.ToString());
            }
        }
    }
}
