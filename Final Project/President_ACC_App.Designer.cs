namespace Final_Project
{
    partial class President_ACC_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(President_ACC_App));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            Member = new Button();
            Applicant = new Button();
            Event = new Button();
            label4 = new Label();
            label1 = new Label();
            cross = new PictureBox();
            Goback = new PictureBox();
            GridViewMem = new DataGridView();
            pictureBox4 = new PictureBox();
            Load_App = new Button();
            pictureBox2 = new PictureBox();
            Reject = new Button();
            Logout = new Button();
            pictureBox1 = new PictureBox();
            Viva = new Button();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cross).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Goback).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridViewMem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 53, 82);
            panel1.Controls.Add(Member);
            panel1.Controls.Add(Applicant);
            panel1.Controls.Add(Event);
            panel1.Location = new Point(447, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(648, 67);
            panel1.TabIndex = 31;
            // 
            // Member
            // 
            Member.BackColor = Color.FromArgb(0, 53, 82);
            Member.Cursor = Cursors.Hand;
            Member.FlatAppearance.BorderSize = 0;
            Member.FlatStyle = FlatStyle.Flat;
            Member.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Member.ForeColor = Color.FromArgb(222, 238, 246);
            Member.Location = new Point(18, 10);
            Member.Name = "Member";
            Member.Size = new Size(184, 49);
            Member.TabIndex = 27;
            Member.Text = "Member";
            Member.UseVisualStyleBackColor = false;
            Member.Click += Member_Click;
            // 
            // Applicant
            // 
            Applicant.BackColor = Color.FromArgb(0, 40, 66);
            Applicant.FlatAppearance.BorderSize = 0;
            Applicant.FlatStyle = FlatStyle.Flat;
            Applicant.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Applicant.ForeColor = Color.FromArgb(222, 238, 246);
            Applicant.Location = new Point(227, 10);
            Applicant.Name = "Applicant";
            Applicant.Size = new Size(184, 49);
            Applicant.TabIndex = 28;
            Applicant.Text = "Applicant";
            Applicant.UseVisualStyleBackColor = false;
            // 
            // Event
            // 
            Event.BackColor = Color.FromArgb(0, 53, 82);
            Event.Cursor = Cursors.Hand;
            Event.FlatAppearance.BorderSize = 0;
            Event.FlatStyle = FlatStyle.Flat;
            Event.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Event.ForeColor = Color.FromArgb(222, 238, 246);
            Event.Location = new Point(439, 10);
            Event.Name = "Event";
            Event.Size = new Size(184, 49);
            Event.TabIndex = 29;
            Event.Text = "Events";
            Event.UseVisualStyleBackColor = false;
            Event.Click += Event_Click;
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
            label4.TabIndex = 30;
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
            label1.TabIndex = 29;
            label1.Text = "President Panel";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cross
            // 
            cross.BackColor = Color.FromArgb(0, 40, 66);
            cross.BackgroundImage = (Image)resources.GetObject("cross.BackgroundImage");
            cross.BackgroundImageLayout = ImageLayout.Zoom;
            cross.Location = new Point(1354, 12);
            cross.Name = "cross";
            cross.Size = new Size(27, 27);
            cross.TabIndex = 34;
            cross.TabStop = false;
            cross.Click += cross_Click;
            // 
            // Goback
            // 
            Goback.BackColor = Color.Transparent;
            Goback.BackgroundImage = (Image)resources.GetObject("Goback.BackgroundImage");
            Goback.BackgroundImageLayout = ImageLayout.Zoom;
            Goback.Location = new Point(12, 635);
            Goback.Name = "Goback";
            Goback.Size = new Size(77, 61);
            Goback.TabIndex = 36;
            Goback.TabStop = false;
            Goback.Click += Goback_Click;
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
            GridViewMem.Location = new Point(58, 165);
            GridViewMem.Name = "GridViewMem";
            GridViewMem.RowHeadersWidth = 51;
            GridViewMem.Size = new Size(1037, 464);
            GridViewMem.TabIndex = 38;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(222, 238, 246);
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(1137, 439);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 36);
            pictureBox4.TabIndex = 52;
            pictureBox4.TabStop = false;
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
            Load_App.TabIndex = 51;
            Load_App.Text = "Load Applicants";
            Load_App.TextAlign = ContentAlignment.MiddleRight;
            Load_App.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(222, 238, 246);
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(1137, 349);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 36);
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
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
            Reject.TabIndex = 47;
            Reject.Text = "Reject Application";
            Reject.TextAlign = ContentAlignment.MiddleRight;
            Reject.UseVisualStyleBackColor = false;
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
            Logout.TabIndex = 46;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(222, 238, 246);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1137, 262);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 36);
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // Viva
            // 
            Viva.BackColor = Color.FromArgb(222, 238, 246);
            Viva.FlatStyle = FlatStyle.Flat;
            Viva.Font = new Font("Cambria", 12F, FontStyle.Bold);
            Viva.ForeColor = Color.FromArgb(0, 40, 66);
            Viva.Location = new Point(1126, 251);
            Viva.Name = "Viva";
            Viva.Size = new Size(226, 57);
            Viva.TabIndex = 44;
            Viva.Text = "Call Applicant\r\nfor Viva";
            Viva.TextAlign = ContentAlignment.MiddleRight;
            Viva.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(222, 238, 246);
            label3.Location = new Point(1182, 108);
            label3.Name = "label3";
            label3.Size = new Size(170, 21);
            label3.TabIndex = 54;
            label3.Text = "AIUB Computer Club";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1276, 68);
            label2.Name = "label2";
            label2.Size = new Size(76, 40);
            label2.TabIndex = 53;
            label2.Text = "ACC";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // President_ACC_App
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 40, 66);
            ClientSize = new Size(1393, 708);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox4);
            Controls.Add(Load_App);
            Controls.Add(pictureBox2);
            Controls.Add(Reject);
            Controls.Add(Logout);
            Controls.Add(pictureBox1);
            Controls.Add(Viva);
            Controls.Add(GridViewMem);
            Controls.Add(Goback);
            Controls.Add(cross);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "President_ACC_App";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "President_ACC_App";
            Load += President_ACC_App_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cross).EndInit();
            ((System.ComponentModel.ISupportInitialize)Goback).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridViewMem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button Member;
        private Button Applicant;
        private Button Event;
        private Label label4;
        private Label label1;
        private PictureBox cross;
        private PictureBox Goback;
        private DataGridView GridViewMem;
        private PictureBox pictureBox4;
        private Button Load_App;
        private PictureBox pictureBox2;
        private Button Reject;
        private Button Logout;
        private PictureBox pictureBox1;
        private Button Viva;
        private Label label3;
        private Label label2;
    }
}