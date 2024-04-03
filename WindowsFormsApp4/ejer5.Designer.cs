namespace WindowsFormsApp4
{
    partial class ejer5
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
            this.dato1 = new System.Windows.Forms.TextBox();
            this.dato2 = new System.Windows.Forms.TextBox();
            this.btnmas = new System.Windows.Forms.Button();
            this.btnmenos = new System.Windows.Forms.Button();
            this.btnmultiplicar = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.labelsigno = new System.Windows.Forms.Label();
            this.igual = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dato1
            // 
            this.dato1.Location = new System.Drawing.Point(294, 112);
            this.dato1.Name = "dato1";
            this.dato1.Size = new System.Drawing.Size(32, 20);
            this.dato1.TabIndex = 0;
            // 
            // dato2
            // 
            this.dato2.Location = new System.Drawing.Point(372, 112);
            this.dato2.Name = "dato2";
            this.dato2.Size = new System.Drawing.Size(30, 20);
            this.dato2.TabIndex = 1;
            // 
            // btnmas
            // 
            this.btnmas.Location = new System.Drawing.Point(274, 139);
            this.btnmas.Name = "btnmas";
            this.btnmas.Size = new System.Drawing.Size(32, 30);
            this.btnmas.TabIndex = 2;
            this.btnmas.Text = "+";
            this.btnmas.UseVisualStyleBackColor = true;
            this.btnmas.Click += new System.EventHandler(this.btnpulsar_Click);
            // 
            // btnmenos
            // 
            this.btnmenos.Location = new System.Drawing.Point(312, 139);
            this.btnmenos.Name = "btnmenos";
            this.btnmenos.Size = new System.Drawing.Size(32, 31);
            this.btnmenos.TabIndex = 3;
            this.btnmenos.Text = "-";
            this.btnmenos.UseVisualStyleBackColor = true;
            this.btnmenos.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnmultiplicar
            // 
            this.btnmultiplicar.Location = new System.Drawing.Point(350, 139);
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.Size = new System.Drawing.Size(32, 31);
            this.btnmultiplicar.TabIndex = 4;
            this.btnmultiplicar.Text = "X";
            this.btnmultiplicar.UseVisualStyleBackColor = true;
            this.btnmultiplicar.Click += new System.EventHandler(this.btnmultiplicar_Click);
            // 
            // btndividir
            // 
            this.btndividir.Location = new System.Drawing.Point(388, 139);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(30, 31);
            this.btndividir.TabIndex = 5;
            this.btndividir.Text = "/";
            this.btndividir.UseVisualStyleBackColor = true;
            this.btndividir.Click += new System.EventHandler(this.btndividir_Click);
            // 
            // labelsigno
            // 
            this.labelsigno.AutoSize = true;
            this.labelsigno.Location = new System.Drawing.Point(331, 115);
            this.labelsigno.Name = "labelsigno";
            this.labelsigno.Size = new System.Drawing.Size(0, 13);
            this.labelsigno.TabIndex = 6;
            // 
            // igual
            // 
            this.igual.AutoSize = true;
            this.igual.Location = new System.Drawing.Point(408, 115);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(13, 13);
            this.igual.TabIndex = 7;
            this.igual.Text = "=";
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(427, 112);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(37, 20);
            this.resultado.TabIndex = 8;
            // 
            // ejer5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.labelsigno);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.btnmultiplicar);
            this.Controls.Add(this.btnmenos);
            this.Controls.Add(this.btnmas);
            this.Controls.Add(this.dato2);
            this.Controls.Add(this.dato1);
            this.Name = "ejer5";
            this.Text = "ejer5";
            this.Load += new System.EventHandler(this.ejer5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dato1;
        private System.Windows.Forms.TextBox dato2;
        private System.Windows.Forms.Button btnmas;
        private System.Windows.Forms.Button btnmenos;
        private System.Windows.Forms.Button btnmultiplicar;
        private System.Windows.Forms.Button btndividir;
        private System.Windows.Forms.Label labelsigno;
        private System.Windows.Forms.Label igual;
        private System.Windows.Forms.TextBox resultado;
    }
}