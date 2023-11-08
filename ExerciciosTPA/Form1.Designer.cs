
namespace ExerciciosTPA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício13ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercício11ToolStripMenuItem,
            this.exercício12ToolStripMenuItem,
            this.exercício13ToolStripMenuItem});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programasToolStripMenuItem.Text = "Programas";
            // 
            // exercício11ToolStripMenuItem
            // 
            this.exercício11ToolStripMenuItem.Name = "exercício11ToolStripMenuItem";
            this.exercício11ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exercício11ToolStripMenuItem.Text = "Exercício 11";
            this.exercício11ToolStripMenuItem.Click += new System.EventHandler(this.exercício11ToolStripMenuItem_Click);
            // 
            // exercício12ToolStripMenuItem
            // 
            this.exercício12ToolStripMenuItem.Name = "exercício12ToolStripMenuItem";
            this.exercício12ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exercício12ToolStripMenuItem.Text = "Exercício 12";
            this.exercício12ToolStripMenuItem.Click += new System.EventHandler(this.exercício12ToolStripMenuItem_Click);
            // 
            // exercício13ToolStripMenuItem
            // 
            this.exercício13ToolStripMenuItem.Name = "exercício13ToolStripMenuItem";
            this.exercício13ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exercício13ToolStripMenuItem.Text = "Exercício 13";
            this.exercício13ToolStripMenuItem.Click += new System.EventHandler(this.exercício13ToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Início";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercício11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercício12ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercício13ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

