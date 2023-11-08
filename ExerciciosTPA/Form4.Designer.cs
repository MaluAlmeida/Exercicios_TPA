
namespace ExerciciosTPA
{
    partial class Form4
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
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlarg = new System.Windows.Forms.TextBox();
            this.txtcomp = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.lblarea = new System.Windows.Forms.Label();
            this.txtareatotal = new System.Windows.Forms.TextBox();
            this.lblareatotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnvoltar.ForeColor = System.Drawing.Color.White;
            this.btnvoltar.Location = new System.Drawing.Point(12, 12);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(82, 33);
            this.btnvoltar.TabIndex = 0;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnlimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnlimpar.Location = new System.Drawing.Point(381, 369);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(87, 34);
            this.btnlimpar.TabIndex = 1;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.MidnightBlue;
            this.btncalcular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncalcular.Location = new System.Drawing.Point(267, 369);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(84, 34);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "Calcular ";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(143, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Qual a largura em metros do cômodo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(81, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(455, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Qual o comprimento em metros do cômodo: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtlarg
            // 
            this.txtlarg.Location = new System.Drawing.Point(542, 110);
            this.txtlarg.Name = "txtlarg";
            this.txtlarg.Size = new System.Drawing.Size(100, 23);
            this.txtlarg.TabIndex = 7;
            // 
            // txtcomp
            // 
            this.txtcomp.Location = new System.Drawing.Point(542, 147);
            this.txtcomp.Name = "txtcomp";
            this.txtcomp.Size = new System.Drawing.Size(100, 23);
            this.txtcomp.TabIndex = 8;
            // 
            // txtnome
            // 
            this.txtnome.BackColor = System.Drawing.Color.White;
            this.txtnome.Location = new System.Drawing.Point(542, 180);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 23);
            this.txtnome.TabIndex = 10;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(267, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Qual o nome do cômodo: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtarea
            // 
            this.txtarea.Location = new System.Drawing.Point(426, 247);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(100, 23);
            this.txtarea.TabIndex = 11;
            this.txtarea.TextChanged += new System.EventHandler(this.txtarea_TextChanged);
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblarea.ForeColor = System.Drawing.Color.White;
            this.lblarea.Location = new System.Drawing.Point(197, 240);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(223, 30);
            this.lblarea.TabIndex = 12;
            this.lblarea.Text = "A area do cômodo é: ";
            this.lblarea.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblarea.Click += new System.EventHandler(this.lblarea_Click);
            // 
            // txtareatotal
            // 
            this.txtareatotal.Location = new System.Drawing.Point(426, 276);
            this.txtareatotal.Name = "txtareatotal";
            this.txtareatotal.Size = new System.Drawing.Size(100, 23);
            this.txtareatotal.TabIndex = 13;
            this.txtareatotal.Visible = false;
            // 
            // lblareatotal
            // 
            this.lblareatotal.AutoSize = true;
            this.lblareatotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblareatotal.ForeColor = System.Drawing.Color.White;
            this.lblareatotal.Location = new System.Drawing.Point(267, 269);
            this.lblareatotal.Name = "lblareatotal";
            this.lblareatotal.Size = new System.Drawing.Size(153, 30);
            this.lblareatotal.TabIndex = 14;
            this.lblareatotal.Text = "A area total é: ";
            this.lblareatotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblareatotal.Visible = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblareatotal);
            this.Controls.Add(this.txtareatotal);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcomp);
            this.Controls.Add(this.txtlarg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnvoltar);
            this.Name = "Form4";
            this.Text = "Área dos cômodos";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlarg;
        private System.Windows.Forms.TextBox txtcomp;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.Label lblarea;
        private System.Windows.Forms.TextBox txtareatotal;
        private System.Windows.Forms.Label lblareatotal;
    }
}