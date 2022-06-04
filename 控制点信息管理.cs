using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCWin;
using System.Data.SQLite;

namespace 校园测量控制点管理系统
{
    public partial class 控制点信息管理 : Skin_VS
    {
        public 控制点信息管理()
        {
            InitializeComponent();
        }

        private void 控制点信息管理_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void skinLabel12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void kzd_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (kzd.Text == "导线点")
            {
                
                name1.Visible = true;
                locat2.Visible = true;
                X3.Visible = true;
                Y4.Visible = true;
                H5.Visible = true;
                坐标系6.Visible = true;
                maishi7.Visible = true;
                level8.Visible = true;
                mid9.Visible = true;
                B10.Visible = true;
                L11.Visible = true;
            }
            if (kzd.Text == "水准点")
            {
                
                name1.Visible = true;
                locat2.Visible = true;
                X3.Visible = false;
                Y4.Visible = false;
                H5.Visible = true;
                坐标系6.Visible = false;
                maishi7.Visible = true;
                level8.Visible = true;
                mid9.Visible = false;
                B10.Visible = true;
                L11.Visible = true;
            }
            if (kzd.Text == "GNSS点")
            {
                name1.Visible = true;
                locat2.Visible = true;
                X3.Visible = true;
                Y4.Visible = true;
                H5.Visible = true;
                坐标系6.Visible = true;
                maishi7.Visible = true;
                level8.Visible = true;
                mid9.Visible = true;
                B10.Visible = true;
                L11.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            string mystr, mysql;//连接字符串和查询字符串
            using (SQLiteConnection myconn = new SQLiteConnection())
            {//建立连接
                mystr = @"Data Source = " + path + "数据库.db" + "; Version = 3;";
                myconn.ConnectionString = mystr;
                myconn.Open();
                string table;
                if (kzd.Text == "导线点")
                {
                    table = "导线点表";
                }
                else if (kzd.Text == "水准点")
                {
                    table = "水准点表";
                }
                else if (kzd.Text == "GNSS点")
                {
                    table = "GNSS点表";
                }
                else 
                {
                    MessageBox.Show("请选择点类型");
                    return;
                }
                mysql = $"INSERT INTO {table} VALUES ('{name1.Text}','{locat2.Text}','{X3.Text}','{Y4.Text}','{H5.Text}','{坐标系6.Text}','{maishi7.Text}','{level8.Text}','{mid9.Text}','{B10.Text}','{L11.Text}');";
                MessageBox.Show("添加成功");
                控制点管理.kzd.ShowData(mysql, myconn);
                myconn.Close();
            }
        }
    }
}
