using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hero
{
    public partial class Eidit : Form
    {
        /* hi sami, ich bin sebatsian, ein großer fan von dir und wollte dir sgane, dass du echt cool bist und so. omid stinkt YAH!*/
        private int userid = -1;
        private String username = "";
        private MySQLDatabase database;
        private int heroid;
        private int custom;
        private string klasse;
        private int hp = 1;
        private int att = 1;
        private string deleteHero;
        private int selectedRow;
        private string standard;
        private string wizard;
        private string Barbarian;
        public Eidit()
        {
            InitializeComponent();

            database = new MySQLDatabase("91.204.46.137", "k215510_b7i-211", "k215510_b7i-211", "Er$1234Er$");
            

        }

        public Eidit(int userid, string usn)
        {
            InitializeComponent();
            // überprüfen, ob eine gültige ID übermittelt wurde
            if (userid > 0)
            {
                userid = userid;
                username = usn;
            }


        }
        public void Eidit_loud(object sender, EventArgs e)
        {

        }

        private DataTable GetUserData(int userid)
        {
            database.OpenConnection();
            string query = $"SELECT id, name, klasse, hp, att, def FROM heroes WHERE user_id = '{userid}'";
            DataTable userData = database.ExecuteQuery(query);
            database.CloseConnection();
            return userData;
        }
        public void open_connection()
        {
            string myConnectionString = "server=91.204.46.137;database=k215510_b7i-211;uid=k215510_b7i-211;pwd=Er$1234Er$;";
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            try
            {
                connection.Open();
                MessageBox.Show("Connection Open!");
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot open connection!");
            }


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string[] data = { comboBox1.Text,textBox1.Text};
            listBox1.Items.Clear();
            foreach (string item in data)
            {
                listBox1.Items.Add(item);
                
            }
            switch (comboBox1.Text)
            {

                 
                case "Barbarian":

                    pictureBox2.Show();
                    pictureBox1.Hide();
                    trackBar1.Value = hp;
                    trackBar2.Value = att;
                    listBox1.Text = textBox1.Text;
                    label5.Text = textBox1.Text;
                    break;

                case "Wizard":

                    pictureBox1.Show();
                    pictureBox2.Hide();
                    trackBar1.Value = hp;
                    trackBar2.Value = att;
                    listBox1.Text = textBox1.Text;
                    label5.Text = textBox1.Text;
                    break;
         
                default:
                    pictureBox1.Image = Properties.Resources.Barbarian;
                    pictureBox2.Refresh();
                    trackBar2.Value = att;
                    pictureBox1.Visible = true;
                    break;
            }
            
            // spiel
            if (heroid < 0)
            {
                MessageBox.Show(listBox1.Text);               
                database.OpenConnection();
                string quer = $"INSERT INTO heroes (name, klasse, hp, att, def, deleted, custom, user_id) VALUES ('{textBox1.Text}', '{comboBox1.Text}', {(int)trackBar1.Value}, {(int)trackBar2.Value}, {(int)trackBar2.Value}, 0, 0, {userid})";
                Debug.WriteLine(quer);
                DataTable userData = database.ExecuteQuery(quer);
                database.CloseConnection();

            }
            else
            {
                MessageBox.Show("eingelesener Held --> UPDATE");
                //UPDATE `k215510_b7i-211`.`heroes` SET `hp`=24, `att`=1, `def`=0, `deleted`=1, `custom`=1, `user_id`=4 WHERE  `id`=2004;
                database.OpenConnection();

                string query = $"UPDATE heroes SET name = '{textBox1.Text}', klasse = '{comboBox1.Text}', att = {(int)trackBar1.Value}, def = {(int)trackBar2.Value}, user_id = {userid} WHERE id = '{heroid}'";
                DataTable userData = database.ExecuteQuery(query);

                database.CloseConnection();
            }
            fillListBox();
        }

        private void fillListBox()
        {
            //Liste der Helden aus der Datenbank abfragen (gefiltert nach UserID)
            database.OpenConnection();

            string query = $"SELECT id, name, klasse FROM heroes WHERE user_id = '{userid}'";
            DataTable userData = database.ExecuteQuery(query);

            database.CloseConnection();
              
            listBox1.Items.Clear();

            foreach (DataRow row in userData.Rows)
            {
                string heroName = row["name"].ToString();
                string heroClass = row["klasse"].ToString();
                int heroId = Convert.ToInt32(row["id"]);
                listBox1.Items.Add($"{heroId}: {heroName} - {heroClass}");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Soll der Hero " + selectedRow + " wirklich gelöscht werden?", "Achtung!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (DialogResult)
            {
                case DialogResult.Yes:

                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
           
        }
        private void listBox1_SelectedIndexChanged(object sender, MouseEventArgs e)
        {

           

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            //Index ermitteln und heroid extrahieren
            //string selectedRow = listBox1.SelectedItem.ToString(); //<-- Eintrag wird als String geholt
            //string stringBeforeChar = selectedRow.Substring(0, selectedRow.IndexOf(":")); //<-- in dem Fall, ID extrahieren, in dem der Text vor dem Doppelpunkt eingelesen wird
          //  heroid = Convert.ToInt32(stringBeforeChar); // in int konvertieren und als heroid speichern

            //Datenbankoperationen, danach zuweisen der Werte
            database.OpenConnection();

            string query = $"SELECT id, name, klasse, hp, att, def, custom FROM heroes WHERE id = '{heroid}'";
            DataTable userData = database.ExecuteQuery(query);

            database.CloseConnection();

            if (userData.Rows.Count == 0)
            {
                MessageBox.Show("Hero nicht gefunden.");
                return;
            }
        }




    }
}

