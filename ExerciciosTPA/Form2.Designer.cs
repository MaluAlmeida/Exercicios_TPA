
namespace ExerciciosTPA
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnenquanto = new System.Windows.Forms.Button();
            this.btnrepita = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnpara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnenquanto
            // 
            this.btnenquanto.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnenquanto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnenquanto.Location = new System.Drawing.Point(471, 96);
            this.btnenquanto.Name = "btnenquanto";
            this.btnenquanto.Size = new System.Drawing.Size(90, 34);
            this.btnenquanto.TabIndex = 1;
            this.btnenquanto.Text = "ENQUANTO";
            this.btnenquanto.UseVisualStyleBackColor = false;
            this.btnenquanto.Click += new System.EventHandler(this.btnenquanto_Click);
            // 
            // btnrepita
            // 
            this.btnrepita.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnrepita.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnrepita.Location = new System.Drawing.Point(471, 136);
            this.btnrepita.Name = "btnrepita";
            this.btnrepita.Size = new System.Drawing.Size(90, 34);
            this.btnrepita.TabIndex = 2;
            this.btnrepita.Text = "REPITA";
            this.btnrepita.UseVisualStyleBackColor = false;
            this.btnrepita.Click += new System.EventHandler(this.btnrepita_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnlimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnlimpar.Location = new System.Drawing.Point(471, 246);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(90, 32);
            this.btnlimpar.TabIndex = 4;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(239, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Número:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(145, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "A tabuada desse número é: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(343, 98);
            this.txtnum.Multiline = true;
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(76, 23);
            this.txtnum.TabIndex = 7;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(343, 171);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtresult.Size = new System.Drawing.Size(76, 132);
            this.txtresult.TabIndex = 8;
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnvoltar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnvoltar.Location = new System.Drawing.Point(12, 12);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(85, 30);
            this.btnvoltar.TabIndex = 9;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click_1);
            // 
            // btnpara
            // 
            this.btnpara.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnpara.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnpara.Location = new System.Drawing.Point(471, 176);
            this.btnpara.Name = "btnpara";
            this.btnpara.Size = new System.Drawing.Size(90, 34);
            this.btnpara.TabIndex = 10;
            this.btnpara.Text = "PARA";
            this.btnpara.UseVisualStyleBackColor = false;
            this.btnpara.Click += new System.EventHandler(this.btnpara_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnpara);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnrepita);
            this.Controls.Add(this.btnenquanto);
            this.Name = "Form2";
            this.Text = "Tabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnenquanto;
        private System.Windows.Forms.Button btnrepita;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnpara;
    }
}