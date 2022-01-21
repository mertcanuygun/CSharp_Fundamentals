namespace _03_For_Loop
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
            this.btn_start = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_variable_1 = new System.Windows.Forms.TextBox();
            this.txt_variable_2 = new System.Windows.Forms.TextBox();
            this.btn_example2 = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(39, 413);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(454, 70);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(39, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(222, 354);
            this.listBox1.TabIndex = 1;
            this.listBox1.Tag = "";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(281, 38);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(212, 354);
            this.listBox2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_start);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 507);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Example 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox3);
            this.groupBox2.Controls.Add(this.btn_example2);
            this.groupBox2.Controls.Add(this.txt_variable_2);
            this.groupBox2.Controls.Add(this.txt_variable_1);
            this.groupBox2.Location = new System.Drawing.Point(569, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 507);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Example 2";
            // 
            // txt_variable_1
            // 
            this.txt_variable_1.Location = new System.Drawing.Point(43, 53);
            this.txt_variable_1.Name = "txt_variable_1";
            this.txt_variable_1.Size = new System.Drawing.Size(180, 31);
            this.txt_variable_1.TabIndex = 0;
            // 
            // txt_variable_2
            // 
            this.txt_variable_2.Location = new System.Drawing.Point(43, 115);
            this.txt_variable_2.Name = "txt_variable_2";
            this.txt_variable_2.Size = new System.Drawing.Size(180, 31);
            this.txt_variable_2.TabIndex = 1;
            // 
            // btn_example2
            // 
            this.btn_example2.Location = new System.Drawing.Point(259, 53);
            this.btn_example2.Name = "btn_example2";
            this.btn_example2.Size = new System.Drawing.Size(139, 93);
            this.btn_example2.TabIndex = 3;
            this.btn_example2.Text = "Go!";
            this.btn_example2.UseVisualStyleBackColor = true;
            this.btn_example2.Click += new System.EventHandler(this.btn_example2_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 25;
            this.listBox3.Location = new System.Drawing.Point(43, 175);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(355, 304);
            this.listBox3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 726);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_example2;
        private System.Windows.Forms.TextBox txt_variable_2;
        private System.Windows.Forms.TextBox txt_variable_1;
        private System.Windows.Forms.ListBox listBox3;
    }
}

