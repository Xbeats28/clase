namespace WindowsFormsApp4
{
    partial class ejer2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dias = new System.Windows.Forms.TextBox();
            this.mes = new System.Windows.Forms.TextBox();
            this.año = new System.Windows.Forms.TextBox();
            this.txtmostrar = new System.Windows.Forms.Label();
            this.btnconvert = new System.Windows.Forms.Button();
            this.btnpimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dias
            // 
            this.dias.Location = new System.Drawing.Point(209, 89);
            this.dias.Name = "dias";
            this.dias.Size = new System.Drawing.Size(100, 20);
            this.dias.TabIndex = 3;
            // 
            // mes
            // 
            this.mes.Location = new System.Drawing.Point(209, 116);
            this.mes.Name = "mes";
            this.mes.Size = new System.Drawing.Size(100, 20);
            this.mes.TabIndex = 4;
            // 
            // año
            // 
            this.año.Location = new System.Drawing.Point(209, 142);
            this.año.Name = "año";
            this.año.Size = new System.Drawing.Size(100, 20);
            this.año.TabIndex = 5;
            // 
            // txtmostrar
            // 
            this.txtmostrar.AutoSize = true;
            this.txtmostrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtmostrar.Location = new System.Drawing.Point(245, 180);
            this.txtmostrar.Name = "txtmostrar";
            this.txtmostrar.Size = new System.Drawing.Size(0, 13);
            this.txtmostrar.TabIndex = 6;
            // 
            // btnconvert
            // 
            this.btnconvert.Location = new System.Drawing.Point(373, 85);
            this.btnconvert.Name = "btnconvert";
            this.btnconvert.Size = new System.Drawing.Size(75, 23);
            this.btnconvert.TabIndex = 7;
            this.btnconvert.Text = "convertir";
            this.btnconvert.UseVisualStyleBackColor = true;
            this.btnconvert.Click += new System.EventHandler(this.btnconvert_Click);
            // 
            // btnpimpiar
            // 
            this.btnpimpiar.Location = new System.Drawing.Point(373, 112);
            this.btnpimpiar.Name = "btnpimpiar";
            this.btnpimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnpimpiar.TabIndex = 8;
            this.btnpimpiar.Text = "Limpiar";
            this.btnpimpiar.UseVisualStyleBackColor = true;
            this.btnpimpiar.Click += new System.EventHandler(this.btnpimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(373, 137);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 9;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // ejer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnpimpiar);
            this.Controls.Add(this.btnconvert);
            this.Controls.Add(this.txtmostrar);
            this.Controls.Add(this.año);
            this.Controls.Add(this.mes);
            this.Controls.Add(this.dias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ejer2";
            this.Text = "ejer2";
            this.Load += new System.EventHandler(this.ejer2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dias;
        private System.Windows.Forms.TextBox mes;
        private System.Windows.Forms.TextBox año;
        private System.Windows.Forms.Label txtmostrar;
        private System.Windows.Forms.Button btnconvert;
        private System.Windows.Forms.Button btnpimpiar;
        private System.Windows.Forms.Button btnsalir;
    }
}