namespace Final_Project
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            cross = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            Admin = new Button();
            President = new Button();
            Member = new Button();
            User = new Button();
            pictureBox4 = new PictureBox();
            Goback = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)cross).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Goback).BeginInit();
            SuspendLayout();
            // 
            // cross
            // 
            cross.BackColor = Color.Transparent;
            cross.BackgroundImage = (Image)resources.GetObject("cross.BackgroundImage");
            cross.BackgroundImageLayout = ImageLayout.Zoom;
            cross.Location = new Point(1241, 12);
            cross.Name = "cross";
            cross.Size = new Size(27, 27);
            cross.TabIndex = 7;
            cross.TabStop = false;
            cross.Click += cross_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(562, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 107);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.wp9396725__1_;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(-183, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(550, 622);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.wp9396725__1_;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(901, -2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(550, 622);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // Admin
            // 
            Admin.BackColor = Color.Honeydew;
            Admin.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Admin.ForeColor = Color.FromArgb(13, 34, 21);
            Admin.Location = new Point(491, 216);
            Admin.Name = "Admin";
            Admin.Size = new Size(286, 50);
            Admin.TabIndex = 11;
            Admin.Text = "Admin";
            Admin.UseVisualStyleBackColor = false;
            Admin.Click += Admin_Click;
            // 
            // President
            // 
            President.BackColor = Color.Honeydew;
            President.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            President.ForeColor = Color.FromArgb(13, 34, 21);
            President.Location = new Point(491, 291);
            President.Name = "President";
            President.Size = new Size(286, 50);
            President.TabIndex = 12;
            President.Text = "President";
            President.UseVisualStyleBackColor = false;
            President.Click += President_Click;
            // 
            // Member
            // 
            Member.BackColor = Color.Honeydew;
            Member.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Member.ForeColor = Color.FromArgb(13, 34, 21);
            Member.Location = new Point(491, 366);
            Member.Name = "Member";
            Member.Size = new Size(286, 50);
            Member.TabIndex = 13;
            Member.Text = "Member";
            Member.UseVisualStyleBackColor = false;
            Member.Click += Member_Click;
            // 
            // User
            // 
            User.BackColor = Color.Honeydew;
            User.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            User.ForeColor = Color.FromArgb(13, 34, 21);
            User.Location = new Point(491, 440);
            User.Name = "User";
            User.Size = new Size(286, 50);
            User.TabIndex = 15;
            User.Text = "User/Applicant";
            User.UseVisualStyleBackColor = false;
            User.Click += User_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(1241, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(27, 27);
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // Goback
            // 
            Goback.BackgroundImage = (Image)resources.GetObject("Goback.BackgroundImage");
            Goback.BackgroundImageLayout = ImageLayout.Zoom;
            Goback.Location = new Point(592, 511);
            Goback.Name = "Goback";
            Goback.Size = new Size(85, 77);
            Goback.TabIndex = 17;
            Goback.TabStop = false;
            Goback.Click += pictureBox5_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 34, 21);
            ClientSize = new Size(1280, 601);
            Controls.Add(Goback);
            Controls.Add(pictureBox4);
            Controls.Add(User);
            Controls.Add(Member);
            Controls.Add(President);
            Controls.Add(Admin);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(cross);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)cross).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Goback).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox cross;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button Admin;
        private Button President;
        private Button Member;
        private Button User;
        private PictureBox pictureBox4;
        private PictureBox Goback;
    }
}