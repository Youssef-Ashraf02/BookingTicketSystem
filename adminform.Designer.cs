namespace tickium
{
    partial class adminform
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            firstname = new TextBox();
            lastname = new TextBox();
            password = new TextBox();
            gender = new TextBox();
            email = new TextBox();
            dataGridView1 = new DataGridView();
            create = new Button();
            delete = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.TabIndex = 2;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(0, 106);
            label1.Name = "label1";
            label1.Size = new Size(108, 22);
            label1.TabIndex = 5;
            label1.Text = "First name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(0, 169);
            label2.Name = "label2";
            label2.Size = new Size(106, 22);
            label2.TabIndex = 6;
            label2.Text = "Last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(0, 300);
            label3.Name = "label3";
            label3.Size = new Size(61, 22);
            label3.TabIndex = 7;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(0, 232);
            label4.Name = "label4";
            label4.Size = new Size(79, 22);
            label4.TabIndex = 8;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(0, 364);
            label5.Name = "label5";
            label5.Size = new Size(102, 22);
            label5.TabIndex = 9;
            label5.Text = "password";
            // 
            // firstname
            // 
            firstname.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            firstname.Location = new Point(0, 131);
            firstname.Multiline = true;
            firstname.Name = "firstname";
            firstname.Size = new Size(160, 26);
            firstname.TabIndex = 10;
            // 
            // lastname
            // 
            lastname.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lastname.Location = new Point(0, 194);
            lastname.Multiline = true;
            lastname.Name = "lastname";
            lastname.Size = new Size(160, 26);
            lastname.TabIndex = 11;
            // 
            // password
            // 
            password.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            password.Location = new Point(0, 389);
            password.Multiline = true;
            password.Name = "password";
            password.Size = new Size(160, 26);
            password.TabIndex = 12;
            // 
            // gender
            // 
            gender.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            gender.Location = new Point(0, 257);
            gender.Multiline = true;
            gender.Name = "gender";
            gender.Size = new Size(160, 26);
            gender.TabIndex = 13;
            // 
            // email
            // 
            email.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            email.Location = new Point(0, 325);
            email.Multiline = true;
            email.Name = "email";
            email.Size = new Size(160, 26);
            email.TabIndex = 14;
            email.TextChanged += textBox4_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(200, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(377, 182);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // create
            // 
            create.BackColor = SystemColors.HotTrack;
            create.Font = new Font("Arial", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            create.ForeColor = SystemColors.ButtonHighlight;
            create.Location = new Point(612, 194);
            create.Name = "create";
            create.Size = new Size(110, 31);
            create.TabIndex = 22;
            create.Text = "create";
            create.UseVisualStyleBackColor = false;
            create.Click += create_Click;
            // 
            // delete
            // 
            delete.BackColor = SystemColors.HotTrack;
            delete.Font = new Font("Arial", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            delete.ForeColor = SystemColors.ButtonHighlight;
            delete.Location = new Point(612, 280);
            delete.Name = "delete";
            delete.Size = new Size(110, 31);
            delete.TabIndex = 25;
            delete.Text = "delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(387, 407);
            button3.Name = "button3";
            button3.Size = new Size(58, 31);
            button3.TabIndex = 26;
            button3.Text = "back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // adminform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(delete);
            Controls.Add(create);
            Controls.Add(dataGridView1);
            Controls.Add(email);
            Controls.Add(gender);
            Controls.Add(password);
            Controls.Add(lastname);
            Controls.Add(firstname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "adminform";
            Text = "adminform";
            Load += adminform_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox firstname;
        private TextBox lastname;
        private TextBox password;
        private TextBox gender;
        private TextBox email;
        private DataGridView dataGridView1;
        private Button create;
        private Button delete;
        private Button button3;
    }
}