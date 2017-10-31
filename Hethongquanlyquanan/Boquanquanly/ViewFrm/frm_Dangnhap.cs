using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using SQLManager;

namespace Boquanquanly
{
    public partial class frm_Dangnhap : MetroForm
    {

        public NewObject.DTUser currentUser;
        public SqlManager sql;
        string strconn = @"Data Source=DESKTOP-HF3Q9MR\SQLEXPRESS;Initial Catalog=QLNH;Integrated Security=True";

        public frm_Dangnhap()
        {
            InitializeComponent();
            sql = new SqlManager();
            currentUser = new NewObject.DTUser();
        }

        private void frm_Dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            dangNhap();
        }

        private void frm_Dangnhap_Enter(object sender, EventArgs e)
        {
            dangNhap();
        }

        public string getID(string username, string password)
        {
            if (sql.Connect(strconn))
            {
                string id = "";
               
                DataTable dt = new DataTable();
                //MessageBox.Show("SELECT * FROM tbl_User WHERE user_name ='" + username + "' and pass='" + password + "'");
                dt = sql.Command("SELECT * FROM tbl_User WHERE user_name ='" + username + "' and pass='" + password + "'");
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["id_user"].ToString();
                    }
                }
                return id;
            }
            else
            {
                return "";
            }
        }
        public string getName(string username, string password)
        {

            if (sql.Connect(strconn))
            {
                string name = "";

                DataTable dt = new DataTable();
                //MessageBox.Show("SELECT * FROM tbl_User WHERE user_name ='" + username + "' and pass='" + password + "'");
                dt = sql.Command("SELECT * FROM tbl_User WHERE user_name ='" + username + "' and pass='" + password + "'");
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        name = dr["name_user"].ToString();
                    }
                }
                return name;
            }
            else
            {
                return "";
            }
        }

        void dangNhap()
        {
            NewObject.DTUser.ID_USER = getID(txtBox_Username.Text, txtBox_Password.Text);
            NewObject.DTUser.NAME_USER = getName(txtBox_Username.Text, txtBox_Password.Text);
            MessageBox.Show("Chào mừng " + NewObject.DTUser.NAME_USER);
            if (NewObject.DTUser.ID_USER != "")
            {
                frm_Quanly frmQL = new frm_Quanly();
                frmQL.Show();
                this.Hide();

   
            }
            else
            {
                MessageBox.Show("Tài khoản và mật khẩu không đúng !");
            }
            sql.Disconnect();
        }

        private void txtBox_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dangNhap();
            }
        }

        private void txtBox_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dangNhap();
            }
        }

        private void txtBox_Password_Click(object sender, EventArgs e)
        {

        }
    }
}
