namespace WindowsFormsApp6
{
    partial class ejer3
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
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnsali = new System.Windows.Forms.Button();
            this.milimetros = new System.Windows.Forms.RadioButton();
            this.centimetros = new System.Windows.Forms.RadioButton();
            this.decimetros = new System.Windows.Forms.RadioButton();
            this.kilometros = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmetros = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnconvertir
            // 
            this.btnconvertir.Location = new System.Drawing.Point(235, 211);
            this.btnconvertir.Name = "btnconvertir";
            this.btnconvertir.Size = new System.Drawing.Size(75, 76);
            this.btnconvertir.TabIndex = 0;
            this.btnconvertir.Text = "Convertir";
            this.btnconvertir.UseVisualStyleBackColor = true;
            this.btnconvertir.Click += new System.EventHandler(this.btnconvertir_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(316, 211);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(77, 76);
            this.btnnuevo.TabIndex = 1;
            this.btnnuevo.Text = "Nuevo Calculo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnsali
            // 
            this.btnsali.Location = new System.Drawing.Point(399, 209);
            this.btnsali.Name = "btnsali";
            this.btnsali.Size = new System.Drawing.Size(75, 78);
            this.btnsali.TabIndex = 2;
            this.btnsali.Text = "Salir";
            this.btnsali.UseVisualStyleBackColor = true;
            this.btnsali.Click += new System.EventHandler(this.button3_Click);
            // 
            // milimetros
            // 
            this.milimetros.AutoSize = true;
            this.milimetros.Location = new System.Drawing.Point(235, 119);
            this.milimetros.Name = "milimetros";
            this.milimetros.Size = new System.Drawing.Size(71, 17);
            this.milimetros.TabIndex = 3;
            this.milimetros.TabStop = true;
            this.milimetros.Text = "Milimetros";
            this.milimetros.UseVisualStyleBackColor = true;
            // 
            // centimetros
            // 
            this.centimetros.AutoSize = true;
            this.centimetros.Location = new System.Drawing.Point(235, 142);
            this.centimetros.Name = "centimetros";
            this.centimetros.Size = new System.Drawing.Size(80, 17);
            this.centimetros.TabIndex = 4;
            this.centimetros.TabStop = true;
            this.centimetros.Text = "Centimetros";
            this.centimetros.UseVisualStyleBackColor = true;
            // 
            // decimetros
            // 
            this.decimetros.AutoSize = true;
            this.decimetros.Location = new System.Drawing.Point(235, 165);
            this.decimetros.Name = "decimetros";
            this.decimetros.Size = new System.Drawing.Size(78, 17);
            this.decimetros.TabIndex = 5;
            this.decimetros.TabStop = true;
            this.decimetros.Text = "Decimetros";
            this.decimetros.UseVisualStyleBackColor = true;
            // 
            // kilometros
            // 
            this.kilometros.AutoSize = true;
            this.kilometros.Location = new System.Drawing.Point(235, 186);
            this.kilometros.Name = "kilometros";
            this.kilometros.Size = new System.Drawing.Size(73, 17);
            this.kilometros.TabIndex = 6;
            this.kilometros.TabStop = true;
            this.kilometros.Text = "Kilometros";
            this.kilometros.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cantidad de metros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Resultado";
            // 
            // txtmetros
            // 
            this.txtmetros.Location = new System.Drawing.Point(277, 80);
            this.txtmetros.Name = "txtmetros";
            this.txtmetros.Size = new System.Drawing.Size(100, 20);
            this.txtmetros.TabIndex = 9;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(360, 135);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(100, 20);
            this.txtresultado.TabIndex = 10;
            // 
            // ejer3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtmetros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kilometros);
            this.Controls.Add(this.decimetros);
            this.Controls.Add(this.centimetros);
            this.Controls.Add(this.milimetros);
            this.Controls.Add(this.btnsali);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnconvertir);
            this.Name = "ejer3";
            this.Text = "ejer3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconvertir;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnsali;
        private System.Windows.Forms.RadioButton milimetros;
        private System.Windows.Forms.RadioButton centimetros;
        private System.Windows.Forms.RadioButton decimetros;
        private System.Windows.Forms.RadioButton kilometros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmetros;
        private System.Windows.Forms.TextBox txtresultado;
    }
}