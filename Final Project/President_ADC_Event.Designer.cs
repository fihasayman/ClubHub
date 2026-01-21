namespace Final_Project
{
    partial class President_ADC_Event
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(President_ADC_Event));
            pictureBox2 = new PictureBox();
            Add_Event = new Button();
            cross = new PictureBox();
            panel1 = new Panel();
            Member = new Button();
            Applicant = new Button();
            button3 = new Button();
            label4 = new Label();
            label1 = new Label();
            Goback = new PictureBox();
            panel3 = new Panel();
            pictureBox6 = new PictureBox();
            Activity_ADC_1 = new Button();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            pictureBox3 = new PictureBox();
            VolunteerCount = new Label();
            Max_Attendees = new Label();
            pictureBox9 = new PictureBox();
            EditADC = new Button();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            label10 = new Label();
            pictureBox12 = new PictureBox();
            label11 = new Label();
            pictureBox13 = new PictureBox();
            label12 = new Label();
            label13 = new Label();
            label20 = new Label();
            label18 = new Label();
            pictureBox19 = new PictureBox();
            label17 = new Label();
            pictureBox18 = new PictureBox();
            label16 = new Label();
            pictureBox17 = new PictureBox();
            pictureBox16 = new PictureBox();
            Edit2 = new Button();
            pictureBox15 = new PictureBox();
            label14 = new Label();
            panel4 = new Panel();
            pictureBox7 = new PictureBox();
            Activity_ADC2 = new Button();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cross).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Goback).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(222, 238, 246);
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(1151, 85);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 36);
            pictureBox2.TabIndex = 51;
            pictureBox2.TabStop = false;
            // 
            // Add_Event
            // 
            Add_Event.BackColor = Color.FromArgb(222, 238, 246);
            Add_Event.FlatStyle = FlatStyle.Flat;
            Add_Event.Font = new Font("Cambria", 12F, FontStyle.Bold);
            Add_Event.ForeColor = Color.FromArgb(0, 40, 66);
            Add_Event.Location = new Point(1140, 74);
            Add_Event.Name = "Add_Event";
            Add_Event.Size = new Size(162, 57);
            Add_Event.TabIndex = 50;
            Add_Event.Text = "Add Event";
            Add_Event.TextAlign = ContentAlignment.MiddleRight;
            Add_Event.UseVisualStyleBackColor = false;
            Add_Event.Click += Add_Event_Click;
            // 
            // cross
            // 
            cross.BackColor = Color.FromArgb(0, 40, 66);
            cross.BackgroundImage = (Image)resources.GetObject("cross.BackgroundImage");
            cross.BackgroundImageLayout = ImageLayout.Zoom;
            cross.Location = new Point(1345, 12);
            cross.Name = "cross";
            cross.Size = new Size(27, 27);
            cross.TabIndex = 47;
            cross.TabStop = false;
            cross.Click += cross_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 53, 82);
            panel1.Controls.Add(Member);
            panel1.Controls.Add(Applicant);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(447, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(648, 67);
            panel1.TabIndex = 46;
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
            Applicant.BackColor = Color.FromArgb(0, 53, 82);
            Applicant.Cursor = Cursors.Hand;
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
            Applicant.Click += Applicant_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 40, 66);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(222, 238, 246);
            button3.Location = new Point(439, 10);
            button3.Name = "button3";
            button3.Size = new Size(184, 49);
            button3.TabIndex = 29;
            button3.Text = "Events";
            button3.UseVisualStyleBackColor = false;
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
            label4.TabIndex = 45;
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
            label1.TabIndex = 44;
            label1.Text = "President Panel";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Goback
            // 
            Goback.BackColor = Color.Transparent;
            Goback.BackgroundImage = (Image)resources.GetObject("Goback.BackgroundImage");
            Goback.BackgroundImageLayout = ImageLayout.Zoom;
            Goback.Location = new Point(12, 197);
            Goback.Name = "Goback";
            Goback.Size = new Size(67, 55);
            Goback.TabIndex = 48;
            Goback.TabStop = false;
            Goback.Click += Goback_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 53, 82);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(Activity_ADC_1);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(VolunteerCount);
            panel3.Controls.Add(Max_Attendees);
            panel3.Controls.Add(pictureBox9);
            panel3.Controls.Add(EditADC);
            panel3.Controls.Add(pictureBox10);
            panel3.Controls.Add(pictureBox11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(pictureBox12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(pictureBox13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label13);
            panel3.Location = new Point(118, 201);
            panel3.Name = "panel3";
            panel3.Size = new Size(1155, 282);
            panel3.TabIndex = 89;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(222, 238, 246);
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(962, 230);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 30);
            pictureBox6.TabIndex = 101;
            pictureBox6.TabStop = false;
            // 
            // Activity_ADC_1
            // 
            Activity_ADC_1.BackColor = Color.FromArgb(222, 238, 246);
            Activity_ADC_1.FlatStyle = FlatStyle.Flat;
            Activity_ADC_1.Font = new Font("Cambria", 12F, FontStyle.Bold);
            Activity_ADC_1.ForeColor = Color.FromArgb(0, 40, 66);
            Activity_ADC_1.Location = new Point(951, 223);
            Activity_ADC_1.Name = "Activity_ADC_1";
            Activity_ADC_1.Size = new Size(183, 43);
            Activity_ADC_1.TabIndex = 102;
            Activity_ADC_1.Text = "Event Activity";
            Activity_ADC_1.TextAlign = ContentAlignment.MiddleRight;
            Activity_ADC_1.UseVisualStyleBackColor = false;
            Activity_ADC_1.Click += Activity_ADC_1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 53, 82);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(779, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 102;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(0, 53, 82);
            label8.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(222, 238, 246);
            label8.Location = new Point(490, 173);
            label8.Name = "label8";
            label8.Size = new Size(656, 23);
            label8.TabIndex = 86;
            label8.Text = "Thrilled to welcome newest batch of dreamers, storytellers and performers.";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(0, 53, 82);
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(492, 120);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.TabIndex = 101;
            pictureBox3.TabStop = false;
            // 
            // VolunteerCount
            // 
            VolunteerCount.AutoSize = true;
            VolunteerCount.BackColor = Color.FromArgb(0, 53, 82);
            VolunteerCount.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VolunteerCount.ForeColor = Color.FromArgb(222, 238, 246);
            VolunteerCount.Location = new Point(805, 124);
            VolunteerCount.Name = "VolunteerCount";
            VolunteerCount.Size = new Size(94, 23);
            VolunteerCount.TabIndex = 100;
            VolunteerCount.Text = "Volunteer";
            VolunteerCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Max_Attendees
            // 
            Max_Attendees.AutoSize = true;
            Max_Attendees.BackColor = Color.FromArgb(0, 53, 82);
            Max_Attendees.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Max_Attendees.ForeColor = Color.FromArgb(222, 238, 246);
            Max_Attendees.Location = new Point(525, 124);
            Max_Attendees.Name = "Max_Attendees";
            Max_Attendees.Size = new Size(140, 23);
            Max_Attendees.TabIndex = 99;
            Max_Attendees.Text = "Max_Attendees";
            Max_Attendees.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.FromArgb(222, 238, 246);
            pictureBox9.BackgroundImage = (Image)resources.GetObject("pictureBox9.BackgroundImage");
            pictureBox9.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox9.Location = new Point(503, 230);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(30, 30);
            pictureBox9.TabIndex = 44;
            pictureBox9.TabStop = false;
            // 
            // EditADC
            // 
            EditADC.BackColor = Color.FromArgb(222, 238, 246);
            EditADC.FlatStyle = FlatStyle.Flat;
            EditADC.Font = new Font("Cambria", 12F, FontStyle.Bold);
            EditADC.ForeColor = Color.FromArgb(0, 40, 66);
            EditADC.Location = new Point(492, 223);
            EditADC.Name = "EditADC";
            EditADC.Size = new Size(113, 43);
            EditADC.TabIndex = 44;
            EditADC.Text = "Edit";
            EditADC.TextAlign = ContentAlignment.MiddleRight;
            EditADC.UseVisualStyleBackColor = false;
            EditADC.Click += EditADC_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.BackgroundImage = (Image)resources.GetObject("pictureBox10.BackgroundImage");
            pictureBox10.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox10.Location = new Point(0, 0);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(466, 279);
            pictureBox10.TabIndex = 0;
            pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.FromArgb(0, 53, 82);
            pictureBox11.BackgroundImage = (Image)resources.GetObject("pictureBox11.BackgroundImage");
            pictureBox11.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox11.Location = new Point(962, 69);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(30, 30);
            pictureBox11.TabIndex = 83;
            pictureBox11.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(0, 53, 82);
            label10.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(492, 24);
            label10.Name = "label10";
            label10.Size = new Size(434, 27);
            label10.TabIndex = 77;
            label10.Text = "AIUB Drama Club Fall 25-26 Orientation";
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = Color.FromArgb(0, 53, 82);
            pictureBox12.BackgroundImage = (Image)resources.GetObject("pictureBox12.BackgroundImage");
            pictureBox12.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox12.Location = new Point(779, 69);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(30, 30);
            pictureBox12.TabIndex = 82;
            pictureBox12.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(0, 53, 82);
            label11.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(222, 238, 246);
            label11.Location = new Point(525, 76);
            label11.Name = "label11";
            label11.Size = new Size(177, 23);
            label11.TabIndex = 78;
            label11.Text = "12 November, 2025";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox13
            // 
            pictureBox13.BackColor = Color.FromArgb(0, 53, 82);
            pictureBox13.BackgroundImage = (Image)resources.GetObject("pictureBox13.BackgroundImage");
            pictureBox13.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox13.Location = new Point(492, 69);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(30, 30);
            pictureBox13.TabIndex = 81;
            pictureBox13.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(0, 53, 82);
            label12.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(222, 238, 246);
            label12.Location = new Point(812, 73);
            label12.Name = "label12";
            label12.Size = new Size(79, 23);
            label12.TabIndex = 79;
            label12.Text = "4:30 PM";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(0, 53, 82);
            label13.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(222, 238, 246);
            label13.Location = new Point(995, 64);
            label13.Name = "label13";
            label13.Size = new Size(141, 46);
            label13.TabIndex = 80;
            label13.Text = "Multipurpose\r\nHall, D Building";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.FromArgb(0, 53, 82);
            label20.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(222, 238, 246);
            label20.Location = new Point(995, 73);
            label20.Name = "label20";
            label20.Size = new Size(110, 23);
            label20.TabIndex = 80;
            label20.Text = "Auditorium";
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.FromArgb(0, 53, 82);
            label18.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(222, 238, 246);
            label18.Location = new Point(812, 73);
            label18.Name = "label18";
            label18.Size = new Size(79, 23);
            label18.TabIndex = 79;
            label18.Text = "3:00 PM";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox19
            // 
            pictureBox19.BackColor = Color.FromArgb(0, 53, 82);
            pictureBox19.BackgroundImage = (Image)resources.GetObject("pictureBox19.BackgroundImage");
            pictureBox19.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox19.Location = new Point(492, 69);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new Size(30, 30);
            pictureBox19.TabIndex = 81;
            pictureBox19.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.FromArgb(0, 53, 82);
            label17.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(222, 238, 246);
            label17.Location = new Point(525, 76);
            label17.Name = "label17";
            label17.Size = new Size(192, 23);
            label17.TabIndex = 78;
            label17.Text = "8-10 December, 2025";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox18
            // 
            pictureBox18.BackColor = Color.FromArgb(0, 53, 82);
            pictureBox18.BackgroundImage = (Image)resources.GetObject("pictureBox18.BackgroundImage");
            pictureBox18.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox18.Location = new Point(779, 69);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(30, 30);
            pictureBox18.TabIndex = 82;
            pictureBox18.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(0, 53, 82);
            label16.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.White;
            label16.Location = new Point(492, 24);
            label16.Name = "label16";
            label16.Size = new Size(355, 27);
            label16.TabIndex = 77;
            label16.Text = "ADC National Drama Fiesta 2025";
            // 
            // pictureBox17
            // 
            pictureBox17.BackColor = Color.FromArgb(0, 53, 82);
            pictureBox17.BackgroundImage = (Image)resources.GetObject("pictureBox17.BackgroundImage");
            pictureBox17.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox17.Location = new Point(962, 69);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(30, 30);
            pictureBox17.TabIndex = 83;
            pictureBox17.TabStop = false;
            // 
            // pictureBox16
            // 
            pictureBox16.BackgroundImage = (Image)resources.GetObject("pictureBox16.BackgroundImage");
            pictureBox16.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox16.Location = new Point(0, 0);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(466, 282);
            pictureBox16.TabIndex = 0;
            pictureBox16.TabStop = false;
            // 
            // Edit2
            // 
            Edit2.BackColor = Color.FromArgb(222, 238, 246);
            Edit2.FlatStyle = FlatStyle.Flat;
            Edit2.Font = new Font("Cambria", 12F, FontStyle.Bold);
            Edit2.ForeColor = Color.FromArgb(0, 40, 66);
            Edit2.Location = new Point(492, 223);
            Edit2.Name = "Edit2";
            Edit2.Size = new Size(113, 43);
            Edit2.TabIndex = 44;
            Edit2.Text = "Edit";
            Edit2.TextAlign = ContentAlignment.MiddleRight;
            Edit2.UseVisualStyleBackColor = false;
            Edit2.Click += Edit2_Click;
            // 
            // pictureBox15
            // 
            pictureBox15.BackColor = Color.FromArgb(222, 238, 246);
            pictureBox15.BackgroundImage = (Image)resources.GetObject("pictureBox15.BackgroundImage");
            pictureBox15.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox15.Location = new Point(503, 230);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(30, 30);
            pictureBox15.TabIndex = 44;
            pictureBox15.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(0, 53, 82);
            label14.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(222, 238, 246);
            label14.Location = new Point(490, 173);
            label14.Name = "label14";
            label14.Size = new Size(508, 23);
            label14.TabIndex = 86;
            label14.Text = "One of Bangladesh’s largest youth-driven theatre festivals.";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 53, 82);
            panel4.Controls.Add(pictureBox7);
            panel4.Controls.Add(Activity_ADC2);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(pictureBox5);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(pictureBox15);
            panel4.Controls.Add(Edit2);
            panel4.Controls.Add(pictureBox16);
            panel4.Controls.Add(pictureBox17);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(pictureBox18);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(pictureBox19);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(label20);
            panel4.Location = new Point(118, 539);
            panel4.Name = "panel4";
            panel4.Size = new Size(1155, 282);
            panel4.TabIndex = 90;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(222, 238, 246);
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Location = new Point(962, 230);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(30, 30);
            pictureBox7.TabIndex = 103;
            pictureBox7.TabStop = false;
            // 
            // Activity_ADC2
            // 
            Activity_ADC2.BackColor = Color.FromArgb(222, 238, 246);
            Activity_ADC2.FlatStyle = FlatStyle.Flat;
            Activity_ADC2.Font = new Font("Cambria", 12F, FontStyle.Bold);
            Activity_ADC2.ForeColor = Color.FromArgb(0, 40, 66);
            Activity_ADC2.Location = new Point(951, 223);
            Activity_ADC2.Name = "Activity_ADC2";
            Activity_ADC2.Size = new Size(183, 43);
            Activity_ADC2.TabIndex = 104;
            Activity_ADC2.Text = "Event Activity";
            Activity_ADC2.TextAlign = ContentAlignment.MiddleRight;
            Activity_ADC2.UseVisualStyleBackColor = false;
            Activity_ADC2.Click += Activity_ADC2_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(0, 53, 82);
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(779, 120);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.TabIndex = 106;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(0, 53, 82);
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(492, 120);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.TabIndex = 105;
            pictureBox5.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 53, 82);
            label2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(222, 238, 246);
            label2.Location = new Point(805, 124);
            label2.Name = "label2";
            label2.Size = new Size(94, 23);
            label2.TabIndex = 104;
            label2.Text = "Volunteer";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 53, 82);
            label3.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(222, 238, 246);
            label3.Location = new Point(525, 124);
            label3.Name = "label3";
            label3.Size = new Size(140, 23);
            label3.TabIndex = 103;
            label3.Text = "Max_Attendees";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // President_ADC_Event
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(0, 40, 66);
            ClientSize = new Size(1393, 708);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(pictureBox2);
            Controls.Add(Add_Event);
            Controls.Add(cross);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(Goback);
            FormBorderStyle = FormBorderStyle.None;
            Name = "President_ADC_Event";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "President_ADC_Event";
            Load += President_ADC_Event_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)cross).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Goback).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Button Add_Event;
        private PictureBox cross;
        private Panel panel1;
        private Button Member;
        private Button Applicant;
        private Button button3;
        private Label label4;
        private Label label1;
        private PictureBox Goback;
        private Panel panel3;
        private Label label8;
        private PictureBox pictureBox9;
        private Button EditADC;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private Label label10;
        private PictureBox pictureBox12;
        private Label label11;
        private PictureBox pictureBox13;
        private Label label12;
        private Label label13;
        private Label label20;
        private Label label18;
        private PictureBox pictureBox19;
        private Label label17;
        private PictureBox pictureBox18;
        private Label label16;
        private PictureBox pictureBox17;
        private PictureBox pictureBox16;
        private Button Edit2;
        private PictureBox pictureBox15;
        private Label label14;
        private Panel panel4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label VolunteerCount;
        private Label Max_Attendees;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox6;
        private Button Activity_ADC_1;
        private PictureBox pictureBox7;
        private Button Activity_ADC2;
    }
}