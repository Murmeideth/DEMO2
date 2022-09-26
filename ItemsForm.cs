using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DemoExam
{
    public partial class ItemsForm : Form
    {
        public ItemsForm()
        {
            InitializeComponent();

            if (LocalData.USER_MODE != "1")
                add_btn.Visible = false;
            costBox.SelectedIndex = 0;
            manBox.SelectedIndex = 0;

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (!LocalData.OPEN_ADD)
            {
                ItemAdd Win = new ItemAdd();
                LocalData.ITEM_MODE = "ADD";
                Win.Show();
                Win.FormClosed += Win_FormClosed;
                LocalData.OPEN_ADD = true;
            }

        }

        private void Win_FormClosed(object sender, FormClosedEventArgs e)
        {
            getQuery();
            LocalData.OPEN_ADD = false;
        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {
            getQuery();
            count_label.Text = LocalData.ROW_COUNT;
        }

        private void costBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            getQuery();
            count_label.Text = LocalData.ROW_COUNT;
        }

        private void manBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            getQuery();
            count_label.Text = LocalData.ROW_COUNT;
        }
        public void getQuery()
        {
            string query = "select * from product where productname like '%" + search_box.Text + "%' ";
            switch (manBox.SelectedIndex)
            {
                case 1:
                    query += "and productmanufacturer = 'БТК Текстиль' ";
                    break;
                case 2:
                    query += "and productmanufacturer = 'Империя ткани' ";
                    break;
                case 3:
                    query += "and  productmanufacturer = 'Май Фабрик' ";

                    break;
                case 4:
                    query += "and productmanufacturer = 'Комильфо' ";
                    break;
            }
            switch (costBox.SelectedIndex)
            {
                case 0:
                    query += " order by productcost ";
                    break;
                case 1:
                    query += " order by productcost desc ";
                    break;
            }
            query += ";";
            LocalData.getData(product_panel, query);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
