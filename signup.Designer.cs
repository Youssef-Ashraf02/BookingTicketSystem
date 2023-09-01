namespace tickium
{
    partial class signup
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            firstname = new TextBox();
            label2 = new Label();
            lastname = new TextBox();
            label3 = new Label();
            gender = new ComboBox();
            label4 = new Label();
            email = new TextBox();
            label5 = new Label();
            password = new TextBox();
            button3 = new Button();
            securitylevel = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._8d1a7d3a977546098f39115c1faeed4d2;
            pictureBox1.Location = new Point(324, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 122);
            label1.Name = "label1";
            label1.Size = new Size(134, 29);
            label1.TabIndex = 4;
            label1.Text = "First name";
            // 
            // firstname
            // 
            firstname.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            firstname.Location = new Point(12, 153);
            firstname.Multiline = true;
            firstname.Name = "firstname";
            firstname.Size = new Size(265, 33);
            firstname.TabIndex = 8;
            firstname.TextChanged += txtusername_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(12, 218);
            label2.Name = "label2";
            label2.Size = new Size(131, 29);
            label2.TabIndex = 9;
            label2.Text = "Last name";
            // 
            // lastname
            // 
            lastname.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lastname.Location = new Point(12, 250);
            lastname.Multiline = true;
            lastname.Name = "lastname";
            lastname.Size = new Size(265, 33);
            lastname.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(12, 322);
            label3.Name = "label3";
            label3.Size = new Size(97, 29);
            label3.TabIndex = 11;
            label3.Text = "Gender";
            // 
            // gender
            // 
            gender.AutoCompleteCustomSource.AddRange(new string[] { "Male", "Female" });
            gender.FormattingEnabled = true;
            gender.Location = new Point(12, 354);
            gender.Name = "gender";
            gender.Size = new Size(170, 23);
            gender.TabIndex = 16;
            gender.SelectedIndexChanged += gender_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(488, 122);
            label4.Name = "label4";
            label4.Size = new Size(77, 29);
            label4.TabIndex = 17;
            label4.Text = "Email";
            // 
            // email
            // 
            email.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            email.Location = new Point(488, 154);
            email.Multiline = true;
            email.Name = "email";
            email.Size = new Size(265, 33);
            email.TabIndex = 18;
            email.TextChanged += email_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(488, 218);
            label5.Name = "label5";
            label5.Size = new Size(126, 29);
            label5.TabIndex = 19;
            label5.Text = "Password";
            // 
            // password
            // 
            password.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            password.Location = new Point(488, 259);
            password.Multiline = true;
            password.Name = "password";
            password.Size = new Size(265, 33);
            password.TabIndex = 20;
            password.TextChanged += textBox3_TextChanged;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.Font = new Font("Arial", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(504, 346);
            button3.Name = "button3";
            button3.Size = new Size(110, 31);
            button3.TabIndex = 21;
            button3.Text = "Sign up";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // securitylevel
            // 
            securitylevel.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            securitylevel.Location = new Point(699, 324);
            securitylevel.Multiline = true;
            securitylevel.Name = "securitylevel";
            securitylevel.Size = new Size(54, 10);
            securitylevel.TabIndex = 22;
            securitylevel.TextChanged += textBox1_TextChanged_1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(380, 407);
            button1.Name = "button1";
            button1.Size = new Size(58, 31);
            button1.TabIndex = 23;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(securitylevel);
            Controls.Add(button3);
            Controls.Add(password);
            Controls.Add(label5);
            Controls.Add(email);
            Controls.Add(label4);
            Controls.Add(gender);
            Controls.Add(label3);
            Controls.Add(lastname);
            Controls.Add(label2);
            Controls.Add(firstname);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "signup";
            Text = "signup";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox firstname;
        private Label label2;
        private TextBox lastname;
        private Label label3;
        private ComboBox gender;
        private Label label4;
        private TextBox email;
        private Label label5;
        private TextBox password;
        private Button button3;
        private TextBox securitylevel;
        private Button button1;
    }
}