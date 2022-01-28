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
            this.grp_rolldice = new System.Windows.Forms.GroupBox();
            this.txt_secondGuess = new System.Windows.Forms.TextBox();
            this.txt_firstGuess = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_RollDice = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_bet = new System.Windows.Forms.TextBox();
            this.grp_rolldice.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_rolldice
            // 
            this.grp_rolldice.Controls.Add(this.txt_bet);
            this.grp_rolldice.Controls.Add(this.label3);
            this.grp_rolldice.Controls.Add(this.txt_secondGuess);
            this.grp_rolldice.Controls.Add(this.txt_firstGuess);
            this.grp_rolldice.Controls.Add(this.label2);
            this.grp_rolldice.Controls.Add(this.label1);
            this.grp_rolldice.Controls.Add(this.btn_RollDice);
            this.grp_rolldice.Controls.Add(this.listBox1);
            this.grp_rolldice.Location = new System.Drawing.Point(13, 13);
            this.grp_rolldice.Name = "grp_rolldice";
            this.grp_rolldice.Size = new System.Drawing.Size(450, 356);
            this.grp_rolldice.TabIndex = 0;
            this.grp_rolldice.TabStop = false;
            this.grp_rolldice.Text = "Roll Dice";
            // 
            // txt_secondGuess
            // 
            this.txt_secondGuess.Location = new System.Drawing.Point(174, 112);
            this.txt_secondGuess.Name = "txt_secondGuess";
            this.txt_secondGuess.Size = new System.Drawing.Size(115, 31);
            this.txt_secondGuess.TabIndex = 5;
            // 
            // txt_firstGuess
            // 
            this.txt_firstGuess.Location = new System.Drawing.Point(174, 64);
            this.txt_firstGuess.Name = "txt_firstGuess";
            this.txt_firstGuess.Size = new System.Drawing.Size(115, 31);
            this.txt_firstGuess.TabIndex = 4;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Guess";
            // 
            // btn_RollDice
            // 
            this.btn_RollDice.Location = new System.Drawing.Point(20, 213);
            this.btn_RollDice.Name = "btn_RollDice";
            this.btn_RollDice.Size = new System.Drawing.Size(391, 120);
            this.btn_RollDice.TabIndex = 0;
            this.btn_RollDice.Text = "Roll Dice";
            this.btn_RollDice.UseVisualStyleBackColor = true;
            this.btn_RollDice.Click += new System.EventHandler(this.btn_RollDice_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(305, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(106, 129);
            this.listBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Your Bet";
            // 
            // txt_bet
            // 
            this.txt_bet.Location = new System.Drawing.Point(174, 162);
            this.txt_bet.Name = "txt_bet";
            this.txt_bet.Size = new System.Drawing.Size(115, 31);
            this.txt_bet.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 614);
            this.Controls.Add(this.grp_rolldice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grp_rolldice.ResumeLayout(false);
            this.grp_rolldice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_rolldice;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_RollDice;
        private System.Windows.Forms.TextBox txt_secondGuess;
        private System.Windows.Forms.TextBox txt_firstGuess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_bet;
        private System.Windows.Forms.Label label3;
    }
}

