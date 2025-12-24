namespace Final_Project
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
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1 = new Panel();
            email = new Label();
            button1 = new Button();
            label1 = new Label();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pass = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(657, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(629, 613);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MintCream;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(email);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(linkLabel2);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(pass);
            panel2.Location = new Point(126, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 423);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(28, 65, 42);
            panel3.Location = new Point(23, 214);
            panel3.Name = "panel3";
            panel3.Size = new Size(339, 2);
            panel3.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 65, 42);
            panel1.Location = new Point(23, 151);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 2);
            panel1.TabIndex = 9;
            // 
            // email
            // 
            email.AutoSize = true;
            email.BackColor = Color.Transparent;
            email.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email.ForeColor = Color.FromArgb(28, 65, 42);
            email.Location = new Point(19, 130);
            email.Name = "email";
            email.Size = new Size(63, 23);
            email.TabIndex = 0;
            email.Text = "Email";
            email.Click += email_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(28, 65, 42);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(19, 278);
            button1.Name = "button1";
            button1.Size = new Size(343, 50);
            button1.TabIndex = 8;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(28, 65, 42);
            label1.Location = new Point(103, 351);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 7;
            label1.Text = "Don't have an account?";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.FromArgb(28, 65, 42);
            linkLabel2.Location = new Point(157, 371);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(66, 20);
            linkLabel2.TabIndex = 6;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Sign up";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = Color.FromArgb(28, 65, 42);
            linkLabel1.LinkColor = Color.FromArgb(28, 65, 42);
            linkLabel1.Location = new Point(116, 234);
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
            label3.ForeColor = Color.FromArgb(28, 65, 42);
            label3.Location = new Point(135, 38);
            label3.Name = "label3";
            label3.Size = new Size(113, 43);
            label3.TabIndex = 4;
            label3.Text = "Login";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.MintCream;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(116, 193);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 20);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MintCream;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(84, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 20);
            textBox1.TabIndex = 2;
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.BackColor = Color.Transparent;
            pass.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pass.ForeColor = Color.FromArgb(28, 65, 42);
            pass.Location = new Point(19, 192);
            pass.Name = "pass";
            pass.Size = new Size(99, 23);
            pass.TabIndex = 1;
            pass.Text = "Password";
            pass.Click += pass_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(10, 13, 20);
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1233, 12);
            button2.Name = "button2";
            button2.Size = new Size(27, 26);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1280, 601);
            Controls.Add(button2);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label3;
        private TextBox textBox2;
        private Label pass;
        private Label email;
        private TextBox textBox1;
        private LinkLabel linkLabel1;
        private Label label1;
        private LinkLabel linkLabel2;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Panel panel3;
    }
}
