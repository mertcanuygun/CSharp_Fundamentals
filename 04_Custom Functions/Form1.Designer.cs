namespace _04_Custom_Functions
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_RollDice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_firstGuess = new System.Windows.Forms.TextBox();
            this.txt_secondGuess = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_secondGuess);
            this.groupBox1.Controls.Add(this.txt_firstGuess);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_RollDice);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 356);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Roll Dice";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(305, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(106, 79);
            this.listBox1.TabIndex = 1;
            // 
            // btn_RollDice
            // 
            this.btn_RollDice.Location = new System.Drawing.Point(20, 165);
            this.btn_RollDice.Name = "btn_RollDice";
            this.btn_RollDice.Size = new System.Drawing.Size(391, 120);
            this.btn_RollDice.TabIndex = 0;
            this.btn_RollDice.Text = "Roll Dice";
            this.btn_RollDice.UseVisualStyleBackColor = true;
            this.btn_RollDice.Click += new System.EventHandler(this.btn_RollDice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Guess";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Second Guess";
            // 
            // txt_firstGuess
            // 
            this.txt_firstGuess.Location = new System.Drawing.Point(174, 64);
            this.txt_firstGuess.Name = "txt_firstGuess";
            this.txt_firstGuess.Size = new System.Drawing.Size(115, 31);
            this.txt_firstGuess.TabIndex = 4;
            // 
            // txt_secondGuess
            // 
            this.txt_secondGuess.Location = new System.Drawing.Point(174, 112);
            this.txt_secondGuess.Name = "txt_secondGuess";
            this.txt_secondGuess.Size = new System.Drawing.Size(115, 31);
            this.txt_secondGuess.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 614);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_RollDice;
        private System.Windows.Forms.TextBox txt_secondGuess;
        private System.Windows.Forms.TextBox txt_firstGuess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

