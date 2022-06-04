using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

namespace 校园测量控制点管理系统
{
    public partial class 注册 : Skin_VS
    {
        public 注册()
        {
            InitializeComponent();
        }

        private void 注册_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (用户名.Text != "" && 密码.Text != ""&& 确认密码.Text !="")
            {
                if (密码.Text != 确认密码.Text)
                {
                    MessageBox.Show("请两次输入相同的密码");
                    密码.Text = "";
                    确认密码.Text = "";
                }
                else
                {
                    sqliteClass sql = new sqliteClass();
                    sql.InsertRow(用户名.Text, 密码.Text, "账号","密码", "注册用户");
                    MessageBox.Show("申请成功，请等待管理员审核");
                    this.Close();
                }
            }
            else
            {
                用户名.Text = "";
                密码.Text = "";
                确认密码.Text = "";
                MessageBox.Show("请输入用户名或密码");
            }
        }
    }
}
