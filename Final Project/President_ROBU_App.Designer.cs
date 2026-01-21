namespace Final_Project
{
    partial class President_ROBU_App
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(President_ROBU_App));
            label3 = new Label();
            label2 = new Label();
            GridViewMem = new DataGridView();
            Member_ROBU = new Button();
            Applicant_ROBU = new Button();
            Event_ROBU = new Button();
            Goback = new PictureBox();
            cross = new PictureBox();
            panel1 = new Panel();
            label4 = new Label();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            Load_App = new Button();
            pictureBox6 = new PictureBox();
            Reject = new Button();
            pictureBox7 = new PictureBox();
            Logout = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)GridViewMem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Goback).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cross).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(222, 238, 246);
            label3.Location = new Point(1158, 108);
            label3.Name = "label3";
            label3.Size = new Size(183, 42);
            label3.TabIndex = 79;
            label3.Text = "Robotics Club of BRAC\r\nUniversity";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1234, 68);
            label2.Name = "label2";
            label2.Size = new Size(107, 40);
            label2.TabIndex = 78;
            label2.Text = "ROBU";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GridViewMem
            // 
            GridViewMem.BackgroundColor = Color.FromArgb(0, 40, 66);
            GridViewMem.BorderStyle = BorderStyle.Fixed3D;
            GridViewMem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewMem.Cursor = Cursors.Hand;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 53, 82);
            dataGridViewCellStyle1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(222, 238, 246);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(222, 238, 246);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 40, 66);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            GridViewMem.DefaultCellStyle = dataGridViewCellStyle1;
            GridViewMem.GridColor = Color.FromArgb(0, 53, 82);
            GridViewMem.Location = new Point(58, 170);
            GridViewMem.Name = "GridViewMem";
            GridViewMem.RowHeadersWidth = 51;
            GridViewMem.Size = new Size(1037, 459);
            GridViewMem.TabIndex = 71;
            // 
            // Member_ROBU
            // 
            Member_ROBU.BackColor = Color.FromArgb(0, 53, 82);
            Member_ROBU.FlatAppearance.BorderSize = 0;
            Member_ROBU.FlatStyle = FlatStyle.Flat;
            Member_ROBU.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Member_ROBU.ForeColor = Color.FromArgb(222, 238, 246);
            Member_ROBU.Location = new Point(18, 10);
            Member_ROBU.Name = "Member_ROBU";
            Member_ROBU.Size = new Size(184, 49);
            Member_ROBU.TabIndex = 27;
            Member_ROBU.Text = "Member";
            Member_ROBU.UseVisualStyleBackColor = false;
            Member_ROBU.Click += Member_ROBU_Click;
            // 
            // Applicant_ROBU
            // 
            Applicant_ROBU.BackColor = Color.FromArgb(0, 40, 66);
            Applicant_ROBU.Cursor = Cursors.Hand;
            Applicant_ROBU.FlatAppearance.BorderSize = 0;
            Applicant_ROBU.FlatStyle = FlatStyle.Flat;
            Applicant_ROBU.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Applicant_ROBU.ForeColor = Color.FromArgb(222, 238, 246);
            Applicant_ROBU.Location = new Point(227, 10);
            Applicant_ROBU.Name = "Applicant_ROBU";
            Applicant_ROBU.Size = new Size(184, 49);
            Applicant_ROBU.TabIndex = 28;
            Applicant_ROBU.Text = "Applicant";
            Applicant_ROBU.UseVisualStyleBackColor = false;
            // 
            // Event_ROBU
            // 
            Event_ROBU.BackColor = Color.FromArgb(0, 53, 82);
            Event_ROBU.Cursor = Cursors.Hand;
            Event_ROBU.FlatAppearance.BorderSize = 0;
            Event_ROBU.FlatStyle = FlatStyle.Flat;
            Event_ROBU.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Event_ROBU.ForeColor = Color.FromArgb(222, 238, 246);
            Event_ROBU.Location = new Point(439, 10);
            Event_ROBU.Name = "Event_ROBU";
            Event_ROBU.Size = new Size(184, 49);
            Event_ROBU.TabIndex = 29;
            Event_ROBU.Text = "Events";
            Event_ROBU.UseVisualStyleBackColor = false;
            Event_ROBU.Click += Event_ROBU_Click;
            // 
            // Goback
            // 
            Goback.BackColor = Color.Transparent;
            Goback.BackgroundImage = (Image)resources.GetObject("Goback.BackgroundImage");
            Goback.BackgroundImageLayout = ImageLayout.Zoom;
            Goback.Location = new Point(12, 635);
            Goback.Name = "Goback";
            Goback.Size = new Size(77, 61);
            Goback.TabIndex = 69;
            Goback.TabStop = false;
            Goback.Click += Goback_Click;
            // 
            // cross
            // 
            cross.BackColor = Color.FromArgb(0, 40, 66);
            cross.BackgroundImage = (Image)resources.GetObject("cross.BackgroundImage");
            cross.BackgroundImageLayout = ImageLayout.Zoom;
            cross.Location = new Point(1354, 12);
            cross.Name = "cross";
            cross.Size = new Size(27, 27);
            cross.TabIndex = 68;
            cross.TabStop = false;
            cross.Click += cross_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 53, 82);
            panel1.Controls.Add(Member_ROBU);
            panel1.Controls.Add(Applicant_ROBU);
            panel1.Controls.Add(Event_ROBU);
            panel1.Location = new Point(447, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(648, 67);
            panel1.TabIndex = 65;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cambria", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(222, 238, 246);
            label4.Location = new Point(58, 108);
            label4.Name = "label4";
            label4.Size = new Size(345, 27);
            label4.TabIndex = 64;
            label4.Text = "Manage club members and events";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 44);
            label1.Name = "label1";
            label1.Size = new Size(364, 55);
            label1.TabIndex = 63;
            label1.Text = "President Panel";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(222, 238, 246);
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(1152, 423);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(34, 36);
            pictureBox5.TabIndex = 125;
            pictureBox5.TabStop = false;
            // 
            // Load_App
            // 
            Load_App.BackColor = Color.FromArgb(222, 238, 246);
            Load_App.FlatStyle = FlatStyle.Flat;
            Load_App.Font = new Font("Cambria", 12F, FontStyle.Bold);
            Load_App.ForeColor = Color.FromArgb(0, 40, 66);
            Load_App.Location = new Point(1141, 413);
            Load_App.Name = "Load_App";
            Load_App.Size = new Size(226, 57);
            Load_App.TabIndex = 124;
            Load_App.Text = "Load Applicants";
            Load_App.TextAlign = ContentAlignment.MiddleRight;
            Load_App.UseVisualStyleBackColor = false;
            Load_App.Click += Load_App_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(222, 238, 246);
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(1152, 333);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(34, 36);
            pictureBox6.TabIndex = 123;
            pictureBox6.TabStop = false;
            // 
            // Reject
            // 
            Reject.BackColor = Color.FromArgb(222, 238, 246);
            Reject.FlatStyle = FlatStyle.Flat;
            Reject.Font = new Font("Cambria", 12F, FontStyle.Bold);
            Reject.ForeColor = Color.FromArgb(0, 40, 66);
            Reject.Location = new Point(1141, 323);
            Reject.Name = "Reject";
            Reject.Size = new Size(226, 57);
            Reject.TabIndex = 122;
            Reject.Text = "Reject Application";
            Reject.TextAlign = ContentAlignment.MiddleRight;
            Reject.UseVisualStyleBackColor = false;
            Reject.Click += Reject_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(222, 238, 246);
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Location = new Point(1152, 251);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(30, 30);
            pictureBox7.TabIndex = 121;
            pictureBox7.TabStop = false;
            // 
            // Logout
            // 
            Logout.BackColor = Color.FromArgb(222, 238, 246);
            Logout.FlatAppearance.BorderSize = 0;
            Logout.FlatStyle = FlatStyle.Flat;
            Logout.Font = new Font("Cambria", 12F, FontStyle.Bold);
            Logout.ForeColor = Color.FromArgb(0, 40, 66);
            Logout.Location = new Point(1191, 499);
            Logout.Name = "Logout";
            Logout.Size = new Size(127, 49);
            Logout.TabIndex = 120;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(222, 238, 246);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cambria", 12F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(0, 40, 66);
            button2.Location = new Point(1141, 235);
            button2.Name = "button2";
            button2.Size = new Size(226, 57);
            button2.TabIndex = 126;
            button2.Text = "Accept Application";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // President_ROBU_App
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 40, 66);
            ClientSize = new Size(1393, 708);
            Controls.Add(pictureBox5);
            Controls.Add(Load_App);
            Controls.Add(pictureBox6);
            Controls.Add(Reject);
            Controls.Add(pictureBox7);
            Controls.Add(Logout);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(GridViewMem);
            Controls.Add(Goback);
            Controls.Add(cross);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "President_ROBU_App";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "President_ROBU_App";
            ((System.ComponentModel.ISupportInitialize)GridViewMem).EndInit();
            ((System.ComponentModel.ISupportInitialize)Goback).EndInit();
            ((System.ComponentModel.ISupportInitialize)cross).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private DataGridView GridViewMem;
        private Button Member_ROBU;
        private Button Applicant_ROBU;
        private Button Event_ROBU;
        private PictureBox Goback;
        private PictureBox cross;
        private Panel panel1;
        private Label label4;
        private Label label1;
        private PictureBox pictureBox5;
        private Button Load_App;
        private PictureBox pictureBox6;
        private Button Reject;
        private PictureBox pictureBox7;
        private Button Logout;
        private Button button2;
    }
}