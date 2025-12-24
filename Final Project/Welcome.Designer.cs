namespace Final_Project
{
    partial class Welcome
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
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(256, 114);
            button2.Name = "button2";
            button2.Size = new Size(160, 98);
            button2.TabIndex = 1;
            button2.Text = "Modon";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(256, 239);
            button1.Name = "button1";
            button1.Size = new Size(160, 157);
            button1.TabIndex = 2;
            button1.Text = "ek number er";
            button1.UseVisualStyleBackColor = true;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 34, 21);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Welcome";
            Text = "Welcome";
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button1;
    }
}