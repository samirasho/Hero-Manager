using System.Data;
using System.Diagnostics;
using System.Text;



namespace Hero
{
    public partial class DB : Form
    {

        // IP 91.204.46.137
        // user k215510_b7i-211
        // pw Er$1234Er$
        // db-name k215510_b7i-211

        private MySQLDatabase database;
       
        public DB()
        {

            InitializeComponent();
            // Initialize MySQLDatabase with your MySQL server details
            database = new MySQLDatabase("91.204.46.137", "k215510_b7i-211", "k215510_b7i-211", "Er$1234Er$");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Bitte Benutzername und Passwort eingeben.");
                return;
            }

            DataTable userData = GetUseData(username);

            if (userData.Rows.Count == 0)
            {
                MessageBox.Show("Benutzer nicht gefunden.");
                return;
            }
            DataRow userRow = userData.Rows[0];
            string storedHash = userRow["passwordhash"].ToString();
            string storedSalt = userRow["salt"].ToString();

            string hashedPassword = HashPassword(password, storedSalt);

            if (storedHash == hashedPassword)
            {
                MessageBox.Show("Anmeldung erfolgreich! Willkommen, " + username + "!");

                Eidit eidit = new Eidit();
                eidit.FormClosed += (s, args) => this.Close(); // Close Form1 when Form2 closes
                eidit.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Ungültiger Benutzername oder Passwort. Bitte versuchen Sie es erneut.");
            }


        }

        private string HashPassword(string password, string salt)
        {
            string hash1 = sha256_hash(password);
            string hash2 = sha256_hash(hash1 + salt);
            Debug.WriteLine(hash2);
            return hash2;

        }

        private string sha256_hash(string value)
        {
            StringBuilder Sb = new StringBuilder();

            using (var hash = System.Security.Cryptography.SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();

        }

        private DataTable GetUseData(string username)
        {
            database.OpenConnection();

            string query = $"SELECT passwordhash, salt FROM user WHERE username = '{username}'";
            DataTable userData = database.ExecuteQuery(query);

            database.CloseConnection();

            return userData;

        }
    }
}