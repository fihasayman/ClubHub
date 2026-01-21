namespace Final_Project
{
    partial class Edit3_Event
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit3_Event));
            S_time = new DateTimePicker();
            S_date = new DateTimePicker();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            Volunteer3 = new TextBox();
            Max_Atten3 = new TextBox();
            Description3 = new TextBox();
            Location3 = new TextBox();
            Event_title3 = new TextBox();
            cross = new PictureBox();
            Save3 = new Button();
            Cancel = new Button();
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            Title = new Label();
            label4 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)cross).BeginInit();
            SuspendLayout();
            // 
            // S_time
            // 
            S_time.CalendarFont = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            S_time.CustomFormat = " hh:mm tt";
            S_time.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            S_time.Format = DateTimePickerFormat.Custom;
            S_time.Location = new Point(404, 225);
            S_time.Name = "S_time";
            S_time.ShowUpDown = true;
            S_time.Size = new Size(325, 29);
            S_time.TabIndex = 94;
            // 
            // S_date
            // 
            S_date.CalendarFont = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            S_date.CalendarForeColor = Color.SteelBlue;
            S_date.CalendarMonthBackground = Color.FromArgb(128, 128, 255);
            S_date.CalendarTitleBackColor = Color.FromArgb(255, 128, 255);
            S_date.CalendarTitleForeColor = Color.FromArgb(192, 192, 255);
            S_date.CalendarTrailingForeColor = Color.FromArgb(128, 128, 255);
            S_date.Cursor = Cursors.Hand;
            S_date.CustomFormat = " dd MMM yyyy";
            S_date.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            S_date.Format = DateTimePickerFormat.Custom;
            S_date.Location = new Point(43, 225);
            S_date.MaxDate = new DateTime(2028, 12, 31, 0, 0, 0, 0);
            S_date.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            S_date.Name = "S_date";
            S_date.Size = new Size(325, 29);
            S_date.TabIndex = 93;
            S_date.ValueChanged += S_date_ValueChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(222, 238, 246);
            panel4.Location = new Point(772, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(8, 650);
            panel4.TabIndex = 92;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(222, 238, 246);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(8, 650);
            panel3.TabIndex = 91;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(222, 238, 246);
            panel2.Location = new Point(0, 642);
            panel2.Name = "panel2";
            panel2.Size = new Size(780, 8);
            panel2.TabIndex = 90;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(222, 238, 246);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 8);
            panel1.TabIndex = 89;
            // 
            // Volunteer3
            // 
            Volunteer3.BackColor = Color.FromArgb(0, 53, 82);
            Volunteer3.BorderStyle = BorderStyle.None;
            Volunteer3.Font = new Font("Cambria", 12F);
            Volunteer3.ForeColor = Color.White;
            Volunteer3.Location = new Point(404, 516);
            Volunteer3.Multiline = true;
            Volunteer3.Name = "Volunteer3";
            Volunteer3.Size = new Size(325, 27);
            Volunteer3.TabIndex = 88;
            // 
            // Max_Atten3
            // 
            Max_Atten3.BackColor = Color.FromArgb(0, 53, 82);
            Max_Atten3.BorderStyle = BorderStyle.None;
            Max_Atten3.Font = new Font("Cambria", 12F);
            Max_Atten3.ForeColor = Color.White;
            Max_Atten3.Location = new Point(43, 516);
            Max_Atten3.Multiline = true;
            Max_Atten3.Name = "Max_Atten3";
            Max_Atten3.Size = new Size(325, 27);
            Max_Atten3.TabIndex = 87;
            // 
            // Description3
            // 
            Description3.BackColor = Color.FromArgb(0, 53, 82);
            Description3.BorderStyle = BorderStyle.None;
            Description3.Font = new Font("Cambria", 12F);
            Description3.ForeColor = Color.White;
            Description3.Location = new Point(43, 400);
            Description3.Multiline = true;
            Description3.Name = "Description3";
            Description3.Size = new Size(686, 68);
            Description3.TabIndex = 86;
            // 
            // Location3
            // 
            Location3.BackColor = Color.FromArgb(0, 53, 82);
            Location3.BorderStyle = BorderStyle.None;
            Location3.Font = new Font("Cambria", 12F);
            Location3.ForeColor = Color.White;
            Location3.Location = new Point(43, 313);
            Location3.Multiline = true;
            Location3.Name = "Location3";
            Location3.Size = new Size(686, 27);
            Location3.TabIndex = 85;
            // 
            // Event_title3
            // 
            Event_title3.BackColor = Color.FromArgb(0, 53, 82);
            Event_title3.BorderStyle = BorderStyle.None;
            Event_title3.Font = new Font("Cambria", 12F);
            Event_title3.ForeColor = Color.White;
            Event_title3.Location = new Point(43, 146);
            Event_title3.Multiline = true;
            Event_title3.Name = "Event_title3";
            Event_title3.Size = new Size(686, 27);
            Event_title3.TabIndex = 84;
            // 
            // cross
            // 
            cross.BackColor = Color.FromArgb(0, 40, 66);
            cross.BackgroundImage = (Image)resources.GetObject("cross.BackgroundImage");
            cross.BackgroundImageLayout = ImageLayout.Zoom;
            cross.Location = new Point(742, 14);
            cross.Name = "cross";
            cross.Size = new Size(24, 24);
            cross.TabIndex = 83;
            cross.TabStop = false;
            cross.Click += cross_Click_1;
            // 
            // Save3
            // 
            Save3.BackColor = Color.FromArgb(222, 238, 246);
            Save3.FlatStyle = FlatStyle.Flat;
            Save3.Font = new Font("Cambria", 12F, FontStyle.Bold);
            Save3.ForeColor = Color.FromArgb(0, 40, 66);
            Save3.Location = new Point(586, 579);
            Save3.Name = "Save3";
            Save3.Size = new Size(143, 43);
            Save3.TabIndex = 81;
            Save3.Text = "Save Changes";
            Save3.UseVisualStyleBackColor = false;
            Save3.Click += Save3_Click;
            // 
            // Cancel
            // 
            Cancel.BackColor = Color.FromArgb(0, 53, 82);
            Cancel.FlatStyle = FlatStyle.Flat;
            Cancel.Font = new Font("Cambria", 12F, FontStyle.Bold);
            Cancel.ForeColor = Color.FromArgb(222, 238, 246);
            Cancel.Location = new Point(453, 580);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(113, 42);
            Cancel.TabIndex = 82;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = false;
            Cancel.Click += Cancel_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(404, 490);
            label7.Name = "label7";
            label7.Size = new Size(184, 23);
            label7.TabIndex = 80;
            label7.Text = "Volunteers Needed";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(43, 490);
            label8.Name = "label8";
            label8.Size = new Size(146, 23);
            label8.TabIndex = 79;
            label8.Text = "Max Attendees";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(43, 374);
            label6.Name = "label6";
            label6.Size = new Size(116, 23);
            label6.TabIndex = 78;
            label6.Text = "Description";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(43, 287);
            label5.Name = "label5";
            label5.Size = new Size(88, 23);
            label5.TabIndex = 77;
            label5.Text = "Location";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(404, 203);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 76;
            label2.Text = "Time";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(43, 203);
            label3.Name = "label3";
            label3.Size = new Size(53, 23);
            label3.TabIndex = 75;
            label3.Text = "Date";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.White;
            Title.Location = new Point(43, 120);
            Title.Name = "Title";
            Title.Size = new Size(109, 23);
            Title.TabIndex = 74;
            Title.Text = "Event Title";
            Title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(222, 238, 246);
            label4.Location = new Point(43, 69);
            label4.Name = "label4";
            label4.Size = new Size(169, 21);
            label4.TabIndex = 73;
            label4.Text = "Update event details";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 33);
            label1.Name = "label1";
            label1.Size = new Size(144, 33);
            label1.TabIndex = 72;
            label1.Text = "Edit Event";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Edit3_Event
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 40, 66);
            ClientSize = new Size(780, 650);
            Controls.Add(S_time);
            Controls.Add(S_date);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Volunteer3);
            Controls.Add(Max_Atten3);
            Controls.Add(Description3);
            Controls.Add(Location3);
            Controls.Add(Event_title3);
            Controls.Add(cross);
            Controls.Add(Save3);
            Controls.Add(Cancel);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(Title);
            Controls.Add(label4);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Edit3_Event";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit3_Event";
            Load += Edit3_Event_Load;
            ((System.ComponentModel.ISupportInitialize)cross).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker E_time2;
        private DateTimePicker E_date2;
        private DateTimePicker S_time2;
        private DateTimePicker S_date2;
        private DateTimePicker S_time;
        private DateTimePicker S_date;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private TextBox Volunteer3;
        private TextBox Max_Atten3;
        private TextBox Description3;
        private TextBox Location3;
        private TextBox Event_title3;
        private PictureBox cross;
        private Button Save3;
        private Button Cancel;
        private Label label7;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label Title;
        private Label label4;
        private Label label1;
    }
}