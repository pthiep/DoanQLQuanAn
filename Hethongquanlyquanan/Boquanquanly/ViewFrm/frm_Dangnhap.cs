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
using Boquanquanly.DAO;
using Boquanquanly.DTO;

namespace Boquanquanly
{
    public partial class frm_Dangnhap : MetroForm
    {
        string strconn = "Data Source=DESKTOP-NE70A7B\\SQLEXPRESS;Initial Catalog=Accout;Integrated Security=True";

        public frm_Dangnhap()
        {
            InitializeComponent();
        }

        private void frm_Dangnhap_Load(object sender, EventArgs e)
        {
            MessageBox.Show(AccountDAO.Instance.getParamater().ToString());
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
            //if (sql.Connect(strconn))
            //{
            //    string id = "";
            //    DataTable dt = new DataTable();
            //    //MessageBox.Show("SELECT * FROM tbl_User WHERE user_name ='" + username + "' and pass='" + password + "'");
            //    dt = sql.Command("SELECT * FROM tbl_User WHERE user_name ='" + username + "' and pass='" + password + "'");
            //    if (dt != null)
            //    {
            //        foreach (DataRow dr in dt.Rows)
            //        {
            //            id = dr["id_user"].ToString();
            //        }
            //    }
            //    return id;
            //}
            //else
            //{
                return "";
            //}
        }

        void dangNhap()
        {
            if (AccountDAO.Instance.Login(txtBox_Username.Text, txtBox_Password.Text))
            {
                //frm_Quanly frmQL = new frm_Quanly();
                //frmQL.Show();
                //this.Hide();
                MessageBox.Show("Đăng nhập thành công !\n" + AccountDAO.currentUser.Id.ToString() + " : " + AccountDAO.currentUser.NameUser);
            }
            else
            {
                MessageBox.Show("Tài khoản và mật khẩu không đúng !");
            }
            //sql.Disconnect();
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
    }
}
