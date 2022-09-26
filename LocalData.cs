using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DemoExam
{
    class LocalData    

    {
        public static string USER_ID = string.Empty;
        public static string USER_MODE = string.Empty;
        public static string ITEM_MODE = string.Empty;
        public static bool OPEN_ADD = false;
        public static string ITEM_ARTICLE = string.Empty;
        public static string ROW_COUNT = string.Empty;
        public static void openChildForm(Form activeForm, Form childForm, Panel panel)
        {
            if (activeForm != null)
                activeForm = null;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.TopLevel = false;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.Show();
            childForm.BringToFront();            
        }

        public static string actionString(string query)
        {
            string result = string.Empty;
            MySqlConnection conn = DBUtills.GetDBConenction();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    result = rd.GetString(0);                    
                }
                conn.Close();
                return result;
            }
            catch(Exception ex)
            {                
                MessageBox.Show(ex.Message); 
                return "Error";
            }
        }

        public static void action(string query)
        {
            MySqlConnection conn = DBUtills.GetDBConenction();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteReader();
                conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show
                    (ex.Message);
            }
        }

        public static string PLACEHODLER = "Z:\\Задание\\Вариант 5\\Сессия 1\\picture.png";
        public static void getData(Panel panel, string query)
        {
            panel.Controls.Clear();
            MySqlConnection conn = DBUtills.GetDBConenction();
            MySqlDataAdapter ada = new MySqlDataAdapter(query, conn);
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                ada.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var row = dt.Rows[i];
                    Panel ITEM = new Panel();                    
                    panel.Controls.Add(ITEM);
                    ITEM.Tag = row[0].ToString();
                    ITEM.Dock = DockStyle.Top;
                    ITEM.BringToFront();
                    if (USER_MODE == "1")
                    {
                        Panel BUTTONS = new Panel();
                        Button ADD = new Button();
                        Button DELETE = new Button();
                        ADD.FlatStyle = FlatStyle.Flat;
                        DELETE.FlatStyle = FlatStyle.Flat;
                        ADD.Name = row[0].ToString();
                        DELETE.Name = row[0].ToString();
                        ADD.Click += ADD_Click;
                        DELETE.Click += DELETE_Click;
                        ADD.Text = "Просмотреть";
                        DELETE.Text = "Удалить";
                        BUTTONS.Controls.Add(ADD);
                        ADD.Dock = DockStyle.Top;
                        ADD.BringToFront();
                        BUTTONS.Controls.Add(DELETE);
                        DELETE.Dock = DockStyle.Top;
                        DELETE.BringToFront();
                        ITEM.Controls.Add(BUTTONS);
                        BUTTONS.Dock = DockStyle.Right;
                        BUTTONS.BringToFront();
                    }
                    Label Stock = new Label();
                    ITEM.Controls.Add(Stock);
                    if (row[8] == null)
                        Stock.Text = "Отсутствуют";
                    else
                        Stock.Text = row[8].ToString();
                    Stock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    Stock.Dock = DockStyle.Right;
                    Stock.BringToFront();
                    Panel DESC = new Panel();
                    ITEM.Controls.Add(DESC);
                    Label NAME = new Label();
                    NAME.Text = "Наименование: " + row[1].ToString();
                    Label DESCRIPT = new Label();
                    DESCRIPT.Text = "Описание товара: " + row[2].ToString();
                    Label MANUF = new Label();
                    MANUF.Text = "Проихводитель: " + row[5].ToString();
                    Label COST = new Label();
                    COST.Text = "Цена: " + row[6].ToString();
                    DESC.Controls.Add(COST);
                    COST.Dock = DockStyle.Bottom;
                    COST.BringToFront();
                    DESC.Controls.Add(MANUF);
                    MANUF.Dock = DockStyle.Bottom;
                    MANUF.BringToFront();
                    DESC.Controls.Add(DESCRIPT);
                    DESCRIPT.Dock = DockStyle.Bottom;
                    DESCRIPT.BringToFront();
                    DESCRIPT.Text.Split();
                    DESC.Controls.Add(NAME);
                    NAME.Dock = DockStyle.Bottom;
                    NAME.BringToFront();
                    DESC.Dock = DockStyle.Top;                    
                    DESC.BringToFront();
                    PictureBox PICTURE = new PictureBox();
                    ITEM.Controls.Add(PICTURE);
                    PICTURE.ImageLocation = PLACEHODLER;
                    PICTURE.SizeMode = PictureBoxSizeMode.StretchImage;
                    PICTURE.Size = new System.Drawing.Size(150, 150);
                    PICTURE.Dock = DockStyle.Left;
                    PICTURE.Show();
                }
                conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void DELETE_Click(object sender, EventArgs e)
        {
            ITEM_ARTICLE = (sender as Button).Name.ToString();
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить данные?", "Подтвердите действия", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.Yes)
            {
                string query = "delete from product where ProductArticleNumber = '" + (sender as Button).Name.ToString() + "';";
                action(query);
            }            
        }

        private static void ADD_Click(object sender, EventArgs e)
        {
            Console.WriteLine((sender as Button).Name.ToString());
            ITEM_ARTICLE = (sender as Button).Name.ToString();
            if (!OPEN_ADD)
            {                
                ITEM_MODE = "UPDATE";
                ItemAdd Win = new ItemAdd();
                Win.Show();
                OPEN_ADD = true;
            }
        }

        public static int getCount()
        {
            int result = 0;
            MySqlConnection conn1 = DBUtills.GetDBConenction();
            MySqlCommand cmd = new MySqlCommand("select count(*) from product;");
            try
            {
                conn1.Open();
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    result = rd.GetInt32(0);
                }
                conn1.Close();
                return result;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return result;
            }
        }
        
    }
}
