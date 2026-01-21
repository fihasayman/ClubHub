namespace Final_Project
{
    partial class Volunteer_Activity_ACC_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Volunteer_Activity_ACC_1));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Go_Back = new PictureBox();
            dataGridView2 = new DataGridView();
            Add_Event = new Button();
            cross = new PictureBox();
            panel1 = new Panel();
            Event_Registration1 = new Button();
            Volunteer_Registration = new Button();
            label4 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Go_Back).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            Go_Back.TabIndex = 101;
            Go_Back.TabStop = false;
            Go_Back.Click += Go_Back_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(0, 40, 66);
            dataGridView2.BorderStyle = BorderStyle.Fixed3D;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 53, 82);
            dataGridViewCellStyle3.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(222, 238, 246);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(222, 238, 246);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 40, 66);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.GridColor = Color.FromArgb(0, 53, 82);
            dataGridView2.Location = new Point(109, 181);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1168, 467);
            dataGridView2.TabIndex = 100;
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
            Add_Event.TabIndex = 99;
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
            cross.TabIndex = 98;
            cross.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 53, 82);
            panel1.Controls.Add(Event_Registration1);
            panel1.Controls.Add(Volunteer_Registration);
            panel1.Location = new Point(533, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(511, 67);
            panel1.TabIndex = 97;
            // 
            // Event_Registration1
            // 
            Event_Registration1.BackColor = Color.FromArgb(0, 53, 82);
            Event_Registration1.Cursor = Cursors.Hand;
            Event_Registration1.FlatAppearance.BorderSize = 0;
            Event_Registration1.FlatStyle = FlatStyle.Flat;
            Event_Registration1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Event_Registration1.ForeColor = Color.FromArgb(222, 238, 246);
            Event_Registration1.Location = new Point(21, 10);
            Event_Registration1.Name = "Event_Registration1";
            Event_Registration1.Size = new Size(201, 49);
            Event_Registration1.TabIndex = 27;
            Event_Registration1.Text = "Event Registrations";
            Event_Registration1.UseVisualStyleBackColor = false;
            Event_Registration1.Click += Event_Registration1_Click;
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
            label4.Size = new Size(195, 27);
            label4.TabIndex = 96;
            label4.Text = "Cyber Gaming Fest";
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
            label1.TabIndex = 95;
            label1.Text = "Activity Panel";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Volunteer_Activity_ACC_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 40, 66);
            ClientSize = new Size(1393, 708);
            Controls.Add(Go_Back);
            Controls.Add(dataGridView2);
            Controls.Add(Add_Event);
            Controls.Add(cross);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Volunteer_Activity_ACC_1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Volunteer_Activity_ACC_1";
            ((System.ComponentModel.ISupportInitialize)Go_Back).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)cross).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Go_Back;
        private DataGridView dataGridView2;
        private Button Add_Event;
        private PictureBox cross;
        private Panel panel1;
        private Button Event_Registration1;
        private Button Volunteer_Registration;
        private Label label4;
        private Label label1;
    }
}