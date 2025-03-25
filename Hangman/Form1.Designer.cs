namespace Hangman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            hangmanPic = new PictureBox();
            startButton = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            guessButton = new Button();
            inputText = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)hangmanPic).BeginInit();
            SuspendLayout();
            // 
            // hangmanPic
            // 
            hangmanPic.BackgroundImage = (Image)resources.GetObject("hangmanPic.BackgroundImage");
            hangmanPic.Image = (Image)resources.GetObject("hangmanPic.Image");
            hangmanPic.Location = new Point(26, 12);
            hangmanPic.Name = "hangmanPic";
            hangmanPic.Size = new Size(313, 396);
            hangmanPic.TabIndex = 0;
            hangmanPic.TabStop = false;
            hangmanPic.Click += hangmanPic_Click;
            // 
            // startButton
            // 
            startButton.BackColor = Color.Green;
            startButton.Font = new Font("Segoe UI", 20F);
            startButton.Location = new Point(374, 12);
            startButton.Name = "startButton";
            startButton.Size = new Size(183, 108);
            startButton.TabIndex = 1;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Window;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 20F);
            richTextBox1.Location = new Point(374, 143);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.RightToLeft = RightToLeft.No;
            richTextBox1.Size = new Size(391, 106);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Enabled = false;
            richTextBox2.Font = new Font("Segoe UI", 10.1F, FontStyle.Bold);
            richTextBox2.Location = new Point(373, 286);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(230, 85);
            richTextBox2.TabIndex = 3;
            richTextBox2.Text = "Enter a letter and Click Guess ";
            // 
            // guessButton
            // 
            guessButton.BackColor = Color.SkyBlue;
            guessButton.Enabled = false;
            guessButton.Font = new Font("Segoe UI", 16F);
            guessButton.Location = new Point(614, 12);
            guessButton.Name = "guessButton";
            guessButton.Size = new Size(151, 108);
            guessButton.TabIndex = 5;
            guessButton.Text = "Guess";
            guessButton.UseVisualStyleBackColor = false;
            guessButton.Click += guessButton_Click;
            // 
            // inputText
            // 
            inputText.AccessibleName = "guessButton";
            inputText.AccessibleRole = AccessibleRole.PushButton;
            inputText.Enabled = false;
            inputText.Font = new Font("Segoe UI", 20F);
            inputText.Location = new Point(668, 291);
            inputText.Name = "inputText";
            inputText.Size = new Size(97, 80);
            inputText.TabIndex = 6;
            inputText.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 460);
            Controls.Add(inputText);
            Controls.Add(guessButton);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(startButton);
            Controls.Add(hangmanPic);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Hangman";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)hangmanPic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox hangmanPic;
        private Button startButton;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button guessButton;
        private RichTextBox inputText;
    }
}
