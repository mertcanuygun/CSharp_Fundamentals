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
            this.btn_circleCalc = new System.Windows.Forms.Button();
            this.txt_radius = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_area = new System.Windows.Forms.Label();
            this.lbl_perimeter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_calcNumberOfTerms = new System.Windows.Forms.Button();
            this.txt_commonDiff = new System.Windows.Forms.TextBox();
            this.txt_lastTerm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_firstTerm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_circleCalc
            // 
            this.btn_circleCalc.Location = new System.Drawing.Point(290, 149);
            this.btn_circleCalc.Name = "btn_circleCalc";
            this.btn_circleCalc.Size = new System.Drawing.Size(112, 51);
            this.btn_circleCalc.TabIndex = 0;
            this.btn_circleCalc.Text = "Calculate";
            this.btn_circleCalc.UseVisualStyleBackColor = true;
            this.btn_circleCalc.Click += new System.EventHandler(this.btn_circleCalc_Click);
            // 
            // txt_radius
            // 
            this.txt_radius.Location = new System.Drawing.Point(216, 74);
            this.txt_radius.Name = "txt_radius";
            this.txt_radius.Size = new System.Drawing.Size(186, 31);
            this.txt_radius.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_area);
            this.groupBox1.Controls.Add(this.lbl_perimeter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_radius);
            this.groupBox1.Controls.Add(this.btn_circleCalc);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 251);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Circle Area And Perimeter";
            // 
            // lbl_area
            // 
            this.lbl_area.AutoSize = true;
            this.lbl_area.Location = new System.Drawing.Point(150, 175);
            this.lbl_area.Name = "lbl_area";
            this.lbl_area.Size = new System.Drawing.Size(0, 25);
            this.lbl_area.TabIndex = 7;
            // 
            // lbl_perimeter
            // 
            this.lbl_perimeter.AutoSize = true;
            this.lbl_perimeter.Location = new System.Drawing.Point(150, 134);
            this.lbl_perimeter.Name = "lbl_perimeter";
            this.lbl_perimeter.Size = new System.Drawing.Size(0, 25);
            this.lbl_perimeter.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Perimeter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input Radius";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_calcNumberOfTerms);
            this.groupBox2.Controls.Add(this.txt_commonDiff);
            this.groupBox2.Controls.Add(this.txt_lastTerm);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_firstTerm);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(460, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 250);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Number of Terms";
            // 
            // btn_calcNumberOfTerms
            // 
            this.btn_calcNumberOfTerms.Location = new System.Drawing.Point(267, 198);
            this.btn_calcNumberOfTerms.Name = "btn_calcNumberOfTerms";
            this.btn_calcNumberOfTerms.Size = new System.Drawing.Size(125, 39);
            this.btn_calcNumberOfTerms.TabIndex = 7;
            this.btn_calcNumberOfTerms.Text = "Calculate";
            this.btn_calcNumberOfTerms.UseVisualStyleBackColor = true;
            this.btn_calcNumberOfTerms.Click += new System.EventHandler(this.btn_calcNumberOfTerms_Click);
            // 
            // txt_commonDiff
            // 
            this.txt_commonDiff.Location = new System.Drawing.Point(247, 151);
            this.txt_commonDiff.Name = "txt_commonDiff";
            this.txt_commonDiff.Size = new System.Drawing.Size(162, 31);
            this.txt_commonDiff.TabIndex = 6;
            // 
            // txt_lastTerm
            // 
            this.txt_lastTerm.Location = new System.Drawing.Point(247, 101);
            this.txt_lastTerm.Name = "txt_lastTerm";
            this.txt_lastTerm.Size = new System.Drawing.Size(162, 31);
            this.txt_lastTerm.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Common Difference";
            // 
            // txt_firstTerm
            // 
            this.txt_firstTerm.Location = new System.Drawing.Point(247, 54);
            this.txt_firstTerm.Name = "txt_firstTerm";
            this.txt_firstTerm.Size = new System.Drawing.Size(162, 31);
            this.txt_firstTerm.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Last Term";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "First Term";
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

        private System.Windows.Forms.Button btn_circleCalc;
        private System.Windows.Forms.TextBox txt_radius;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_area;
        private System.Windows.Forms.Label lbl_perimeter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_calcNumberOfTerms;
        private System.Windows.Forms.TextBox txt_commonDiff;
        private System.Windows.Forms.TextBox txt_lastTerm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_firstTerm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}

