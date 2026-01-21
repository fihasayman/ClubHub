namespace Final_Project
{
    partial class Admin_Control_AIUB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Control_AIUB));
            GridViewMem = new DataGridView();
            Goback = new PictureBox();
            Member = new Button();
            ABC_Pre = new Button();
            cross = new PictureBox();
            panel1 = new Panel();
            ARND_Pre = new Button();
            ADC_Pre = new Button();
            Logout = new Button();
            pictureBox4 = new PictureBox();
            Load_Pre_ACC = new Button();
            pictureBox3 = new PictureBox();
            Update_Mem = new Button();
            pictureBox2 = new PictureBox();
            Remove_Pre_ACC = new Button();
            pictureBox1 = new PictureBox();
            Add_Pre_ACC = new Button();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)GridViewMem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Goback).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cross).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            GridViewMem.Location = new Point(396, 151);
            GridViewMem.Name = "GridViewMem";
            GridViewMem.RowHeadersWidth = 51;
            GridViewMem.Size = new Size(929, 362);
            GridViewMem.TabIndex = 54;
            // 
            // Goback
            // 
            Goback.BackColor = Color.Transparent;
            Goback.BackgroundImage = (Image)resources.GetObject("Goback.BackgroundImage");
            Goback.BackgroundImageLayout = ImageLayout.Zoom;
            Goback.Location = new Point(12, 635);
            Goback.Name = "Goback";
            Goback.Size = new Size(77, 61);
            Goback.TabIndex = 52;
            Goback.TabStop = false;
            Goback.Click += Goback_Click;
            // 
            // Member
            // 
            Member.BackColor = Color.FromArgb(0, 40, 66);
            Member.FlatAppearance.BorderSize = 0;
            Member.FlatStyle = FlatStyle.Flat;
            Member.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Member.ForeColor = Color.FromArgb(222, 238, 246);
            Member.Location = new Point(19, 13);
            Member.Name = "Member";
            Member.Size = new Size(251, 63);
            Member.TabIndex = 27;
            Member.Text = "AIUB Computer Club";
            Member.UseVisualStyleBackColor = false;
            // 
            // ABC_Pre
            // 
            ABC_Pre.BackColor = Color.FromArgb(0, 53, 82);
            ABC_Pre.Cursor = Cursors.Hand;
            ABC_Pre.FlatAppearance.BorderSize = 0;
            ABC_Pre.FlatStyle = FlatStyle.Flat;
            ABC_Pre.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ABC_Pre.ForeColor = Color.FromArgb(222, 238, 246);
            ABC_Pre.Location = new Point(19, 105);
            ABC_Pre.Name = "ABC_Pre";
            ABC_Pre.Size = new Size(251, 63);
            ABC_Pre.TabIndex = 28;
            ABC_Pre.Text = "AIUB Business Club";
            ABC_Pre.UseVisualStyleBackColor = false;
            ABC_Pre.Click += ABC_Pre_Click;
            // 
            // cross
            // 
            cross.BackColor = Color.FromArgb(0, 40, 66);
            cross.BackgroundImage = (Image)resources.GetObject("cross.BackgroundImage");
            cross.BackgroundImageLayout = ImageLayout.Zoom;
            cross.Location = new Point(1354, 12);
            cross.Name = "cross";
            cross.Size = new Size(27, 27);
            cross.TabIndex = 51;
            cross.TabStop = false;
            cross.Click += cross_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 53, 82);
            panel1.Controls.Add(ARND_Pre);
            panel1.Controls.Add(ADC_Pre);
            panel1.Controls.Add(Member);
            panel1.Controls.Add(ABC_Pre);
            panel1.Controls.Add(Logout);
            panel1.Location = new Point(58, 151);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 439);
            panel1.TabIndex = 48;
            // 
            // ARND_Pre
            // 
            ARND_Pre.BackColor = Color.FromArgb(0, 53, 82);
            ARND_Pre.Cursor = Cursors.Hand;
            ARND_Pre.FlatAppearance.BorderSize = 0;
            ARND_Pre.FlatStyle = FlatStyle.Flat;
            ARND_Pre.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ARND_Pre.ForeColor = Color.FromArgb(222, 238, 246);
            ARND_Pre.Location = new Point(19, 289);
            ARND_Pre.Name = "ARND_Pre";
            ARND_Pre.Size = new Size(251, 63);
            ARND_Pre.TabIndex = 32;
            ARND_Pre.Text = "AIUB Research And\r\nDevelopment Club";
            ARND_Pre.UseVisualStyleBackColor = false;
            ARND_Pre.Click += ARND_Pre_Click;
            // 
            // ADC_Pre
            // 
            ADC_Pre.BackColor = Color.FromArgb(0, 53, 82);
            ADC_Pre.Cursor = Cursors.Hand;
            ADC_Pre.FlatAppearance.BorderSize = 0;
            ADC_Pre.FlatStyle = FlatStyle.Flat;
            ADC_Pre.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ADC_Pre.ForeColor = Color.FromArgb(222, 238, 246);
            ADC_Pre.Location = new Point(19, 197);
            ADC_Pre.Name = "ADC_Pre";
            ADC_Pre.Size = new Size(251, 63);
            ADC_Pre.TabIndex = 30;
            ADC_Pre.Text = "AIUB Drama Club";
            ADC_Pre.UseVisualStyleBackColor = false;
            ADC_Pre.Click += ADC_Pre_Click;
            // 
            // Logout
            // 
            Logout.BackColor = Color.FromArgb(222, 238, 246);
            Logout.Cursor = Cursors.Hand;
            Logout.FlatAppearance.BorderSize = 0;
            Logout.FlatStyle = FlatStyle.Flat;
            Logout.Font = new Font("Cambria", 12F, FontStyle.Bold);
            Logout.ForeColor = Color.FromArgb(0, 40, 66);
            Logout.Location = new Point(81, 379);
            Logout.Name = "Logout";
            Logout.Size = new Size(127, 49);
            Logout.TabIndex = 63;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = false;
            Logout.Click += Logout_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(222, 238, 246);
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(1124, 544);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 36);
            pictureBox4.TabIndex = 69;
            pictureBox4.TabStop = false;
            // 
            // Load_Pre_ACC
            // 
            Load_Pre_ACC.BackColor = Color.FromArgb(222, 238, 246);
            Load_Pre_ACC.Cursor = Cursors.Hand;
            Load_Pre_ACC.FlatStyle = FlatStyle.Flat;
            Load_Pre_ACC.Font = new Font("Cambria", 12F, FontStyle.Bold);
            Load_Pre_ACC.ForeColor = Color.FromArgb(0, 40, 66);
            Load_Pre_ACC.Location = new Point(1110, 534);
            Load_Pre_ACC.Name = "Load_Pre_ACC";
            Load_Pre_ACC.Size = new Size(215, 57);
            Load_Pre_ACC.TabIndex = 68;
            Load_Pre_ACC.Text = "Load Presidents";
            Load_Pre_ACC.TextAlign = ContentAlignment.MiddleRight;
            Load_Pre_ACC.UseVisualStyleBackColor = false;
            Load_Pre_ACC.Click += Load_Pre_ACC_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(222, 238, 246);
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(879, 544);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 36);
            pictureBox3.TabIndex = 67;
            pictureBox3.TabStop = false;
            // 
            // Update_Mem
            // 
            Update_Mem.BackColor = Color.FromArgb(222, 238, 246);
            Update_Mem.Cursor = Cursors.Hand;
            Update_Mem.FlatStyle = FlatStyle.Flat;
            Update_Mem.Font = new Font("Cambria", 12F, FontStyle.Bold);
            Update_Mem.ForeColor = Color.FromArgb(0, 40, 66);
            Update_Mem.Location = new Point(868, 534);
            Update_Mem.Name = "Update_Mem";
            Update_Mem.Size = new Size(222, 57);
            Update_Mem.TabIndex = 66;
            Update_Mem.Text = "Update President";
            Update_Mem.TextAlign = ContentAlignment.MiddleRight;
            Update_Mem.UseVisualStyleBackColor = false;
            Update_Mem.Click += Update_Mem_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(222, 238, 246);
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(627, 543);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 36);
            pictureBox2.TabIndex = 65;
            pictureBox2.TabStop = false;
            // 
            // Remove_Pre_ACC
            // 
            Remove_Pre_ACC.BackColor = Color.FromArgb(222, 238, 246);
            Remove_Pre_ACC.Cursor = Cursors.Hand;
            Remove_Pre_ACC.FlatStyle = FlatStyle.Flat;
            Remove_Pre_ACC.Font = new Font("Cambria", 12F, FontStyle.Bold);
            Remove_Pre_ACC.ForeColor = Color.FromArgb(0, 40, 66);
            Remove_Pre_ACC.Location = new Point(616, 533);
            Remove_Pre_ACC.Name = "Remove_Pre_ACC";
            Remove_Pre_ACC.Size = new Size(234, 57);
            Remove_Pre_ACC.TabIndex = 64;
            Remove_Pre_ACC.Text = "Remove President";
            Remove_Pre_ACC.TextAlign = ContentAlignment.MiddleRight;
            Remove_Pre_ACC.UseVisualStyleBackColor = false;
            Remove_Pre_ACC.Click += Remove_Pre_ACC_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(222, 238, 246);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(407, 544);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 36);
            pictureBox1.TabIndex = 62;
            pictureBox1.TabStop = false;
            // 
            // Add_Pre_ACC
            // 
            Add_Pre_ACC.BackColor = Color.FromArgb(222, 238, 246);
            Add_Pre_ACC.Cursor = Cursors.Hand;
            Add_Pre_ACC.FlatStyle = FlatStyle.Flat;
            Add_Pre_ACC.Font = new Font("Cambria", 12F, FontStyle.Bold);
            Add_Pre_ACC.ForeColor = Color.FromArgb(0, 40, 66);
            Add_Pre_ACC.Location = new Point(396, 533);
            Add_Pre_ACC.Name = "Add_Pre_ACC";
            Add_Pre_ACC.Size = new Size(203, 57);
            Add_Pre_ACC.TabIndex = 61;
            Add_Pre_ACC.Text = "Add President";
            Add_Pre_ACC.TextAlign = ContentAlignment.MiddleRight;
            Add_Pre_ACC.UseVisualStyleBackColor = false;
            Add_Pre_ACC.Click += Add_Pre_ACC_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cambria", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(578, 83);
            label2.Name = "label2";
            label2.Size = new Size(562, 43);
            label2.TabIndex = 70;
            label2.Text = "Presidents of AIUB Computer Club";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cambria", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(222, 238, 246);
            label4.Location = new Point(70, 99);
            label4.Name = "label4";
            label4.Size = new Size(277, 27);
            label4.TabIndex = 74;
            label4.Text = "Manage Presidents of AIUB";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(60, 46);
            label1.Name = "label1";
            label1.Size = new Size(297, 55);
            label1.TabIndex = 73;
            label1.Text = "Admin Panel";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Admin_Control_AIUB
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 40, 66);
            ClientSize = new Size(1393, 708);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            Controls.Add(Load_Pre_ACC);
            Controls.Add(pictureBox3);
            Controls.Add(Update_Mem);
            Controls.Add(pictureBox2);
            Controls.Add(Remove_Pre_ACC);
            Controls.Add(pictureBox1);
            Controls.Add(Add_Pre_ACC);
            Controls.Add(GridViewMem);
            Controls.Add(Goback);
            Controls.Add(cross);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin_Control_AIUB";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_Control_AIUB";
            ((System.ComponentModel.ISupportInitialize)GridViewMem).EndInit();
            ((System.ComponentModel.ISupportInitialize)Goback).EndInit();
            ((System.ComponentModel.ISupportInitialize)cross).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView GridViewMem;
        private PictureBox Goback;
        private Button Member;
        private Button ABC_Pre;
        private PictureBox cross;
        private Panel panel1;
        private PictureBox pictureBox4;
        private Button Load_Pre_ACC;
        private PictureBox pictureBox3;
        private Button Update_Mem;
        private PictureBox pictureBox2;
        private Button Remove_Pre_ACC;
        private Button Logout;
        private PictureBox pictureBox1;
        private Button Add_Pre_ACC;
        private Button ARND_Pre;
        private Button ADC_Pre;
        private Label label2;
        private Label label4;
        private Label label1;
    }
}