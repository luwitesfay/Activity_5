namespace Activity_6
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
            this.FileContentDisplay = new System.Windows.Forms.TextBox();
            this.firstWord = new System.Windows.Forms.TextBox();
            this.lastWord = new System.Windows.Forms.TextBox();
            this.LongestWord = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(657, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "File Upload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FileContentDisplay
            // 
            this.FileContentDisplay.Location = new System.Drawing.Point(38, 181);
            this.FileContentDisplay.Margin = new System.Windows.Forms.Padding(10);
            this.FileContentDisplay.Name = "FileContentDisplay";
            this.FileContentDisplay.Size = new System.Drawing.Size(622, 39);
            this.FileContentDisplay.TabIndex = 1;
            this.FileContentDisplay.TextChanged += new System.EventHandler(this.FileContentDisplay_TextChanged);
            // 
            // firstWord
            // 
            this.firstWord.Location = new System.Drawing.Point(541, 519);
            this.firstWord.Name = "firstWord";
            this.firstWord.Size = new System.Drawing.Size(431, 39);
            this.firstWord.TabIndex = 2;
            // 
            // lastWord
            // 
            this.lastWord.Location = new System.Drawing.Point(541, 618);
            this.lastWord.Name = "lastWord";
            this.lastWord.Size = new System.Drawing.Size(431, 39);
            this.lastWord.TabIndex = 3;
            // 
            // LongestWord
            // 
            this.LongestWord.Location = new System.Drawing.Point(541, 697);
            this.LongestWord.Name = "LongestWord";
            this.LongestWord.Size = new System.Drawing.Size(431, 39);
            this.LongestWord.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(541, 764);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(431, 39);
            this.textBox5.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(270, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Word find/ Vowel Count Tool";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "The first word in the file is:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 625);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 32);
            this.label3.TabIndex = 8;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 697);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 32);
            this.label4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 774);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 32);
            this.label5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(38, 600);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(381, 36);
            this.label6.TabIndex = 11;
            this.label6.Text = "The last word in the file is:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(38, 690);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(429, 36);
            this.label7.TabIndex = 12;
            this.label7.Text = "The longest word in the file is:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(38, 767);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(479, 36);
            this.label8.TabIndex = 13;
            this.label8.Text = "The word with the most vowels is:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 874);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.LongestWord);
            this.Controls.Add(this.lastWord);
            this.Controls.Add(this.firstWord);
            this.Controls.Add(this.FileContentDisplay);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox FileContentDisplay;
        private TextBox firstWord;
        private TextBox lastWord;
        private TextBox LongestWord;
        private TextBox textBox5;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}