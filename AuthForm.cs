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
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void log_btn_Click(object sender, EventArgs e)
        {
            if(log_box.Text != "" && pass_box.Text != "")
            {
                string query = "select UserRole from user where UserLogin = '" + log_box.Text + "' and UserPassword = '" + pass_box.Text + "';";
                string res = LocalData.actionString(query);
                if (res != string.Empty)
                {
                    LocalData.USER_MODE = res;
                    query = "select UserID from user where UserLogin = '" + log_box.Text + "' and UserPassword = '" + pass_box.Text + "';";
                    res = LocalData.actionString(query);
                    LocalData.USER_ID = res;
                    LocalData.openChildForm(this, new ItemsForm(), auth_panel);
                }
                else
                    MessageBox.Show("Произошла ошибка авторизации!");
            }
        }

        private void guest_log_Click(object sender, EventArgs e)
        {
            LocalData.USER_MODE = "guest";
            LocalData.openChildForm(this, new ItemsForm(), auth_panel);
        }
    }
}
