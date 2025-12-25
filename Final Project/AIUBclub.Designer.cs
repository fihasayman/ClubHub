namespace Final_Project
{
    partial class AIUBclub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AIUBclub));
            cross = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            AIUB = new Button();
            View = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)cross).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cross
            // 
            cross.BackColor = Color.FromArgb(13, 34, 21);
            cross.BackgroundImage = (Image)resources.GetObject("cross.BackgroundImage");
            cross.BackgroundImageLayout = ImageLayout.Zoom;
            cross.Location = new Point(1241, 12);
            cross.Name = "cross";
            cross.Size = new Size(27, 27);
            cross.TabIndex = 8;
            cross.TabStop = false;
            cross.Click += cross_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(575, 52);
            label1.Name = "label1";
            label1.Size = new Size(379, 110);
            label1.TabIndex = 9;
            label1.Text = "Welcome to \r\nAIUB Club List";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.wp9396725__1_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(550, 622);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Honeydew;
            label2.Location = new Point(575, 191);
            label2.Name = "label2";
            label2.Size = new Size(457, 23);
            label2.TabIndex = 11;
            label2.Text = "Choose your path and grow building connections";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(582, 175);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 2);
            panel1.TabIndex = 12;
            // 
            // AIUB
            // 
            AIUB.BackColor = Color.Honeydew;
            AIUB.Cursor = Cursors.Hand;
            AIUB.FlatStyle = FlatStyle.Flat;
            AIUB.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AIUB.ForeColor = Color.FromArgb(13, 34, 21);
            AIUB.Location = new Point(922, 249);
            AIUB.Name = "AIUB";
            AIUB.Size = new Size(156, 55);
            AIUB.TabIndex = 13;
            AIUB.Text = "Join";
            AIUB.UseVisualStyleBackColor = false;
            // 
            // View
            // 
            View.BackColor = Color.Honeydew;
            View.Cursor = Cursors.Hand;
            View.FlatStyle = FlatStyle.Flat;
            View.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            View.ForeColor = Color.FromArgb(13, 34, 21);
            View.Location = new Point(1097, 249);
            View.Name = "View";
            View.Size = new Size(156, 55);
            View.TabIndex = 14;
            View.Text = "View";
            View.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Honeydew;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(13, 34, 21);
            button2.Location = new Point(803, 409);
            button2.Name = "button2";
            button2.Size = new Size(450, 58);
            button2.TabIndex = 15;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Honeydew;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(13, 34, 21);
            button3.Location = new Point(575, 499);
            button3.Name = "button3";
            button3.Size = new Size(450, 58);
            button3.TabIndex = 16;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(669, 249);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 17;
            label3.Text = "label3";
            // 
            // AIUBclub
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 34, 21);
            ClientSize = new Size(1280, 601);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(View);
            Controls.Add(AIUB);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(cross);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AIUBclub";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club";
            ((System.ComponentModel.ISupportInitialize)cross).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox cross;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel1;
        private Button AIUB;
        private Button View;
        private Button button2;
        private Button button3;
        private Label label3;
    }
}