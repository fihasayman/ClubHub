namespace Final_Project
{
    partial class President_PHSC_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(President_PHSC_App));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Logout = new Button();
            Goback = new PictureBox();
            cross = new PictureBox();
            panel1 = new Panel();
            Member_NPHSC = new Button();
            Applicant_PHSC = new Button();
            Event_NPHSC = new Button();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            GridViewMem = new DataGridView();
            pictureBox5 = new PictureBox();
            Load_App = new Button();
            pictureBox6 = new PictureBox();
            Reject = new Button();
            pictureBox7 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)Goback).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cross).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridViewMem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // Logout
            // 
            Logout.BackColor = Color.FromArgb(222, 238, 246);
            Logout.FlatAppearance.BorderSize = 0;
            Logout.FlatStyle = FlatStyle.Flat;
            Logout.Font = new Font("Cambria", 12F, FontStyle.Bold);
            Logout.ForeColor = Color.FromArgb(0, 40, 66);
            Logout.Location = new Point(1176, 515);
            Logout.Name = "Logout";
            Logout.Size = new Size(127, 49);
            Logout.TabIndex = 87;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = false;
            Logout.Click += Logout_Click;
            // 
            // Goback
            // 
            Goback.BackColor = Color.Transparent;
            Goback.BackgroundImage = (Image)resources.GetObject("Goback.BackgroundImage");
            Goback.BackgroundImageLayout = ImageLayout.Zoom;
            Goback.Location = new Point(12, 635);
            Goback.Name = "Goback";
            Goback.Size = new Size(77, 61);
            Goback.TabIndex = 86;
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
            cross.TabIndex = 85;
            cross.TabStop = false;
            cross.Click += cross_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 53, 82);
            panel1.Controls.Add(Member_NPHSC);
            panel1.Controls.Add(Applicant_PHSC);
            panel1.Controls.Add(Event_NPHSC);
            panel1.Location = new Point(447, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(648, 67);
            panel1.TabIndex = 82;
            // 
            // Member_NPHSC
            // 
            Member_NPHSC.BackColor = Color.FromArgb(0, 53, 82);
            Member_NPHSC.FlatAppearance.BorderSize = 0;
            Member_NPHSC.FlatStyle = FlatStyle.Flat;
            Member_NPHSC.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Member_NPHSC.ForeColor = Color.FromArgb(222, 238, 246);
            Member_NPHSC.Location = new Point(18, 10);
            Member_NPHSC.Name = "Member_NPHSC";
            Member_NPHSC.Size = new Size(184, 49);
            Member_NPHSC.TabIndex = 27;
            Member_NPHSC.Text = "Member";
            Member_NPHSC.UseVisualStyleBackColor = false;
            Member_NPHSC.Click += Member_NPHSC_Click;
            // 
            // Applicant_PHSC
            // 
            Applicant_PHSC.BackColor = Color.FromArgb(0, 40, 66);
            Applicant_PHSC.Cursor = Cursors.Hand;
            Applicant_PHSC.FlatAppearance.BorderSize = 0;
            Applicant_PHSC.FlatStyle = FlatStyle.Flat;
            Applicant_PHSC.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Applicant_PHSC.ForeColor = Color.FromArgb(222, 238, 246);
            Applicant_PHSC.Location = new Point(227, 10);
            Applicant_PHSC.Name = "Applicant_PHSC";
            Applicant_PHSC.Size = new Size(184, 49);
            Applicant_PHSC.TabIndex = 28;
            Applicant_PHSC.Text = "Applicant";
            Applicant_PHSC.UseVisualStyleBackColor = false;
            // 
            // Event_NPHSC
            // 
            Event_NPHSC.BackColor = Color.FromArgb(0, 53, 82);
            Event_NPHSC.Cursor = Cursors.Hand;
            Event_NPHSC.FlatAppearance.BorderSize = 0;
            Event_NPHSC.FlatStyle = FlatStyle.Flat;
            Event_NPHSC.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Event_NPHSC.ForeColor = Color.FromArgb(222, 238, 246);
            Event_NPHSC.Location = new Point(439, 10);
            Event_NPHSC.Name = "Event_NPHSC";
            Event_NPHSC.Size = new Size(184, 49);
            Event_NPHSC.TabIndex = 29;
            Event_NPHSC.Text = "Events";
            Event_NPHSC.UseVisualStyleBackColor = false;
            Event_NPHSC.Click += Event_NPHSC_Click;
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
            label4.TabIndex = 81;
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
            label1.TabIndex = 80;
            label1.Text = "President Panel";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(222, 238, 246);
            label3.Location = new Point(1156, 108);
            label3.Name = "label3";
            label3.Size = new Size(185, 42);
            label3.TabIndex = 96;
            label3.Text = "NSU Public Health And\r\nScience Club";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1219, 68);
            label2.Name = "label2";
            label2.Size = new Size(122, 40);
            label2.TabIndex = 95;
            label2.Text = "NPHSC";
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
            GridViewMem.TabIndex = 88;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(222, 238, 246);
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(1137, 439);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(34, 36);
            pictureBox5.TabIndex = 103;
            pictureBox5.TabStop = false;
            // 
            // Load_App
            // 
            Load_App.BackColor = Color.FromArgb(222, 238, 246);
            Load_App.FlatStyle = FlatStyle.Flat;
            Load_App.Font = new Font("Cambria", 12F, FontStyle.Bold);
            Load_App.ForeColor = Color.FromArgb(0, 40, 66);
            Load_App.Location = new Point(1126, 429);
            Load_App.Name = "Load_App";
            Load_App.Size = new Size(226, 57);
            Load_App.TabIndex = 102;
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
            pictureBox6.Location = new Point(1137, 349);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(34, 36);
            pictureBox6.TabIndex = 101;
            pictureBox6.TabStop = false;
            // 
            // Reject
            // 
            Reject.BackColor = Color.FromArgb(222, 238, 246);
            Reject.FlatStyle = FlatStyle.Flat;
            Reject.Font = new Font("Cambria", 12F, FontStyle.Bold);
            Reject.ForeColor = Color.FromArgb(0, 40, 66);
            Reject.Location = new Point(1126, 339);
            Reject.Name = "Reject";
            Reject.Size = new Size(226, 57);
            Reject.TabIndex = 100;
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
            pictureBox7.Location = new Point(1137, 267);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(30, 30);
            pictureBox7.TabIndex = 98;
            pictureBox7.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(222, 238, 246);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cambria", 12F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(0, 40, 66);
            button2.Location = new Point(1126, 251);
            button2.Name = "button2";
            button2.Size = new Size(226, 57);
            button2.TabIndex = 104;
            button2.Text = "Accept Application";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // President_PHSC_App
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
            Controls.Add(Goback);
            Controls.Add(cross);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(GridViewMem);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "President_PHSC_App";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "President_PHSC_App";
            ((System.ComponentModel.ISupportInitialize)Goback).EndInit();
            ((System.ComponentModel.ISupportInitialize)cross).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridViewMem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Logout;
        private PictureBox Goback;
        private PictureBox cross;
        private Panel panel1;
        private Button Member_NPHSC;
        private Button Applicant_PHSC;
        private Button Event_NPHSC;
        private Label label4;
        private Label label1;
        private Label label3;
        private Label label2;
        private DataGridView GridViewMem;
        private PictureBox pictureBox5;
        private Button Load_App;
        private PictureBox pictureBox6;
        private Button Reject;
        private PictureBox pictureBox7;
        private Button button2;
    }
}