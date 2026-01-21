namespace Final_Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            Goback = new PictureBox();
            pass = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            Login_president = new Button();
            email = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Goback).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(646, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(756, 729);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Goback
            // 
            Goback.BackColor = Color.Transparent;
            Goback.BackgroundImage = (Image)resources.GetObject("Goback.BackgroundImage");
            Goback.BackgroundImageLayout = ImageLayout.Zoom;
            Goback.Location = new Point(12, 12);
            Goback.Name = "Goback";
            Goback.Size = new Size(77, 61);
            Goback.TabIndex = 19;
            Goback.TabStop = false;
            Goback.Click += Goback_Click;
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.BackColor = Color.Transparent;
            pass.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pass.ForeColor = Color.FromArgb(0, 40, 66);
            pass.Location = new Point(19, 192);
            pass.Name = "pass";
            pass.Size = new Size(99, 23);
            pass.TabIndex = 1;
            pass.Text = "Password";
            pass.Click += pass_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(222, 238, 246);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(84, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 20);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(222, 238, 246);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(116, 193);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 20);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 40, 66);
            label3.Location = new Point(135, 38);
            label3.Name = "label3";
            label3.Size = new Size(113, 43);
            label3.TabIndex = 4;
            label3.Text = "Login";
            // 
            // Login_president
            // 
            Login_president.BackColor = Color.FromArgb(0, 40, 66);
            Login_president.Cursor = Cursors.Hand;
            Login_president.FlatStyle = FlatStyle.Flat;
            Login_president.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login_president.ForeColor = Color.White;
            Login_president.Location = new Point(19, 278);
            Login_president.Name = "Login_president";
            Login_president.Size = new Size(343, 50);
            Login_president.TabIndex = 8;
            Login_president.Text = "Login";
            Login_president.UseVisualStyleBackColor = false;
            Login_president.Click += Login_President;
            // 
            // email
            // 
            email.AutoSize = true;
            email.BackColor = Color.Transparent;
            email.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email.ForeColor = Color.FromArgb(0, 40, 66);
            email.Location = new Point(19, 130);
            email.Name = "email";
            email.Size = new Size(63, 23);
            email.TabIndex = 0;
            email.Text = "Email";
            email.Click += email_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 40, 66);
            panel1.Location = new Point(23, 151);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 2);
            panel1.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 40, 66);
            panel3.Location = new Point(23, 214);
            panel3.Name = "panel3";
            panel3.Size = new Size(339, 2);
            panel3.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(222, 238, 246);
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(email);
            panel2.Controls.Add(Login_president);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(pass);
            panel2.Location = new Point(134, 138);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 423);
            panel2.TabIndex = 2;
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
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1393, 708);
            Controls.Add(Goback);
            Controls.Add(button2);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Goback).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox Goback;
        private Label pass;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Button Login_president;
        private Label email;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Button button2;
    }
}
