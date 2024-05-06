namespace WindowsFormsApp6
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.radiocombo = new System.Windows.Forms.RadioButton();
            this.radiolistbox = new System.Windows.Forms.RadioButton();
            this.btncargar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(261, 197);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(261, 224);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(121, 95);
            this.listBox1.TabIndex = 1;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(261, 109);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 2;
            // 
            // radiocombo
            // 
            this.radiocombo.AutoSize = true;
            this.radiocombo.Location = new System.Drawing.Point(261, 136);
            this.radiocombo.Name = "radiocombo";
            this.radiocombo.Size = new System.Drawing.Size(116, 17);
            this.radiocombo.TabIndex = 3;
            this.radiocombo.TabStop = true;
            this.radiocombo.Text = "Añadir a combobox";
            this.radiocombo.UseVisualStyleBackColor = true;
            // 
            // radiolistbox
            // 
            this.radiolistbox.AutoSize = true;
            this.radiolistbox.Location = new System.Drawing.Point(261, 160);
            this.radiolistbox.Name = "radiolistbox";
            this.radiolistbox.Size = new System.Drawing.Size(96, 17);
            this.radiolistbox.TabIndex = 4;
            this.radiolistbox.TabStop = true;
            this.radiolistbox.Text = "Añadir a listbox";
            this.radiolistbox.UseVisualStyleBackColor = true;
            // 
            // btncargar
            // 
            this.btncargar.Location = new System.Drawing.Point(442, 105);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(75, 23);
            this.btncargar.TabIndex = 5;
            this.btncargar.Text = "Cargar";
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "C.Fichero";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(442, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "L.Fichero";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(539, 105);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(121, 95);
            this.listBox2.TabIndex = 8;
            this.listBox2.Visible = false;
            // 
            // ejer4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.radiolistbox);
            this.Controls.Add(this.radiocombo);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "ejer4";
            this.Text = "ejer4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.RadioButton radiocombo;
        private System.Windows.Forms.RadioButton radiolistbox;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox2;
    }
}