namespace WindowsFormsApp4
{
    partial class ejer4
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
            this.btnconvertir = new System.Windows.Forms.Button();
            this.txtdatos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmins = new System.Windows.Forms.TextBox();
            this.Horas = new System.Windows.Forms.Label();
            this.txtsec = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnconvertir
            // 
            this.btnconvertir.Location = new System.Drawing.Point(225, 153);
            this.btnconvertir.Name = "btnconvertir";
            this.btnconvertir.Size = new System.Drawing.Size(75, 23);
            this.btnconvertir.TabIndex = 0;
            this.btnconvertir.Text = "convertir";
            this.btnconvertir.UseVisualStyleBackColor = true;
            this.btnconvertir.Click += new System.EventHandler(this.btnconvertir_Click);
            // 
            // txtdatos
            // 
            this.txtdatos.Location = new System.Drawing.Point(200, 127);
            this.txtdatos.Name = "txtdatos";
            this.txtdatos.Size = new System.Drawing.Size(100, 20);
            this.txtdatos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero Horas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mins";
            // 
            // txtmins
            // 
            this.txtmins.Location = new System.Drawing.Point(193, 196);
            this.txtmins.Name = "txtmins";
            this.txtmins.Size = new System.Drawing.Size(100, 20);
            this.txtmins.TabIndex = 4;
            // 
            // Horas
            // 
            this.Horas.AutoSize = true;
            this.Horas.Location = new System.Drawing.Point(158, 228);
            this.Horas.Name = "Horas";
            this.Horas.Size = new System.Drawing.Size(26, 13);
            this.Horas.TabIndex = 5;
            this.Horas.Text = "Sec";
            // 
            // txtsec
            // 
            this.txtsec.Location = new System.Drawing.Point(193, 225);
            this.txtsec.Name = "txtsec";
            this.txtsec.Size = new System.Drawing.Size(100, 20);
            this.txtsec.TabIndex = 6;
            // 
            // ejer4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtsec);
            this.Controls.Add(this.Horas);
            this.Controls.Add(this.txtmins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdatos);
            this.Controls.Add(this.btnconvertir);
            this.Name = "ejer4";
            this.Text = "ejer4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconvertir;
        private System.Windows.Forms.TextBox txtdatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmins;
        private System.Windows.Forms.Label Horas;
        private System.Windows.Forms.TextBox txtsec;
    }
}