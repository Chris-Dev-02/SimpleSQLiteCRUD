namespace SimpleSQLiteCRUD
{
    partial class DataForm
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
            Title_label = new Label();
            Name_label = new Label();
            PhoneNumber_label = new Label();
            Email_label = new Label();
            Name_textBox = new TextBox();
            PhoneNumber_textBox = new TextBox();
            Email_textBox = new TextBox();
            Save_button = new Button();
            SuspendLayout();
            // 
            // Title_label
            // 
            Title_label.AutoSize = true;
            Title_label.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title_label.Location = new Point(116, 9);
            Title_label.Name = "Title_label";
            Title_label.Size = new Size(79, 38);
            Title_label.TabIndex = 0;
            Title_label.Text = "Data";
            // 
            // Name_label
            // 
            Name_label.AutoSize = true;
            Name_label.Location = new Point(26, 60);
            Name_label.Name = "Name_label";
            Name_label.Size = new Size(56, 20);
            Name_label.TabIndex = 1;
            Name_label.Text = "Name: ";
            // 
            // PhoneNumber_label
            // 
            PhoneNumber_label.AutoSize = true;
            PhoneNumber_label.Location = new Point(26, 101);
            PhoneNumber_label.Name = "PhoneNumber_label";
            PhoneNumber_label.Size = new Size(108, 20);
            PhoneNumber_label.TabIndex = 2;
            PhoneNumber_label.Text = "Phone number:";
            // 
            // Email_label
            // 
            Email_label.AutoSize = true;
            Email_label.Location = new Point(26, 150);
            Email_label.Name = "Email_label";
            Email_label.Size = new Size(49, 20);
            Email_label.TabIndex = 3;
            Email_label.Text = "Email:";
            // 
            // Name_textBox
            // 
            Name_textBox.Location = new Point(167, 57);
            Name_textBox.Name = "Name_textBox";
            Name_textBox.Size = new Size(152, 27);
            Name_textBox.TabIndex = 4;
            // 
            // PhoneNumber_textBox
            // 
            PhoneNumber_textBox.Location = new Point(167, 98);
            PhoneNumber_textBox.Name = "PhoneNumber_textBox";
            PhoneNumber_textBox.Size = new Size(152, 27);
            PhoneNumber_textBox.TabIndex = 5;
            // 
            // Email_textBox
            // 
            Email_textBox.Location = new Point(167, 147);
            Email_textBox.Name = "Email_textBox";
            Email_textBox.Size = new Size(152, 27);
            Email_textBox.TabIndex = 6;
            // 
            // Save_button
            // 
            Save_button.Location = new Point(101, 214);
            Save_button.Name = "Save_button";
            Save_button.Size = new Size(94, 29);
            Save_button.TabIndex = 7;
            Save_button.Text = "Save";
            Save_button.UseVisualStyleBackColor = true;
            Save_button.Click += Save_button_Click;
            // 
            // DataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 273);
            Controls.Add(Save_button);
            Controls.Add(Email_textBox);
            Controls.Add(PhoneNumber_textBox);
            Controls.Add(Name_textBox);
            Controls.Add(Email_label);
            Controls.Add(PhoneNumber_label);
            Controls.Add(Name_label);
            Controls.Add(Title_label);
            Name = "DataForm";
            Text = "DataForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title_label;
        private Label Name_label;
        private Label PhoneNumber_label;
        private Label Email_label;
        private TextBox Name_textBox;
        private TextBox PhoneNumber_textBox;
        private TextBox Email_textBox;
        private Button Save_button;
    }
}