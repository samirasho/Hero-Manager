using Hero.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hero
{
    public partial class Chat : Form
    {
        private MySQLDatabase database;
        public Chat()
        {
            InitializeComponent();
            database = new MySQLDatabase("91.204.46.137", "k215510_b7i-211", "k215510_b7i-211", "Er$1234Er$");
        }

        private DataTable GetChatData()
        {
            database.OpenConnection();
            string query = $"SELECT * FROM `k215510_b7i-211`.chat;";
            DataTable userData = database.ExecuteQuery(query);
            database.CloseConnection();
            return userData;
        }
        private DataTable AddMessage(int heroid, string Message)
        {
            database.OpenConnection();
            string query = $"INSERT INTO `chat` (`heroid`, `message`) VALUES ('{heroid}', '{Message}');";
            DataTable userData = database.ExecuteQuery(query);
            database.CloseConnection();
            return userData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            GetChatData();
            DataTable chatdata = GetChatData();

            for (int i = 1; i < chatdata.Rows.Count; i++)
            {
                DataRow chatdatarow = chatdata.Rows[i];
                string heroname = chatdatarow["heroid"].ToString();
                string messag = chatdatarow["message"].ToString();
                listBox1.Items.Add("Username:" + heroname + " Message: " + messag);

            }
            string message = textBox1.Text.ToString();
            AddMessage(1, message);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            database.OpenConnection();
            string query = $"SELECT TileId, CoordX, CoordY, CanBeEntered, LandscapeType, Resources, HeroId FROM world ;";
            DataTable worldData = database.ExecuteQuery(query);
            database.CloseConnection();

            if (worldData.Rows.Count == 0)
            {
                return;
            }
            else
            {

                Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    // Lösche die Bitmap, um sie mit einem leeren Hintergrund zu füllen
                    graphics.Clear(Color.White);

                    foreach (DataRow row in worldData.Rows)
                    {
                        int TileId = Convert.ToInt32(row["TileId"]);
                        int CoordX = Convert.ToInt32(row["CoordX"]);
                        int CoordY = Convert.ToInt32(row["CoordY"]);
                        int CanBeEntered = Convert.ToInt32(row["CanBeEntered"]);
                        int HeroId = (row["HeroId"] != DBNull.Value) ? Convert.ToInt32(row["HeroId"]) : 0;
                        string Resource = row["Resources"].ToString();
                        string LandscapeType = row["LandscapeType"].ToString();

                        Bitmap tileBitmap = LoadTileBitmap(LandscapeType);
                        Bitmap layerBitmap = LoadLayerBitmap(Resource);
                        Bitmap playerBitmap = checkHero(HeroId);

                        // Berechne die Position, an der das Tile gezeichnet werden soll
                        int x = CoordX * 32; // 32 ist die Breite eines Tiles
                        int y = CoordY * 32; // 32 ist die Höhe eines Tiles

                        // Zeichne das Tile auf der Bitmap
                        graphics.DrawImage(tileBitmap, x, y);
                        graphics.DrawImage(layerBitmap, x, y);
                        graphics.DrawImage(playerBitmap, x, y);

                    }
                    // Zeige die fertige Bitmap auf der PictureBox an
                    pictureBox1.Image = bitmap;

                }

            }

            return;

        }

        private Bitmap checkHero(int heroid)
        {
            Bitmap hero = new Bitmap(32, 32);
            if (heroid > 0)
            {
                hero = Resources.forest__1_;
            }
            return hero;
        }

        private Bitmap LoadLayerBitmap(string resources)
        {
            Bitmap resource = new Bitmap(32, 32);

            if (resources == "Wood")
            {
                resource = Resources.ovE9KM;
            }

            return resource;
        }

        private Bitmap LoadTileBitmap(string landscapeType)
        {
            Bitmap tileBitmap = Resources.crop;
            switch (landscapeType)
            {
                case "Mountain":
                    {
                        tileBitmap = Resources.stump;
                        break;
                    }
                case "Meadow":
                    {
                        tileBitmap = Resources.forest__1_;
                        break;
                    }
                case "Forest":
                    {
                        tileBitmap = Resources.crop;
                        break;
                    }
                default:
                    {
                        tileBitmap = Resources.forest__1_;
                        break;
                    }


            }
            return tileBitmap;

        }
    }
}

