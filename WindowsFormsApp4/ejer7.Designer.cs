namespace WindowsFormsApp4
{
    partial class ejer7
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
            this.btnconversoreuros = new System.Windows.Forms.Button();
            this.btnconvertirdollar = new System.Windows.Forms.Button();
            this.txtdollares = new System.Windows.Forms.TextBox();
            this.txteuros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnconversoreuros
            // 
            this.btnconversoreuros.Location = new System.Drawing.Point(223, 195);
            this.btnconversoreuros.Name = "btnconversoreuros";
            this.btnconversoreuros.Size = new System.Drawing.Size(75, 23);
            this.btnconversoreuros.TabIndex = 0;
            this.btnconversoreuros.Text = "Convertir a $";
            this.btnconversoreuros.UseVisualStyleBackColor = true;
            this.btnconversoreuros.Click += new System.EventHandler(this.btnconversoreuros_Click);
            // 
            // btnconvertirdollar
            // 
            this.btnconvertirdollar.Location = new System.Drawing.Point(223, 225);
            this.btnconvertirdollar.Name = "btnconvertirdollar";
            this.btnconvertirdollar.Size = new System.Drawing.Size(75, 23);
            this.btnconvertirdollar.TabIndex = 1;
            this.btnconvertirdollar.Text = "Convertir a €";
            this.btnconvertirdollar.UseVisualStyleBackColor = true;
            this.btnconvertirdollar.Click += new System.EventHandler(this.btnconvertirdollar_Click);
            // 
            // txtdollares
            // 
            this.txtdollares.Location = new System.Drawing.Point(223, 169);
            this.txtdollares.Name = "txtdollares";
            this.txtdollares.Size = new System.Drawing.Size(100, 20);
            this.txtdollares.TabIndex = 2;
            // 
            // txteuros
            // 
            this.txteuros.Location = new System.Drawing.Point(223, 143);
            this.txteuros.Name = "txteuros";
            this.txteuros.Size = new System.Drawing.Size(100, 20);
            this.txteuros.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "€";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(206, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Conversor";
            // 
            // ejer7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txteuros);
            this.Controls.Add(this.txtdollares);
            this.Controls.Add(this.btnconvertirdollar);
            this.Controls.Add(this.btnconversoreuros);
            this.Name = "ejer7";
            this.Text = "ejer7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconversoreuros;
        private System.Windows.Forms.Button btnconvertirdollar;
        private System.Windows.Forms.TextBox txtdollares;
        private System.Windows.Forms.TextBox txteuros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}