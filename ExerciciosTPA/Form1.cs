using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosTPA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comENQUANTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void comREPITAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exercício11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 exercicio11 = new Form2();
            this.Hide();
            exercicio11.Show();
        }

        private void exercício12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 exercicio12 = new Form3();
            this.Hide();
            exercicio12.Show();
        }

        private void exercício13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 exercicio13 = new Form4();
            this.Hide();
            exercicio13.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
