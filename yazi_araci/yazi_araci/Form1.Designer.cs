
namespace yazi_araci
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.orange = new System.Windows.Forms.Button();
            this.kirmizi = new System.Windows.Forms.Button();
            this.sari = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(783, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(27, 119);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(566, 115);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(475, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yön";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(281, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "A+";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(309, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "A-";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(27, 56);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 25);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Kalın";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.checkBox2.Location = new System.Drawing.Point(92, 56);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(89, 25);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Altı Çizili";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.checkBox3.Location = new System.Drawing.Point(178, 56);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(63, 25);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Italik";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(410, 56);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 25);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sol";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(475, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 25);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Orta";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton3.Location = new System.Drawing.Point(540, 56);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(54, 25);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Sağ";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Fuchsia;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(129, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 38);
            this.button2.TabIndex = 12;
            this.button2.Text = "KOPYALA";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // orange
            // 
            this.orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orange.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orange.Location = new System.Drawing.Point(27, 257);
            this.orange.Name = "orange";
            this.orange.Size = new System.Drawing.Size(118, 36);
            this.orange.TabIndex = 13;
            this.orange.UseVisualStyleBackColor = false;
            this.orange.Click += new System.EventHandler(this.orange_Click);
            // 
            // kirmizi
            // 
            this.kirmizi.BackColor = System.Drawing.Color.Red;
            this.kirmizi.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kirmizi.Location = new System.Drawing.Point(221, 257);
            this.kirmizi.Name = "kirmizi";
            this.kirmizi.Size = new System.Drawing.Size(114, 36);
            this.kirmizi.TabIndex = 14;
            this.kirmizi.UseVisualStyleBackColor = false;
            this.kirmizi.Click += new System.EventHandler(this.kirmizi_Click);
            // 
            // sari
            // 
            this.sari.BackColor = System.Drawing.Color.Yellow;
            this.sari.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sari.Location = new System.Drawing.Point(410, 257);
            this.sari.Name = "sari";
            this.sari.Size = new System.Drawing.Size(101, 36);
            this.sari.TabIndex = 15;
            this.sari.UseVisualStyleBackColor = false;
            this.sari.Click += new System.EventHandler(this.sari_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Fuchsia;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(333, 310);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 38);
            this.button6.TabIndex = 16;
            this.button6.Text = "TEMİZLE";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(639, 376);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.sari);
            this.Controls.Add(this.kirmizi);
            this.Controls.Add(this.orange);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button orange;
        private System.Windows.Forms.Button kirmizi;
        private System.Windows.Forms.Button sari;
        private System.Windows.Forms.Button button6;
    }
}

