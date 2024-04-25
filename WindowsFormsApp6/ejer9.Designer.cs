namespace WindowsFormsApp6
{
    partial class ejer9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejer9));
            this.radiocremas = new System.Windows.Forms.RadioButton();
            this.radioensaladas = new System.Windows.Forms.RadioButton();
            this.radioempanadas = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboplatosprinci = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblprecio2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combosegundoplato = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radiocremas
            // 
            this.radiocremas.AutoSize = true;
            this.radiocremas.BackColor = System.Drawing.SystemColors.InfoText;
            this.radiocremas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radiocremas.Location = new System.Drawing.Point(89, 102);
            this.radiocremas.Name = "radiocremas";
            this.radiocremas.Size = new System.Drawing.Size(60, 17);
            this.radiocremas.TabIndex = 0;
            this.radiocremas.TabStop = true;
            this.radiocremas.Text = "Cremas";
            this.radiocremas.UseVisualStyleBackColor = false;
            this.radiocremas.CheckedChanged += new System.EventHandler(this.radiocremas_CheckedChanged);
            // 
            // radioensaladas
            // 
            this.radioensaladas.AutoSize = true;
            this.radioensaladas.BackColor = System.Drawing.SystemColors.InfoText;
            this.radioensaladas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioensaladas.Location = new System.Drawing.Point(89, 125);
            this.radioensaladas.Name = "radioensaladas";
            this.radioensaladas.Size = new System.Drawing.Size(74, 17);
            this.radioensaladas.TabIndex = 1;
            this.radioensaladas.TabStop = true;
            this.radioensaladas.Text = "Ensaladas";
            this.radioensaladas.UseVisualStyleBackColor = false;
            this.radioensaladas.CheckedChanged += new System.EventHandler(this.radioensaladas_CheckedChanged);
            // 
            // radioempanadas
            // 
            this.radioempanadas.AutoSize = true;
            this.radioempanadas.BackColor = System.Drawing.SystemColors.InfoText;
            this.radioempanadas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioempanadas.Location = new System.Drawing.Point(89, 148);
            this.radioempanadas.Name = "radioempanadas";
            this.radioempanadas.Size = new System.Drawing.Size(81, 17);
            this.radioempanadas.TabIndex = 2;
            this.radioempanadas.TabStop = true;
            this.radioempanadas.Text = "Empanadas";
            this.radioempanadas.UseVisualStyleBackColor = false;
            this.radioempanadas.CheckedChanged += new System.EventHandler(this.radioempanadas_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(84, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Plato Principal";
            // 
            // comboplatosprinci
            // 
            this.comboplatosprinci.BackColor = System.Drawing.SystemColors.InfoText;
            this.comboplatosprinci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboplatosprinci.ForeColor = System.Drawing.SystemColors.Info;
            this.comboplatosprinci.FormattingEnabled = true;
            this.comboplatosprinci.Location = new System.Drawing.Point(193, 121);
            this.comboplatosprinci.Name = "comboplatosprinci";
            this.comboplatosprinci.Size = new System.Drawing.Size(121, 21);
            this.comboplatosprinci.TabIndex = 4;
            this.comboplatosprinci.SelectedIndexChanged += new System.EventHandler(this.comboplatosprinci_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(84, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio:";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblprecio.Location = new System.Drawing.Point(188, 198);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(0, 25);
            this.lblprecio.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(248, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "€";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(450, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "€";
            this.label4.Visible = false;
            // 
            // lblprecio2
            // 
            this.lblprecio2.AutoSize = true;
            this.lblprecio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblprecio2.Location = new System.Drawing.Point(390, 303);
            this.lblprecio2.Name = "lblprecio2";
            this.lblprecio2.Size = new System.Drawing.Size(0, 25);
            this.lblprecio2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(286, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Precio:";
            // 
            // combosegundoplato
            // 
            this.combosegundoplato.BackColor = System.Drawing.SystemColors.InfoText;
            this.combosegundoplato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combosegundoplato.ForeColor = System.Drawing.SystemColors.Info;
            this.combosegundoplato.FormattingEnabled = true;
            this.combosegundoplato.Location = new System.Drawing.Point(395, 226);
            this.combosegundoplato.Name = "combosegundoplato";
            this.combosegundoplato.Size = new System.Drawing.Size(121, 21);
            this.combosegundoplato.TabIndex = 12;
            this.combosegundoplato.SelectedIndexChanged += new System.EventHandler(this.combosegundoplato_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(286, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Segundo Plato";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.SystemColors.InfoText;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButton1.Location = new System.Drawing.Point(291, 253);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Pasta";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.SystemColors.InfoText;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButton2.Location = new System.Drawing.Point(291, 230);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Carne";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.SystemColors.InfoText;
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButton3.Location = new System.Drawing.Point(291, 207);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(67, 17);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Pescado";
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // ejer9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblprecio2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combosegundoplato);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboplatosprinci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioempanadas);
            this.Controls.Add(this.radioensaladas);
            this.Controls.Add(this.radiocremas);
            this.Name = "ejer9";
            this.Text = "ejer9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radiocremas;
        private System.Windows.Forms.RadioButton radioensaladas;
        private System.Windows.Forms.RadioButton radioempanadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboplatosprinci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblprecio2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combosegundoplato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}