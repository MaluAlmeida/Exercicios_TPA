using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExerciciosTPA
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        double areatotal;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 inicio = new Form1();
            inicio.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtlarg.Clear();
            txtcomp.Clear();
            txtnome.Clear();
            txtarea.Clear();
            txtareatotal.Clear();
            txtlarg.Focus();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double l, c, Ar;
            l = Convert.ToDouble(txtlarg.Text);
            c = Convert.ToDouble(txtcomp.Text);
            Ar = l * c;
            areatotal += Ar;
            txtarea.Text = Ar.ToString();
            var result = MessageBox.Show("Deseja continuar calculando?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtlarg.Clear();
                txtcomp.Clear();
                txtnome.Clear();
                txtarea.Clear();
                txtlarg.Focus();
            }
            else {
                lblareatotal.Visible = true;
                txtareatotal.Visible = true;
                txtareatotal.Text = areatotal.ToString();
            }
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtarea_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void lblarea_Click(object sender, EventArgs e)
        {

        }
    }
}
