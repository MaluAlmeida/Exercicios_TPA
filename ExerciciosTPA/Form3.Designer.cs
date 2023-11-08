
namespace ExerciciosTPA
{
    partial class Form3
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
            this.btnpara = new System.Windows.Forms.Button();
            this.btnrepita = new System.Windows.Forms.Button();
            this.btnenquanto = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcelsius = new System.Windows.Forms.TextBox();
            this.txtfarenheit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnpara
            // 
            this.btnpara.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnpara.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnpara.Location = new System.Drawing.Point(542, 187);
            this.btnpara.Name = "btnpara";
            this.btnpara.Size = new System.Drawing.Size(94, 34);
            this.btnpara.TabIndex = 9;
            this.btnpara.Text = "PARA";
            this.btnpara.UseVisualStyleBackColor = false;
            this.btnpara.Click += new System.EventHandler(this.btnpara_Click);
            // 
            // btnrepita
            // 
            this.btnrepita.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnrepita.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnrepita.Location = new System.Drawing.Point(542, 147);
            this.btnrepita.Name = "btnrepita";
            this.btnrepita.Size = new System.Drawing.Size(94, 34);
            this.btnrepita.TabIndex = 8;
            this.btnrepita.Text = "REPITA";
            this.btnrepita.UseVisualStyleBackColor = false;
            this.btnrepita.Click += new System.EventHandler(this.btnrepita_Click);
            // 
            // btnenquanto
            // 
            this.btnenquanto.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnenquanto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnenquanto.Location = new System.Drawing.Point(540, 107);
            this.btnenquanto.Name = "btnenquanto";
            this.btnenquanto.Size = new System.Drawing.Size(96, 34);
            this.btnenquanto.TabIndex = 7;
            this.btnenquanto.Text = "ENQUANTO";
            this.btnenquanto.UseVisualStyleBackColor = false;
            this.btnenquanto.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnlimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnlimpar.Location = new System.Drawing.Point(542, 249);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(94, 33);
            this.btnlimpar.TabIndex = 6;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnvoltar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnvoltar.Location = new System.Drawing.Point(12, 12);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(82, 34);
            this.btnvoltar.TabIndex = 5;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(146, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "O resultado em Farenheit é:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(72, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Qual a temperatura em Celsius:";
            // 
            // txtcelsius
            // 
            this.txtcelsius.Location = new System.Drawing.Point(393, 116);
            this.txtcelsius.Name = "txtcelsius";
            this.txtcelsius.Size = new System.Drawing.Size(100, 23);
            this.txtcelsius.TabIndex = 12;
            this.txtcelsius.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtfarenheit
            // 
            this.txtfarenheit.Location = new System.Drawing.Point(433, 169);
            this.txtfarenheit.Multiline = true;
            this.txtfarenheit.Name = "txtfarenheit";
            this.txtfarenheit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtfarenheit.Size = new System.Drawing.Size(60, 111);
            this.txtfarenheit.TabIndex = 13;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtfarenheit);
            this.Controls.Add(this.txtcelsius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnpara);
            this.Controls.Add(this.btnrepita);
            this.Controls.Add(this.btnenquanto);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnvoltar);
            this.Name = "Form3";
            this.Text = "Conversor de Temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnpara;
        private System.Windows.Forms.Button btnrepita;
        private System.Windows.Forms.Button btnenquanto;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcelsius;
        private System.Windows.Forms.TextBox txtfarenheit;
    }
}