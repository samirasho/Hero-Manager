namespace Hero
{
    partial class Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            textBox1 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 286);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(136, 286);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "CHAT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 95);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(199, 184);
            listBox1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._6FhfDE;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(237, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(921, 573);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Chat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 639);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Chat";
            Text = "Chat";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private ListBox listBox1;
        private PictureBox pictureBox1;
    }
}