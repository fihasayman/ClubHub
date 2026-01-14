namespace Final_Project
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            Goback = new PictureBox();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel1 = new Panel();
            email = new Label();
            Admin_Login = new Button();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pass = new Label();
            button2 = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)Goback).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Goback
            // 
            Goback.BackColor = Color.Transparent;
            Goback.BackgroundImage = (Image)resources.GetObject("Goback.BackgroundImage");
            Goback.BackgroundImageLayout = ImageLayout.Zoom;
            Goback.Location = new Point(12, 12);
            Goback.Name = "Goback";
            Goback.Size = new Size(77, 61);
            Goback.TabIndex = 23;
            Goback.TabStop = false;
            Goback.Click += Goback_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(649, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(748, 709);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 40, 66);
            panel3.Location = new Point(26, 243);
            panel3.Name = "panel3";
            panel3.Size = new Size(339, 2);
            panel3.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 40, 66);
            panel1.Location = new Point(26, 180);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 2);
            panel1.TabIndex = 9;
            // 
            // email
            // 
            email.AutoSize = true;
            email.BackColor = Color.Transparent;
            email.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email.ForeColor = Color.FromArgb(0, 40, 66);
            email.Location = new Point(22, 159);
            email.Name = "email";
            email.Size = new Size(63, 23);
            email.TabIndex = 0;
            email.Text = "Email";
            // 
            // Admin_Login
            // 
            Admin_Login.BackColor = Color.FromArgb(0, 40, 66);
            Admin_Login.Cursor = Cursors.Hand;
            Admin_Login.FlatStyle = FlatStyle.Flat;
            Admin_Login.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Admin_Login.ForeColor = Color.White;
            Admin_Login.Location = new Point(22, 299);
            Admin_Login.Name = "Admin_Login";
            Admin_Login.Size = new Size(343, 50);
            Admin_Login.TabIndex = 8;
            Admin_Login.Text = "Login";
            Admin_Login.UseVisualStyleBackColor = false;
            Admin_Login.Click += Admin_Login_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = Color.FromArgb(0, 40, 66);
            linkLabel1.LinkColor = Color.FromArgb(0, 40, 66);
            linkLabel1.Location = new Point(119, 263);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(141, 20);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 40, 66);
            label3.Location = new Point(133, 63);
            label3.Name = "label3";
            label3.Size = new Size(113, 43);
            label3.TabIndex = 4;
            label3.Text = "Login";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(222, 238, 246);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(119, 222);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 20);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(222, 238, 246);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(87, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 20);
            textBox1.TabIndex = 2;
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.BackColor = Color.Transparent;
            pass.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pass.ForeColor = Color.FromArgb(0, 40, 66);
            pass.Location = new Point(22, 221);
            pass.Name = "pass";
            pass.Size = new Size(99, 23);
            pass.TabIndex = 1;
            pass.Text = "Password";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(238, 243, 246);
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1354, 12);
            button2.Name = "button2";
            button2.Size = new Size(27, 27);
            button2.TabIndex = 22;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(222, 238, 246);
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(email);
            panel2.Controls.Add(Admin_Login);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(pass);
            panel2.Location = new Point(129, 135);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 423);
            panel2.TabIndex = 21;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 708);
            Controls.Add(Goback);
            Controls.Add(button2);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)Goback).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Goback;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel1;
        private Label email;
        private Button Admin_Login;
        private LinkLabel linkLabel1;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label pass;
        private Button button2;
        private Panel panel2;
    }
}