using System.Data;
using System.Data.SQLite;

namespace SimpleSQLiteCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckIfDatabaseFileExists();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            SimpleSQLiteCRUD.DataForm frm = new SimpleSQLiteCRUD.DataForm(this);
            frm.ShowDialog();
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if(Contacts_dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Please select a row to update");
                return;
            }
            int id = GetId();
            SimpleSQLiteCRUD.DataForm frm = new DataForm(this, id);
            frm.ShowDialog();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (Contacts_dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete");
                return;
            }

            if(MessageBox.Show("Do you want to delete this contact", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                DeleteDataById();
        }

        private void DeleteAll_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this contact", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                DeleteAll();
        }

        private int GetId()
        {
            var cellValue = Contacts_dataGridView.Rows[Contacts_dataGridView.CurrentRow.Index].Cells[0].Value.ToString();
            if (!string.IsNullOrEmpty(cellValue)) { return int.Parse(cellValue); } else { return -1; }
        }

        private void CheckIfDatabaseFileExists()
        {
            if (!File.Exists("ContactBook.db"))
            {
                SQLiteConnection.CreateFile("ContactBook.db");

                using (SQLiteConnection connection = new SQLiteConnection("Data Source=ContactBook.db;Version=3"))
                {
                    String query = "CREATE TABLE Contacts(ID INTEGER PRIMARY KEY AUTOINCREMENT, Name INVARCHAR(250), PhoneNumber INVARCHAR(250), Email INVARCHAR(250))";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                LoadContactDataOnDataGridView();
            }
        }

        public void LoadContactDataOnDataGridView()
        {
            Contacts_dataGridView.DataSource = GetContactsFromDatabase();
        }

        private DataTable GetContactsFromDatabase()
        {
            DataTable results = new DataTable();

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=ContactBook.db;Version=3"))
            {
                string query = "SELECT * FROM Contacts";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    connection.Open();
                    SQLiteDataReader reader = command.ExecuteReader();
                    results.Load(reader);
                }
            }

            return results;
        }

        private void DeleteDataById()
        {
            int id = GetId();
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=ContactBook.db;Version=3"))
            {
                string query = "DELETE FROM Contacts WHERE Id = @Id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    LoadContactDataOnDataGridView();
                    MessageBox.Show("Contact was deleted successfully", "Succces", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteAll()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=ContactBook.db;Version=3"))
            {
                string query = "DELETE FROM Contacts";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    LoadContactDataOnDataGridView();
                    MessageBox.Show("All contacts were deleted successfully", "Succces", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
