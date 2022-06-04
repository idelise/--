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
using System.Data.SQLite;

namespace 校园测量控制点管理系统
{
    public partial class 多条件查询 : Skin_VS
    {
        public 多条件查询()
        {
            InitializeComponent();
        }

        private void 多条件查询_Load(object sender, EventArgs e)
        {

        }

        private void queding_Click(object sender, EventArgs e)
        {
            sqliteClass sqlite = new sqliteClass();
            if (biaoming == null)
            {
                MessageBox.Show("请选择表");
                return;
            }
            string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            string mystr, mysql;//连接字符串和查询字符串
            SQLiteConnection myconn = new SQLiteConnection();//建立连接
            mystr = @"Data Source = " + path + "数据库.db" + "; Version = 3;";
            myconn.ConnectionString = mystr;
            myconn.Open();

            //获取表名拼接字符串
            #region 创建sql语句
            string wz, lx, dj;//查询相应位置类型等级的查询语句字符串
            if (weizhi.Text == null || weizhi.Text == "默认")
            {
                wz = "";
            }
            else 
            {
                wz = " WHERE 位置 LIKE '%" + weizhi.Text + "%'";
            }
            if (maishileix.Text == null || maishileix.Text == "默认")
            {
                lx = "";
            }
            else if (wz == "" && (maishileix.Text != null || maishileix.Text != "默认"))
            {
                lx = " WHERE 埋石类型 LIKE '%" + maishileix.Text + "%'";
            }
            else if (wz != "" && (maishileix.Text != null || maishileix.Text != "默认"))
            {
                lx = " AND 埋石类型 LIKE '%" + maishileix.Text + "%'";
            }
            else
            {
                lx = "";
            }


            if (wz == "" && lx == ""&&(level.Text != null && level.Text != "默认"))
            {
                dj = " WHERE 等级 LIKE '%" + level.Text + "%'";
            }
            else if (level.Text != null && level.Text!="默认")
            {
                dj = " AND 等级 LIKE '%" + level.Text + "%'";
            }
            else
            {
                dj = "";
            }

            mysql = "SELECT*FROM " + biaoming.Text+wz+lx+dj+";";
            #endregion
            控制点管理.kzd.ShowData(mysql, myconn);
            try
            {
                SQLiteDataAdapter myda = new SQLiteDataAdapter(mysql, myconn);//获取数据库里相应表数据
                DataTable dt1 = new DataTable();//用datatable当中介存数据
                myda.Fill(dt1);//把数据库中数据填充至datatable
                控制点管理.kzd.tableshow.DataSource = dt1;//显示在控件中
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示");
            }
            myconn.Close();
            for (int i = 0; i < 控制点管理.kzd.tableshow.Columns.Count; i++)
            {
                控制点管理.kzd.tableshow.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            控制点管理.kzd.tableshow.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            myconn.Close();
            this.Close();
        }
    }
}
