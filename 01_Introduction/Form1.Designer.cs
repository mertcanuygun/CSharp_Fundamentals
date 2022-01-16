namespace _01_Introduction
{
    partial class Form1
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
            this.btn_dairehesapla = new System.Windows.Forms.Button();
            this.txt_yaricap = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_cevresi = new System.Windows.Forms.Label();
            this.lbl_alani = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ilkterim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sonterim = new System.Windows.Forms.TextBox();
            this.txt_artismikt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_dairehesapla
            // 
            this.btn_dairehesapla.Location = new System.Drawing.Point(290, 149);
            this.btn_dairehesapla.Name = "btn_dairehesapla";
            this.btn_dairehesapla.Size = new System.Drawing.Size(112, 51);
            this.btn_dairehesapla.TabIndex = 0;
            this.btn_dairehesapla.Text = "Hesapla";
            this.btn_dairehesapla.UseVisualStyleBackColor = true;
            this.btn_dairehesapla.Click += new System.EventHandler(this.btn_dairehesapla_Click);
            // 
            // txt_yaricap
            // 
            this.txt_yaricap.Location = new System.Drawing.Point(216, 74);
            this.txt_yaricap.Name = "txt_yaricap";
            this.txt_yaricap.Size = new System.Drawing.Size(186, 31);
            this.txt_yaricap.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_alani);
            this.groupBox1.Controls.Add(this.lbl_cevresi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_yaricap);
            this.groupBox1.Controls.Add(this.btn_dairehesapla);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 251);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daire Çevre ve Alan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yarıçap Giriniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Çevresi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alanı";
            // 
            // lbl_cevresi
            // 
            this.lbl_cevresi.AutoSize = true;
            this.lbl_cevresi.Location = new System.Drawing.Point(150, 134);
            this.lbl_cevresi.Name = "lbl_cevresi";
            this.lbl_cevresi.Size = new System.Drawing.Size(0, 25);
            this.lbl_cevresi.TabIndex = 6;
            // 
            // lbl_alani
            // 
            this.lbl_alani.AutoSize = true;
            this.lbl_alani.Location = new System.Drawing.Point(150, 175);
            this.lbl_alani.Name = "lbl_alani";
            this.lbl_alani.Size = new System.Drawing.Size(0, 25);
            this.lbl_alani.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txt_artismikt);
            this.groupBox2.Controls.Add(this.txt_sonterim);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_ilkterim);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(460, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 250);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Terim Sayısı Hesaplama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "İlk Terim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Son Terim";
            // 
            // txt_ilkterim
            // 
            this.txt_ilkterim.Location = new System.Drawing.Point(208, 54);
            this.txt_ilkterim.Name = "txt_ilkterim";
            this.txt_ilkterim.Size = new System.Drawing.Size(162, 31);
            this.txt_ilkterim.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Artış Miktarı";
            // 
            // txt_sonterim
            // 
            this.txt_sonterim.Location = new System.Drawing.Point(208, 101);
            this.txt_sonterim.Name = "txt_sonterim";
            this.txt_sonterim.Size = new System.Drawing.Size(162, 31);
            this.txt_sonterim.TabIndex = 5;
            // 
            // txt_artismikt
            // 
            this.txt_artismikt.Location = new System.Drawing.Point(208, 148);
            this.txt_artismikt.Name = "txt_artismikt";
            this.txt_artismikt.Size = new System.Drawing.Size(162, 31);
            this.txt_artismikt.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 597);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_dairehesapla;
        private System.Windows.Forms.TextBox txt_yaricap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_alani;
        private System.Windows.Forms.Label lbl_cevresi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_artismikt;
        private System.Windows.Forms.TextBox txt_sonterim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ilkterim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}

