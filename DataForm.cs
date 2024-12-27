using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSQLiteCRUD
{
    public partial class DataForm : Form
    {
        Form1? MainFormRef;
        int? Id;
        public DataForm()
        {
            InitializeComponent();
        }

        public DataForm(Form1? mainFormRef)
        {
            InitializeComponent();
            MainFormRef = mainFormRef;
        }

        public DataForm(Form1? mainFormRef, int? id)
        {
            InitializeComponent();
            MainFormRef = mainFormRef;
            Id = id;
            GetDataById();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            if (Id != null) { UpdateData(); } else { SaveData(); }
        }

        private void SaveData()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=ContactBook.db;Version=3"))
            {
                String query = "INSERT INTO Contacts ([Name],[PhoneNumber],[Email]) VALUES (@Name, @PhoneNumber, @Email)";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Name", Name_textBox.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber_textBox.Text);
                    command.Parameters.AddWithValue("@Email", Email_textBox.Text );

                    command.ExecuteNonQuery();
                }
            }
            if (MainFormRef != null) 
            {
                MainFormRef.LoadContactDataOnDataGridView();
                this.Close();
                MessageBox.Show("Contact was added successfully", "Succces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateData()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=ContactBook.db;Version=3"))
            {
                String query = "UPDATE Contacts SET Name = @Name, PhoneNumber = @PhoneNumber, Email = @Email WHERE Id = @Id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@Id", Id);
                    command.Parameters.AddWithValue("@Name", Name_textBox.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber_textBox.Text);
                    command.Parameters.AddWithValue("@Email", Email_textBox.Text ) ;

                    command.ExecuteNonQuery();
                }
            }
            if (MainFormRef != null) 
            {
                MainFormRef.LoadContactDataOnDataGridView();
                this.Close();
                MessageBox.Show("Contact was updated successfully", "Succces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GetDataById()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=ContactBook.db;Version=3"))
            {
                string query = "SELECT * FROM Contacts WHERE Id = @Id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Id", Id);
                    using (SQLiteDataReader reader = command.ExecuteReader()) 
                    {
                        if (reader.Read())
                        {
                            Name_textBox.Text = reader.GetString(reader.GetOrdinal("Name"));
                            PhoneNumber_textBox.Text = reader.GetString(reader.GetOrdinal("PhoneNumber"));
                            Email_textBox.Text = reader.GetString(reader.GetOrdinal("Email"));
                        }
                    }
                }
            }
        }
    }
}
