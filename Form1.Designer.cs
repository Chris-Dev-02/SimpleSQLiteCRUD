namespace SimpleSQLiteCRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title_label = new Label();
            Contacts_dataGridView = new DataGridView();
            Add_button = new Button();
            Update_button = new Button();
            Delete_button = new Button();
            DeleteAll_button = new Button();
            ((System.ComponentModel.ISupportInitialize)Contacts_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // Title_label
            // 
            Title_label.AutoSize = true;
            Title_label.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title_label.Location = new Point(284, 9);
            Title_label.Name = "Title_label";
            Title_label.Size = new Size(194, 38);
            Title_label.TabIndex = 0;
            Title_label.Text = "Contact Book";
            // 
            // Contacts_dataGridView
            // 
            Contacts_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Contacts_dataGridView.Location = new Point(25, 65);
            Contacts_dataGridView.Name = "Contacts_dataGridView";
            Contacts_dataGridView.ReadOnly = true;
            Contacts_dataGridView.RowHeadersWidth = 51;
            Contacts_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Contacts_dataGridView.Size = new Size(752, 303);
            Contacts_dataGridView.TabIndex = 1;
            // 
            // Add_button
            // 
            Add_button.Location = new Point(25, 394);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(94, 29);
            Add_button.TabIndex = 2;
            Add_button.Text = "Add";
            Add_button.UseVisualStyleBackColor = true;
            Add_button.Click += Add_button_Click;
            // 
            // Update_button
            // 
            Update_button.Location = new Point(125, 394);
            Update_button.Name = "Update_button";
            Update_button.Size = new Size(94, 29);
            Update_button.TabIndex = 3;
            Update_button.Text = "Update";
            Update_button.UseVisualStyleBackColor = true;
            Update_button.Click += Update_button_Click;
            // 
            // Delete_button
            // 
            Delete_button.Location = new Point(225, 394);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(94, 29);
            Delete_button.TabIndex = 4;
            Delete_button.Text = "Delete";
            Delete_button.UseVisualStyleBackColor = true;
            Delete_button.Click += Delete_button_Click;
            // 
            // DeleteAll_button
            // 
            DeleteAll_button.Location = new Point(325, 394);
            DeleteAll_button.Name = "DeleteAll_button";
            DeleteAll_button.Size = new Size(94, 29);
            DeleteAll_button.TabIndex = 5;
            DeleteAll_button.Text = "Delete all";
            DeleteAll_button.UseVisualStyleBackColor = true;
            DeleteAll_button.Click += DeleteAll_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DeleteAll_button);
            Controls.Add(Delete_button);
            Controls.Add(Update_button);
            Controls.Add(Add_button);
            Controls.Add(Contacts_dataGridView);
            Controls.Add(Title_label);
            Name = "Form1";
            Text = "Contact Book";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Contacts_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title_label;
        private DataGridView Contacts_dataGridView;
        private Button Add_button;
        private Button Update_button;
        private Button Delete_button;
        private Button DeleteAll_button;
    }
}
