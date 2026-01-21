namespace Final_Project
{
    partial class Activity_ABC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Activity_ABC));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Add_Event = new Button();
            cross = new PictureBox();
            panel1 = new Panel();
            Event_Registration = new Button();
            Volunteer_Registration = new Button();
            label4 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)cross).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Add_Event
            // 
            Add_Event.BackColor = Color.FromArgb(222, 238, 246);
            Add_Event.FlatStyle = FlatStyle.Flat;
            Add_Event.Font = new Font("Cambria", 12F, FontStyle.Bold);
            Add_Event.ForeColor = Color.FromArgb(0, 40, 66);
            Add_Event.Location = new Point(1085, 80);
            Add_Event.Name = "Add_Event";
            Add_Event.Size = new Size(192, 57);
            Add_Event.TabIndex = 56;
            Add_Event.Text = "Refresh";
            Add_Event.UseVisualStyleBackColor = false;
            Add_Event.Click += Add_Event_Click;
            // 
            // cross
            // 
            cross.BackColor = Color.FromArgb(0, 40, 66);
            cross.BackgroundImage = (Image)resources.GetObject("cross.BackgroundImage");
            cross.BackgroundImageLayout = ImageLayout.Zoom;
            cross.Location = new Point(1354, 12);
            cross.Name = "cross";
            cross.Size = new Size(27, 27);
            cross.TabIndex = 55;
            cross.TabStop = false;
            cross.Click += cross_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 53, 82);
            panel1.Controls.Add(Event_Registration);
            panel1.Controls.Add(Volunteer_Registration);
            panel1.Location = new Point(533, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(511, 67);
            panel1.TabIndex = 54;
            // 
            // Event_Registration
            // 
            Event_Registration.BackColor = Color.FromArgb(0, 40, 66);
            Event_Registration.Cursor = Cursors.Hand;
            Event_Registration.FlatAppearance.BorderSize = 0;
            Event_Registration.FlatStyle = FlatStyle.Flat;
            Event_Registration.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Event_Registration.ForeColor = Color.FromArgb(222, 238, 246);
            Event_Registration.Location = new Point(21, 10);
            Event_Registration.Name = "Event_Registration";
            Event_Registration.Size = new Size(201, 49);
            Event_Registration.TabIndex = 27;
            Event_Registration.Text = "Event Registrations";
            Event_Registration.UseVisualStyleBackColor = false;
            // 
            // Volunteer_Registration
            // 
            Volunteer_Registration.BackColor = Color.FromArgb(0, 53, 82);
            Volunteer_Registration.Cursor = Cursors.Hand;
            Volunteer_Registration.FlatAppearance.BorderSize = 0;
            Volunteer_Registration.FlatStyle = FlatStyle.Flat;
            Volunteer_Registration.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Volunteer_Registration.ForeColor = Color.FromArgb(222, 238, 246);
            Volunteer_Registration.Location = new Point(254, 10);
            Volunteer_Registration.Name = "Volunteer_Registration";
            Volunteer_Registration.Size = new Size(233, 49);
            Volunteer_Registration.TabIndex = 28;
            Volunteer_Registration.Text = "Volunteer Registrations";
            Volunteer_Registration.UseVisualStyleBackColor = false;
            Volunteer_Registration.Click += Volunteer_Registration_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cambria", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(222, 238, 246);
            label4.Location = new Point(113, 116);
            label4.Name = "label4";
            label4.Size = new Size(387, 27);
            label4.TabIndex = 53;
            label4.Text = "Workshop on Experimental Marketing";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(109, 52);
            label1.Name = "label1";
            label1.Size = new Size(319, 55);
            label1.TabIndex = 52;
            label1.Text = "Activity Panel";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(0, 40, 66);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 53, 82);
            dataGridViewCellStyle2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(222, 238, 246);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(222, 238, 246);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 40, 66);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.FromArgb(0, 53, 82);
            dataGridView1.Location = new Point(109, 181);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1168, 467);
            dataGridView1.TabIndex = 59;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 61);
            pictureBox1.TabIndex = 87;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Activity_ABC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 40, 66);
            ClientSize = new Size(1393, 708);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(Add_Event);
            Controls.Add(cross);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Activity_ABC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Activity_ABC";
            Load += Activity_ABC_Load;
            ((System.ComponentModel.ISupportInitialize)cross).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Add_Event;
        private PictureBox cross;
        private Panel panel1;
        private Button Event_Registration;
        private Button Volunteer_Registration;
        private Label label4;
        private Label label1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
    }
}