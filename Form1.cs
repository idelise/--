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
    public partial class 登录1 : Skin_VS
    {
        public 登录1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 登录1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (用户名.Text == "" && 密码.Text == "")
            {
                MessageBox.Show("账号或密码不能为空，请重新输入");
            }
            else
            {
                if (comboBox1.Text == "管理员")
                {
                    控制点管理.level = 1;//管理员赋值1
                }
                if (comboBox1.Text == "用户")
                {
                    控制点管理.level = 0;//用户赋值0
                }
                string str = "select * from " + comboBox1.Text + " where 账号='" + 用户名.Text + "'and 密码='" + 密码.Text + "'";
                sqliteClass sql = new sqliteClass();
                IDataReader idr = sql.Read(str);
                if (idr.Read())//打开窗体
                {
                    idr.Close();//这里一定要关，不然后面用户操作会多线程

                    this.DialogResult = DialogResult.OK; //设置窗体的对话框结果
                }
                else
                {
                    MessageBox.Show("账户或密码错误，请重新输入");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            用户名.Text = "";
            密码.Text = "";
        }

        private void 用户名_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (密码.PasswordChar == '*')
                密码.PasswordChar = new char();
            else
                密码.PasswordChar = '*';
        }

        private void log_Click(object sender, EventArgs e)
        {
            注册 zc = new 注册();
            zc.Show();
        }
    }
}
