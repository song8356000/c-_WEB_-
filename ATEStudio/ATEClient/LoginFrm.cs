using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATEClient
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 系统登录界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainFrm frm = new MainFrm();
            if (txtSn.Text == "1234")
            {
                frm.Show();  
                this.Hide();
            }
            else
            {
                MessageBox.Show("SN输入错误");
                return;
            }
        }
    }
}
