namespace WindowsFormsApplication2
{
    partial class start
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
            this.StartButton = new System.Windows.Forms.Button();
            this.Length = new System.Windows.Forms.Label();
            this.Width = new System.Windows.Forms.Label();
            this.NoOfBomb = new System.Windows.Forms.Label();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(330, 228);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(114, 45);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Length
            // 
            this.Length.AutoSize = true;
            this.Length.Location = new System.Drawing.Point(23, 75);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(56, 17);
            this.Length.TabIndex = 1;
            this.Length.Text = "Length:";
            this.Length.Click += new System.EventHandler(this.label1_Click);
            // 
            // Width
            // 
            this.Width.AutoSize = true;
            this.Width.Location = new System.Drawing.Point(23, 124);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(48, 17);
            this.Width.TabIndex = 2;
            this.Width.Text = "Width:";
            // 
            // NoOfBomb
            // 
            this.NoOfBomb.AutoSize = true;
            this.NoOfBomb.Location = new System.Drawing.Point(23, 172);
            this.NoOfBomb.Name = "NoOfBomb";
            this.NoOfBomb.Size = new System.Drawing.Size(125, 17);
            this.NoOfBomb.TabIndex = 3;
            this.NoOfBomb.Text = "Number of Bombs:";
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(228, 75);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(100, 22);
            this.LengthTextBox.TabIndex = 4;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(228, 124);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 22);
            this.widthTextBox.TabIndex = 5;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(228, 167);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 22);
            this.numberTextBox.TabIndex = 6;
            this.numberTextBox.TextChanged += new System.EventHandler(this.numberTextBox_TextChanged);
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 343);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.LengthTextBox);
            this.Controls.Add(this.NoOfBomb);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.StartButton);
            this.Name = "start";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label Length;
        private System.Windows.Forms.Label Width;
        private System.Windows.Forms.Label NoOfBomb;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
    }
}

