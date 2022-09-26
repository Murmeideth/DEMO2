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
    public partial class ItemAdd : Form
    {
        public ItemAdd()
        {
            InitializeComponent();
            if(LocalData.ITEM_MODE == "ADD")
            {
                comboBox1.SelectedIndex = 0;
                manBox.SelectedIndex = 0;
            }else if(LocalData.ITEM_MODE == "UPDATE")
            {
                done_btn.Text = "Изменить";
                try
                {
                    MySqlConnection conn = DBUtills.GetDBConenction();
                    MySqlCommand cmd = new MySqlCommand("select * from product where productarticlenumber = '" + LocalData.ITEM_ARTICLE + "';", conn);
                    conn.Open();
                    MySqlDataReader rd = cmd.ExecuteReader();
                    if(rd.HasRows)
                    {
                        rd.Read();
                        arrticle_box.Text = rd.GetString(0);
                        name_box.Text = rd.GetString(1);
                        desc_box.Text = rd.GetString(2);
                        comboBox1.Text = rd.GetString(3);
                        manBox.Text = rd.GetString(5);
                        cost_box.Text = rd.GetString(6);
                        amount_box.Text = rd.GetString(7);
                        count_box.Text = rd.GetString(8);
                        status_box.Text = rd.GetString(9);
                    }    
                    conn.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ItemAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            LocalData.OPEN_ADD = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;
            button1.Text = path;
        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            if (LocalData.ITEM_MODE == "ADD")
                LocalData.action("insert into product value('" + arrticle_box.Text + "', '" + name_box.Text + "', '"+ desc_box.Text + "', '" + comboBox1.SelectedItem.ToString() + "', '" + openFileDialog1.FileName + "', '" + manBox.SelectedItem.ToString() + "', " + cost_box.Text + ", " + amount_box.Text + ", " + count_box.Text +  ", '" + status_box.Text + "')");
            else if (LocalData.ITEM_MODE == "IPDATE")
                LocalData.action("update product set productname ='" + name_box.Text + "', productdescription ='" + desc_box.Text + "', productcategory ='" + comboBox1.SelectedItem.ToString() + "', productphoto ='" + openFileDialog1.FileName + "', productmanufacturer ='" + manBox.SelectedItem.ToString() + "', productcost =" + cost_box.Text + ", productdiscountamount=" + amount_box.Text + ", produntquantityinstock=" + count_box.Text + ", productstatus ='" + status_box.Text + "' where productarticlenumber = '" + LocalData.ITEM_ARTICLE + "';");
            this.Close();
        }
    }
}
