namespace Final_Project
{
    partial class Volunteer_BUCC_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Volunteer_BUCC_2));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Go_Back = new PictureBox();
            dataGridView1 = new DataGridView();
            Add_Event = new Button();
            cross = new PictureBox();
            panel1 = new Panel();
            Event_Registration2 = new Button();
            Volunteer_Registration = new Button();
            label4 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Go_Back).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cross).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Go_Back
            // 
            Go_Back.BackgroundImage = (Image)resources.GetObject("Go_Back.BackgroundImage");
            Go_Back.BackgroundImageLayout = ImageLayout.Zoom;
            Go_Back.Location = new Point(12, 12);
            Go_Back.Name = "Go_Back";
            Go_Back.Size = new Size(77, 61);
            Go_Back.TabIndex = 115;
            Go_Back.TabStop = false;
            Go_Back.Click += Go_Back_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(0, 40, 66);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 53, 82);
            dataGridViewCellStyle1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(222, 238, 246);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(222, 238, 246);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 40, 66);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.GridColor = Color.FromArgb(0, 53, 82);
            dataGridView1.Location = new Point(109, 181);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1168, 467);
            dataGridView1.TabIndex = 114;
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
            Add_Event.TabIndex = 113;
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
            cross.TabIndex = 112;
            cross.TabStop = false;
            cross.Click += cross_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 53, 82);
            panel1.Controls.Add(Event_Registration2);
            panel1.Controls.Add(Volunteer_Registration);
            panel1.Location = new Point(533, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(511, 67);
            panel1.TabIndex = 111;
            // 
            // Event_Registration2
            // 
            Event_Registration2.BackColor = Color.FromArgb(0, 53, 82);
            Event_Registration2.Cursor = Cursors.Hand;
            Event_Registration2.FlatAppearance.BorderSize = 0;
            Event_Registration2.FlatStyle = FlatStyle.Flat;
            Event_Registration2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Event_Registration2.ForeColor = Color.FromArgb(222, 238, 246);
            Event_Registration2.Location = new Point(21, 10);
            Event_Registration2.Name = "Event_Registration2";
            Event_Registration2.Size = new Size(201, 49);
            Event_Registration2.TabIndex = 27;
            Event_Registration2.Text = "Event Registrations";
            Event_Registration2.UseVisualStyleBackColor = false;
            Event_Registration2.Click += Event_Registration2_Click;
            // 
            // Volunteer_Registration
            // 
            Volunteer_Registration.BackColor = Color.FromArgb(0, 40, 66);
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
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cambria", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(222, 238, 246);
            label4.Location = new Point(113, 116);
            label4.Name = "label4";
            label4.Size = new Size(177, 27);
            label4.TabIndex = 110;
            label4.Text = "EN-QUEUE 2025";
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
            label1.TabIndex = 109;
            label1.Text = "Activity Panel";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Volunteer_BUCC_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 40, 66);
            ClientSize = new Size(1393, 708);
            Controls.Add(Go_Back);
            Controls.Add(dataGridView1);
            Controls.Add(Add_Event);
            Controls.Add(cross);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Volunteer_BUCC_2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Volunteer_BUCC_2";
            ((System.ComponentModel.ISupportInitialize)Go_Back).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cross).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Go_Back;
        private DataGridView dataGridView1;
        private Button Add_Event;
        private PictureBox cross;
        private Panel panel1;
        private Button Event_Registration2;
        private Button Volunteer_Registration;
        private Label label4;
        private Label label1;
    }
}