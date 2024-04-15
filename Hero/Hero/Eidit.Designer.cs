namespace Hero
{
    partial class Eidit
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
            panel1 = new Panel();
            label6 = new Label();
            comboBox1 = new ComboBox();
            trackBar2 = new TrackBar();
            trackBar1 = new TrackBar();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            button2 = new Button();
            saveButton = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            textBox2 = new TextBox();
            bt = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(trackBar2);
            panel1.Controls.Add(trackBar1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(217, 386);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 106);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 9;
            label6.Text = "Klasse";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Barbarian", "Wizard" });
            comboBox1.Location = new Point(37, 128);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(20, 275);
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(153, 45);
            trackBar2.TabIndex = 7;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(20, 185);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(133, 45);
            trackBar1.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(32, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 246);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 3;
            label4.Text = "ATP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 164);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 2;
            label3.Text = "HP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 45);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SWScrpc", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(57, 2);
            label1.Name = "label1";
            label1.Size = new Size(66, 34);
            label1.TabIndex = 0;
            label1.Text = "Spiel";
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(227, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 386);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SWScrpc", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(85, 10);
            label5.Name = "label5";
            label5.Size = new Size(51, 23);
            label5.TabIndex = 2;
            label5.Text = "Name";
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = Properties.Resources.Barbarian;
            pictureBox2.Image = Properties.Resources.Barbarian;
            pictureBox2.InitialImage = Properties.Resources.Barbarian;
            pictureBox2.Location = new Point(49, 185);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(124, 178);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Info;
            pictureBox1.ErrorImage = Properties.Resources.Wizard;
            pictureBox1.Image = Properties.Resources.Wizard;
            pictureBox1.InitialImage = Properties.Resources.Wizard;
            pictureBox1.Location = new Point(11, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(saveButton);
            panel3.Controls.Add(listBox1);
            panel3.Location = new Point(453, 34);
            panel3.Name = "panel3";
            panel3.Size = new Size(227, 386);
            panel3.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Location = new Point(138, 317);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = SystemColors.Info;
            saveButton.Location = new Point(41, 317);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 1;
            saveButton.Text = "UPDATE";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Info;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(27, 10);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(186, 274);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.BackColor = SystemColors.Info;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(700, 68);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(225, 259);
            listBox2.TabIndex = 3;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Info;
            textBox2.Location = new Point(700, 350);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(128, 23);
            textBox2.TabIndex = 4;
            // 
            // bt
            // 
            bt.BackColor = SystemColors.Info;
            bt.Location = new Point(850, 350);
            bt.Name = "bt";
            bt.Size = new Size(75, 23);
            bt.TabIndex = 5;
            bt.Text = "Chat";
            bt.UseVisualStyleBackColor = false;
            bt.Click += button1_Click;
            // 
            // Eidit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(954, 603);
            Controls.Add(bt);
            Controls.Add(textBox2);
            Controls.Add(listBox2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Eidit";
            Text = "Eidit";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TrackBar trackBar1;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TrackBar trackBar2;
        private Panel panel2;
        private Panel panel3;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private Button saveButton;
        private Button button2;
        private ListBox listBox2;
        private TextBox textBox2;
        private Button bt;
    }
}