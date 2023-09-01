namespace tickium
{
    partial class booking
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
            panel3 = new Panel();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button3 = new Button();
            label3 = new Label();
            panel4 = new Panel();
            comboBox2 = new ComboBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Location = new Point(0, 188);
            panel3.Name = "panel3";
            panel3.Size = new Size(228, 1);
            panel3.TabIndex = 14;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 214);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(216, 23);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(352, 352);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 16;
            button1.Text = "Checkout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(384, 407);
            button3.Name = "button3";
            button3.Size = new Size(58, 31);
            button3.TabIndex = 17;
            button3.Text = "back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Arial", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(590, 158);
            label3.Name = "label3";
            label3.Size = new Size(192, 27);
            label3.TabIndex = 18;
            label3.Text = "Choose Quantity";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.HotTrack;
            panel4.Location = new Point(572, 188);
            panel4.Name = "panel4";
            panel4.Size = new Size(228, 1);
            panel4.TabIndex = 19;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(572, 214);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(216, 23);
            comboBox2.TabIndex = 20;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._8d1a7d3a977546098f39115c1faeed4d2;
            pictureBox1.Location = new Point(329, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 103);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Arial", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(0, 158);
            label1.Name = "label1";
            label1.Size = new Size(198, 27);
            label1.TabIndex = 2;
            label1.Text = "Choose Category";
            // 
            // booking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(panel4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "booking";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel3;
        private ComboBox comboBox1;
        private Button button1;
        private Button button3;
        private Label label3;
        private Panel panel4;
        private ComboBox comboBox2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
    }
}