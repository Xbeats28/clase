namespace WindowsFormsApp6
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnmovernoche1 = new System.Windows.Forms.Button();
            this.btnmovernocchetodos = new System.Windows.Forms.Button();
            this.btnmovermañana1 = new System.Windows.Forms.Button();
            this.btnmovermañanatodos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboselector = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(105, 182);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 108);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(371, 182);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 108);
            this.listBox2.TabIndex = 1;
            // 
            // btnmovernoche1
            // 
            this.btnmovernoche1.Location = new System.Drawing.Point(273, 182);
            this.btnmovernoche1.Name = "btnmovernoche1";
            this.btnmovernoche1.Size = new System.Drawing.Size(75, 23);
            this.btnmovernoche1.TabIndex = 2;
            this.btnmovernoche1.Text = ">";
            this.btnmovernoche1.UseVisualStyleBackColor = true;
            this.btnmovernoche1.Click += new System.EventHandler(this.btnmovernoche1_Click);
            // 
            // btnmovernocchetodos
            // 
            this.btnmovernocchetodos.Location = new System.Drawing.Point(273, 211);
            this.btnmovernocchetodos.Name = "btnmovernocchetodos";
            this.btnmovernocchetodos.Size = new System.Drawing.Size(75, 23);
            this.btnmovernocchetodos.TabIndex = 3;
            this.btnmovernocchetodos.Text = ">>";
            this.btnmovernocchetodos.UseVisualStyleBackColor = true;
            this.btnmovernocchetodos.Click += new System.EventHandler(this.btnmovernocchetodos_Click);
            // 
            // btnmovermañana1
            // 
            this.btnmovermañana1.Location = new System.Drawing.Point(273, 240);
            this.btnmovermañana1.Name = "btnmovermañana1";
            this.btnmovermañana1.Size = new System.Drawing.Size(75, 23);
            this.btnmovermañana1.TabIndex = 4;
            this.btnmovermañana1.Text = "<";
            this.btnmovermañana1.UseVisualStyleBackColor = true;
            this.btnmovermañana1.Click += new System.EventHandler(this.btnmovermañana1_Click);
            // 
            // btnmovermañanatodos
            // 
            this.btnmovermañanatodos.Location = new System.Drawing.Point(273, 269);
            this.btnmovermañanatodos.Name = "btnmovermañanatodos";
            this.btnmovermañanatodos.Size = new System.Drawing.Size(75, 23);
            this.btnmovermañanatodos.TabIndex = 5;
            this.btnmovermañanatodos.Text = "<<";
            this.btnmovermañanatodos.UseVisualStyleBackColor = true;
            this.btnmovermañanatodos.Click += new System.EventHandler(this.btnmovermañanatodos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Turno de noche";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Turno de dia";
            // 
            // comboselector
            // 
            this.comboselector.FormattingEnabled = true;
            this.comboselector.Items.AddRange(new object[] {
            "Mañana",
            "Tarde"});
            this.comboselector.Location = new System.Drawing.Point(227, 105);
            this.comboselector.Name = "comboselector";
            this.comboselector.Size = new System.Drawing.Size(121, 21);
            this.comboselector.TabIndex = 8;
            this.comboselector.SelectedIndexChanged += new System.EventHandler(this.comboselector_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(227, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total dia:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(176, 311);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(49, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(442, 311);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(49, 20);
            this.textBox3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total noche:";
            // 
            // ejer5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboselector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmovermañanatodos);
            this.Controls.Add(this.btnmovermañana1);
            this.Controls.Add(this.btnmovernocchetodos);
            this.Controls.Add(this.btnmovernoche1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "ejer5";
            this.Text = "ejer5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnmovernoche1;
        private System.Windows.Forms.Button btnmovernocchetodos;
        private System.Windows.Forms.Button btnmovermañana1;
        private System.Windows.Forms.Button btnmovermañanatodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboselector;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
    }
}