namespace WindowsFormsApp2
{
    partial class btnguardar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DNI = new System.Windows.Forms.Label();
            this.btnpulsar = new System.Windows.Forms.Button();
            this.btnagregardni = new System.Windows.Forms.Button();
            this.lblmostrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(395, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.Location = new System.Drawing.Point(363, 76);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(26, 13);
            this.DNI.TabIndex = 2;
            this.DNI.Text = "DNI";
            // 
            // btnpulsar
            // 
            this.btnpulsar.Location = new System.Drawing.Point(445, 103);
            this.btnpulsar.Name = "btnpulsar";
            this.btnpulsar.Size = new System.Drawing.Size(75, 23);
            this.btnpulsar.TabIndex = 3;
            this.btnpulsar.Text = "mostrar dni";
            this.btnpulsar.UseVisualStyleBackColor = true;
            this.btnpulsar.Click += new System.EventHandler(this.btnpulsar_Click);
            // 
            // btnagregardni
            // 
            this.btnagregardni.Location = new System.Drawing.Point(366, 102);
            this.btnagregardni.Name = "btnagregardni";
            this.btnagregardni.Size = new System.Drawing.Size(75, 23);
            this.btnagregardni.TabIndex = 4;
            this.btnagregardni.Text = "guardar dni";
            this.btnagregardni.UseVisualStyleBackColor = true;
            this.btnagregardni.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblmostrar
            // 
            this.lblmostrar.AutoSize = true;
            this.lblmostrar.Location = new System.Drawing.Point(538, 112);
            this.lblmostrar.Name = "lblmostrar";
            this.lblmostrar.Size = new System.Drawing.Size(0, 13);
            this.lblmostrar.TabIndex = 5;
            // 
            // btnguardar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmostrar);
            this.Controls.Add(this.btnagregardni);
            this.Controls.Add(this.btnpulsar);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.textBox1);
            this.Name = "btnguardar";
            this.Text = "Guardar DNI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.Button btnpulsar;
        private System.Windows.Forms.Button btnagregardni;
        private System.Windows.Forms.Label lblmostrar;
    }
}

