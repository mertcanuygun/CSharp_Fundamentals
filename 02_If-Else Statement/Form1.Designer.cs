namespace _02_If_Else_Statement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_exchangeCalc = new System.Windows.Forms.ComboBox();
            this.btn_exchangecalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_exchangeAmount = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_exchangeAmount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_exchangecalc);
            this.groupBox1.Controls.Add(this.cmb_exchangeCalc);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exchange Rate Calculator";
            // 
            // cmb_exchangeCalc
            // 
            this.cmb_exchangeCalc.FormattingEnabled = true;
            this.cmb_exchangeCalc.Items.AddRange(new object[] {
            "Dollar",
            "Euro",
            "Pound",
            "Yen",
            "Swedish Krona",
            "Ruble",
            "Franc"});
            this.cmb_exchangeCalc.Location = new System.Drawing.Point(158, 38);
            this.cmb_exchangeCalc.Name = "cmb_exchangeCalc";
            this.cmb_exchangeCalc.Size = new System.Drawing.Size(191, 33);
            this.cmb_exchangeCalc.TabIndex = 0;
            // 
            // btn_exchangecalc
            // 
            this.btn_exchangecalc.Location = new System.Drawing.Point(218, 155);
            this.btn_exchangecalc.Name = "btn_exchangecalc";
            this.btn_exchangecalc.Size = new System.Drawing.Size(131, 38);
            this.btn_exchangecalc.TabIndex = 1;
            this.btn_exchangecalc.Text = "Calculate";
            this.btn_exchangecalc.UseVisualStyleBackColor = true;
            this.btn_exchangecalc.Click += new System.EventHandler(this.btn_exchangecalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Currency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount (₺)";
            // 
            // txt_exchangeAmount
            // 
            this.txt_exchangeAmount.Location = new System.Drawing.Point(158, 98);
            this.txt_exchangeAmount.Name = "txt_exchangeAmount";
            this.txt_exchangeAmount.Size = new System.Drawing.Size(191, 31);
            this.txt_exchangeAmount.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_exchangeAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exchangecalc;
        private System.Windows.Forms.ComboBox cmb_exchangeCalc;
    }
}

