using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCWin;
using System.Data;
using System.Data.SQLite;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using Sunny.UI;

namespace 校园测量控制点管理系统
{
    public partial class 控制点管理 : Skin_VS
    {
        public static 控制点管理 kzd;          
        public 控制点管理()
        {
            InitializeComponent();
            kzd = this;
            tableshow.ReadOnly = false;
            if (level == 0)//让用户不能看到用户管理界面
            {
                yonghu.Visible = false;
            }
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
            panel14.Visible = false;

            #region 绘制第一个条状图
            // 配置参数
            option = new UIBarOption();
            // 配置标题
            option.Title = new UITitle();
            // 主标题
            option.Title.Text = "测试数据";
            // 副标题
            option.Title.SubText = "";

            // 设置图例
            option.Legend = new UILegend();
            // 图例水平布局
            option.Legend.Orient = UIOrient.Horizontal;
            // 图例放置在左上角
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;
            // 两个图例分别是Bar1和Bar2
            option.Legend.AddData("测试1");
            option.Legend.AddData("测试 2");

            // 设置系列
            UIBarSeries series = new UIBarSeries();
            // 第一系列Bar1
            series.Name = "测试1";
            series.AddData(1.1);
            series.AddData(2.1);
            series.AddData(3.1);
            series.AddData(2.1);
            series.AddData(1.1);
            option.Series.Add(series);

            // 设置第二系列Bar2
            series = new UIBarSeries();
            series.Name = "测试2";
            series.AddData(3.1);
            series.AddData(2.1);
            series.AddData(1.1);
            series.AddData(2.1);
            series.AddData(3.1);
            option.Series.Add(series);

            // 设置横坐标内容
            // 第一系列和第二系列的元素交织分布
            // 所以Mon是指第一和二系列的第一个元素的横坐标
            // Tue指第一和二系列的第二个元素的横坐标
            option.XAxis.Data.Add("Mon");
            option.XAxis.Data.Add("Tue");
            option.XAxis.Data.Add("Wed");
            option.XAxis.Data.Add("Thu");
            option.XAxis.Data.Add("Fri");

            // 辅助ToolTip是否可见
            option.ToolTip.Visible = true;
            // Y轴的刻度
            option.YAxis.Scale = true;
            // XY轴的单位
            option.XAxis.Name = "日期";
            option.YAxis.Name = "数值";
            // 标记处上下限（数值超过了也没事）
            option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Red, Name = "上限", Value = 12 });
            option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Gold, Name = "下限", Value = -20 });
            // 更新坐标轴
            char2.SetOption(option);
            #endregion

            #region 绘制饼状图
            //绘制默认饼状图
            option1 = new UIDoughnutOption();
            // 配置标题
            option1.Title = new UITitle();
            // 主标题
            option1.Title.Text = "控制点等级统计";
            // 副标题
            option1.Title.SubText = "";

            // 设置图例
            option1.Legend = new UILegend();
            // 图例布局样式
            option1.Legend.Orient = UIOrient.Vertical;//竖直布局
            // 图例放置在左上角
            option1.Legend.Left = UILeftAlignment.Left;
            // 两个图例分别是Bar1和Bar2
            option1.Legend.Data.Add("等级1");
            option1.Legend.Data.Add("等级2");
            option1.Legend.Data.Add("等级3");
            option1.Legend.Data.Add("等级4");
            option1.Legend.Data.Add("等级5");

            // 设置系列
            UIDoughnutSeries UIseries = new UIDoughnutSeries();
            // 第一系列Bar1
            UIseries.AddData("等级1", 10);
            UIseries.AddData("等级2", 20);
            UIseries.AddData("等级3", 30);
            UIseries.AddData("等级4", 40);
            UIseries.AddData("等级5", 50);
            option1.Series.Add(UIseries);

            // 更新坐标轴
            Chart1.SetOption(option1);
            #endregion
        }

        SQLiteDataAdapter myda = new SQLiteDataAdapter();
        private UIBarOption option;
        private UIDoughnutOption option1;
        public static int level;//普通用户level=0，管理员level=1；
        public static int biao;//记录当前看的表，水准点表是0，导线点表是1，gnss点表是3；
       

        private void 控制点管理_Load(object sender, EventArgs e)
        {

        }

        private void skinFlowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            current.Text = "导线点";
            biao = 1;
            string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            string mystr, mysql;//连接字符串和查询字符串
            SQLiteConnection myconn = new SQLiteConnection();//建立连接
            mystr = @"Data Source = " + path + "数据库.db" + "; Version = 3;";
            myconn.ConnectionString = mystr;
            myconn.Open();
            mysql = "SELECT*FROM" + " 导线点表";//获取查询字符串
            ShowData(mysql, myconn);
            tableshow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            option1 = new UIDoughnutOption();


            //绘制图表
            // 配置标题
            option1.Title = new UITitle();
            // 主标题
            option1.Title.Text = "控制点等级统计";
            // 副标题
            option1.Title.SubText = "";

            // 设置图例
            option1.Legend = new UILegend();
            // 图例布局样式
            option1.Legend.Orient = UIOrient.Vertical;//竖直布局
            // 图例放置在左上角
            option1.Legend.Left = UILeftAlignment.Left;
            // 两个图例分别是Bar1和Bar2
            option1.Legend.Data.Add("等级1");
            option1.Legend.Data.Add("等级2");
            option1.Legend.Data.Add("等级3");
            option1.Legend.Data.Add("等级4");
            option1.Legend.Data.Add("等级5");

            // 设置系列
            UIDoughnutSeries UIseries = new UIDoughnutSeries();
            // 第一系列Bar1
            UIseries.AddData("等级1", 79);
            UIseries.AddData("等级2", 78);
            UIseries.AddData("等级3", 90);
            UIseries.AddData("等级4", 88);
            UIseries.AddData("等级5", 130);
            option1.Series.Add(UIseries);

            // 更新坐标轴
            Chart1.SetOption(option1);
        }

        private void skintableshow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //在datagridview中显示数据库数据
        public void ShowData(string mysql, SQLiteConnection myconn)
        {
            try
            {
                myda = new SQLiteDataAdapter(mysql, myconn);//获取数据库里相应表数据
                DataTable dt1 = new DataTable();//用datatable当中介存数据
                myda.Fill(dt1);//把数据库中数据填充至datatable
                tableshow.DataSource = dt1;//显示在控件中
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示");
            }
            myconn.Close();
            for (int i = 0; i < tableshow.Columns.Count; i++)
            {
                tableshow.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            tableshow.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            current.Text = "水准点";
            biao = 1;
            string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            string mystr, mysql;//连接字符串和查询字符串
            SQLiteConnection myconn = new SQLiteConnection();//建立连接
            mystr = @"Data Source = " + path + "数据库.db" + "; Version = 3;";
            myconn.ConnectionString = mystr;
            myconn.Open();
            mysql = "SELECT*FROM" + " 水准点表";//获取查询字符串
            tableshow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ShowData(mysql, myconn);
            myconn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            current.Text = "GNSS点";
            biao = 3;
            string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            string mystr, mysql;//连接字符串和查询字符串
            SQLiteConnection myconn = new SQLiteConnection();//建立连接
            mystr = @"Data Source = " + path + "数据库.db" + "; Version = 3;";
            myconn.ConnectionString = mystr;
            myconn.Open();
            mysql = "SELECT*FROM" + " GNSS点表";//获取查询字符串
            tableshow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ShowData(mysql, myconn);
        }
        //导出数据
        private void 导出数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "控制点查询结果保存";
            saveFileDialog1.Filter = "文本文件(*.txt)|*.txt|Excel文件(*.xlsx)|*.xlsx|DAT文件(*.dat)|*.dat";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // txt文件
                if (saveFileDialog1.FilterIndex == 1)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                    List<string> arrstr = new List<string>();
                    string str = null;
                    for (int i = 0; i < tableshow.Columns.Count; i++)//表头
                    {
                        arrstr.Add(string.Format("{0,10}", tableshow.Columns[i].HeaderText));//10表示格式化10个字符，原字符右对齐，不足则补空格,但是对文字好像不是特别好使
                    }
                    str = string.Join("\t", arrstr);
                    sw.WriteLine(str);
                    for (int i = 0; i < tableshow.Rows.Count; i++)//数据
                    {
                        str = null;
                        arrstr.Clear();
                        for (int j = 0; j < tableshow.Columns.Count; j++)
                        {
                            if (tableshow.Rows[i].Cells[j].Value == null)
                            {
                                arrstr.Add(string.Format("{0,10}", "\t"));
                            }
                            else
                            {
                                arrstr.Add(string.Format("{0,10}", tableshow.Rows[i].Cells[j].Value));
                            }
                        }
                        str = string.Join("\t", arrstr);
                        sw.WriteLine(str);
                    }
                    sw.Close();
                }

                // excel文件
                else if (saveFileDialog1.FilterIndex == 2)
                {
                    string fileName = "";   //文件路径，文件名


                    saveFileDialog1.DefaultExt = "xls";//获取或设置默认文件扩展名

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        fileName = saveFileDialog1.FileName;
                    }
                    else
                    {
                        return;
                    }

                    Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                    if (xlApp == null)
                    {
                        MessageBox.Show("无法创建Excel对象，您的电脑可能未安装Excel");
                        return;
                    }

                    Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
                    Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                    Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1 

                    //写入标题
                    for (int i = 0; i < tableshow.ColumnCount; i++)
                    {
                        worksheet.Cells[1, i + 1] = tableshow.Columns[i].HeaderText;
                    }
                    //写入数值
                    for (int r = 0; r < tableshow.Rows.Count; r++)
                    {
                        for (int i = 0; i < tableshow.ColumnCount; i++)
                        {
                            worksheet.Cells[r + 2, i + 1] = tableshow.Rows[r].Cells[i].Value;
                        }
                        System.Windows.Forms.Application.DoEvents();
                    }
                    worksheet.Columns.EntireColumn.AutoFit();//列宽自适应
                    MessageBox.Show(fileName + "的结果保存成功", "提示", MessageBoxButtons.OK);
                    if (fileName != "")
                    {
                        try
                        {
                            workbook.Saved = true;
                            workbook.SaveCopyAs(fileName);
                            //fileSaved = true;
                        }
                        catch (Exception ex)
                        {
                            //fileSaved = false;
                            MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
                        }
                    }
                    xlApp.Quit();
                    GC.Collect();
                }
                else if (saveFileDialog1.FilterIndex == 3)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                    List<string> arrstr = new List<string>();
                    string str = null;
                    for (int i = 0; i < tableshow.Columns.Count; i++)//表头
                    {
                        arrstr.Add(tableshow.Columns[i].HeaderText);//10表示格式化10个字符，原字符右对齐，不足则补空格,但是对文字好像不是特别好使
                    }
                    sw.WriteLine(str);
                    for (int i = 0; i < tableshow.Rows.Count; i++)//数据
                    {
                        str = null;
                        arrstr.Clear();
                        for (int j = 0; j < tableshow.Columns.Count; j++)
                        {
                            if (tableshow.Rows[i].Cells[j].Value == null)
                            {
                                arrstr.Add(",");
                            }
                            else
                            {
                                arrstr.Add("," + tableshow.Rows[i].Cells[j].Value);
                            }
                        }
                        sw.WriteLine(str);
                    }
                    sw.Close();
                }
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 搜索_CheckedChanged(object sender, EventArgs e)
        {
            List<string> tablename = new List<string>();
            sqliteClass sqlite = new sqliteClass();
            string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            string mystr, mysql;//连接字符串和查询字符串
            SQLiteConnection myconn = new SQLiteConnection();//建立连接
            mystr = @"Data Source = " + path + "数据库.db" + "; Version = 3;";
            myconn.ConnectionString = mystr;
            myconn.Open();
            //获取表名拼接字符串
            mysql = "SELECT*FROM " + NowTable() + " WHERE 点名 LIKE '%" + 查询.Text + "%';";//获取查询字符串
            ShowData(mysql, myconn);
            myconn.Close();
        }
        //判断现在在浏览哪个表的方法
        public static string NowTable()
        {
            if (biao == 0)
            {
                return "水准点表";
            }
            else if (biao == 1)
            {
                return "导线点表";
            }
            else
            {
                return "GNSS点表";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            控制点信息管理 kzd = new 控制点信息管理();
            kzd.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            current.Text = "用户信息";
            string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            string mystr, mysql;//连接字符串和查询字符串
            using (SQLiteConnection myconn = new SQLiteConnection())
            {//建立连接
                mystr = @"Data Source = " + path + "数据库.db" + "; Version = 3;";
                myconn.ConnectionString = mystr;
                myconn.Open();
                mysql = "SELECT*FROM" + " 用户";//获取查询字符串
                ShowData(mysql, myconn);
                tableshow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//datagridveiw行自动填充对齐当前窗体大小
                myconn.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            current.Text = "申请中账号";
            string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            string mystr, mysql;//连接字符串和查询字符串
            using (SQLiteConnection myconn = new SQLiteConnection())
            {//建立连接
                mystr = @"Data Source = " + path + "数据库.db" + "; Version = 3;";
                myconn.ConnectionString = mystr;
                myconn.Open();
                mysql = "SELECT*FROM" + " 注册用户";//获取查询字符串
                ShowData(mysql, myconn);
                tableshow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                myconn.Close();
            }
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            //try
            //{
            string[] zh = new string[tableshow.Rows.Count];
            string[] mm = new string[tableshow.Rows.Count];
            string sqlin = "";
            string sqlde = "";
            int k = 0;//计数选择了几行
            try
            {
                for (int i = 0; i < tableshow.Rows.Count; i++)//遍历所有行
                {
                    if (tableshow.Rows[i].Selected == true)
                    {
                        k++;
                        zh[i] = tableshow.Rows[i].Cells[0].Value.ToString();
                        mm[i] = tableshow.Rows[i].Cells[1].Value.ToString();   //获取密码
                                                                               //sql.InsertRow(zh[i], mm[i], "账号", "密码", "用户");//插入用户//这里不能这样，会导致多线程报错
                                                                               //sql.Delet(zh[i]);
                        sqlin += $"INSERT INTO 用户 VALUES ('{zh[i]}','{mm[i]}');";
                        sqlde += $"DELETE FROM 注册用户 WHERE 账号='{zh[i]}';";
                    }
                }
                if (tableshow.Rows[0].Selected.ToString() == null|| tableshow.Rows[0].Selected == false)
                {
                    MessageBox.Show("请选择合适的数据");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("请选择合适的数据");
                return;

            }
            //执行上一节生成的sql语句并更新表的显示，这里必须执行一步关一步，不然会导致多线程，而sqlite不支持多线程
            //这里其实可以设置成主键和外键的约束
            string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            using (SQLiteConnection myconn = new SQLiteConnection(@"Data Source = " + path + "数据库.db" + "; Version = 3;"))
            {
                using (SQLiteCommand inst = new SQLiteCommand(sqlin, myconn))
                {
                    myconn.Open();
                    var result = inst.ExecuteNonQuery();
                    myconn.Close();

                }
            }
            using (SQLiteConnection myconn1 = new SQLiteConnection(@"Data Source = " + path + "数据库.db" + "; Version = 3;"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sqlde, myconn1))
                {
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    myconn1.Close();
                }
            }
            string mysql = "SELECT*FROM" + " 注册用户";//获取查询字符串
            using (SQLiteConnection myconn1 = new SQLiteConnection(@"Data Source = " + path + "数据库.db" + "; Version = 3;"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(mysql, myconn1))
                {
                    cmd.Connection.Open();
                    ShowData(mysql, myconn1);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("授权成功");
            //myconn.Close();
            //}
            //catch 
            //{
            //    MessageBox.Show("请选择合适的数据");
            //}
        }

        private void button11_Click(object sender, EventArgs e)
        {

            string[] zh = new string[tableshow.Rows.Count];//字符串存储账号信息
            string sqlde = "";
            int k = 0;//计数选择了几行
            try
            {
                for (int i = 0; i < tableshow.Rows.Count; i++)//遍历所有行
                {
                    if (tableshow.Rows[i].Selected == true)
                    {
                        k++;
                        zh[i] = tableshow.Rows[i].Cells[0].Value.ToString();
                        sqlde += $"DELETE FROM 用户 WHERE 账号='{zh[i]}';";
                    }
                }
                if (tableshow.Rows[0].Selected.ToString() == null || tableshow.Rows[0].Selected == false)
                {
                    MessageBox.Show("请选择合适的数据");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("请选择合适的数据");
                return;

            }
            string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            using (SQLiteConnection myconn1 = new SQLiteConnection(@"Data Source = " + path + "数据库.db" + "; Version = 3;"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sqlde, myconn1))
                {
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    myconn1.Close();
                }
            }
            string mysql = "SELECT*FROM" + " 用户";//获取查询字符串
            using (SQLiteConnection myconn1 = new SQLiteConnection(@"Data Source = " + path + "数据库.db" + "; Version = 3;"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(mysql, myconn1))
                {
                    cmd.Connection.Open();
                    ShowData(mysql, myconn1);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("注销成功");
            //myconn.Close();
            //}
            //catch 
            //{
            //    MessageBox.Show("请选择合适的数据");
            //}

        }

        private void tableshow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (panel5.Visible == false)//如果单击没显示就显示，如果显示了再点击就隐藏
            {
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                panel5.Visible = true;
                panel7.Visible = true;
                panel8.Visible = true;
                panel9.Visible = true;
                if (level == 0)//用户级别还是不让他显示
                {
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel4.Visible = false;

                }
            }
            else
            {
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
            }
        }

        private void menuy_Click(object sender, EventArgs e)
        {
            if (panel11.Visible == false)
            {
                panel11.Visible = true;
                panel12.Visible = true;
                panel13.Visible = true;
                panel14.Visible = true;
            }
            else 
            {
                panel11.Visible = false;
                panel12.Visible = false;
                panel13.Visible = false;
                panel14.Visible = false;
            }
        }

        private void tableshow_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            多条件查询 cx = new 多条件查询();
            cx.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string table = NowTable();
            string[] zh = new string[tableshow.Rows.Count];//字符串存储账号信息
            string sqlde = "";
            int k = 0;//计数选择了几行
            try
            {
                for (int i = 0; i < tableshow.Rows.Count; i++)//遍历所有行
                {
                    if (tableshow.Rows[i].Selected == true)
                    {
                        k++;
                        zh[i] = tableshow.Rows[i].Cells[0].Value.ToString();
                        sqlde += $"DELETE FROM {table} WHERE 点名='{zh[i]}';";
                    }
                }
                if (sqlde=="")
                {
                    MessageBox.Show("请选择合适的数据");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("请选择合适的数据");
                return;

            }
            string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            using (SQLiteConnection myconn1 = new SQLiteConnection(@"Data Source = " + path + "数据库.db" + "; Version = 3;"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sqlde, myconn1))
                {
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    myconn1.Close();
                }
            }
            string mysql = "SELECT*FROM" + $" {table}";//获取查询字符串
            using (SQLiteConnection myconn1 = new SQLiteConnection(@"Data Source = " + path + "数据库.db" + "; Version = 3;"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(mysql, myconn1))
                {
                    cmd.Connection.Open();
                    ShowData(mysql, myconn1);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("删除成功");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("确认要保存修改内容吗？", "提示", MessageBoxButtons.OKCancel);
            if (R == DialogResult.OK)
            {
                string sql;
                if (NowTable() == "水准点表")
                {
                    sql = "update " + NowTable() + " set 点名='" + tableshow.SelectedCells[0].Value + "',位置='" + tableshow.SelectedCells[1].Value + "',B='" + tableshow.SelectedCells[2].Value +
                       "',L='" + tableshow.SelectedCells[3].Value + "',H='" + tableshow.SelectedCells[4].Value + "',高程='" + tableshow.SelectedCells[5].Value + "',埋石类型='" + tableshow.SelectedCells[6].Value + "'," +
                       "等级='" + tableshow.SelectedCells[7].Value + "' where 点名='" + tableshow.SelectedCells[0].Value + "'";
                }
                else if (NowTable() == "导线点表")
                {
                    sql = "update " + NowTable() + " set 点名='" + tableshow.SelectedCells[0].Value + "',位置='" + tableshow.SelectedCells[1].Value + "',X='" + tableshow.SelectedCells[2].Value +
                       "',Y='" + tableshow.SelectedCells[3].Value + "',H='" + tableshow.SelectedCells[4].Value + "',坐标系='" + tableshow.SelectedCells[5].Value + "',埋石类型='" + tableshow.SelectedCells[6].Value + "'," +
                       "等级='" + tableshow.SelectedCells[7].Value + "',中央子午线='" + tableshow.SelectedCells[8].Value + "',B='" + tableshow.SelectedCells[9].Value + "',L='" + tableshow.SelectedCells[10].Value + "' where 点名='" + tableshow.SelectedCells[0].Value + "'";
                }
                else if (NowTable() == "GNSS点表")
                {
                    sql = "update " + NowTable() + " set 点名='" + tableshow.SelectedCells[0].Value + "',位置='" + tableshow.SelectedCells[1].Value + "',X='" + tableshow.SelectedCells[2].Value +
                       "',Y='" + tableshow.SelectedCells[3].Value + "',H='" + tableshow.SelectedCells[4].Value + "',坐标系='" + tableshow.SelectedCells[5].Value + "',埋石类型='" + tableshow.SelectedCells[6].Value + "'," +
                       "等级='" + tableshow.SelectedCells[7].Value + "',中央子午线='" + tableshow.SelectedCells[8].Value + "',B='" + tableshow.SelectedCells[9].Value + "',L='" + tableshow.SelectedCells[10].Value + "' where 点名='" + tableshow.SelectedCells[0].Value + "'";
                }
                else
                {
                    sql = "";
                }

                string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
                using (SQLiteConnection myconn1 = new SQLiteConnection(@"Data Source = " + path + "数据库.db" + "; Version = 3;"))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, myconn1))
                    {
                        cmd.Connection.Open();
                        ShowData(sql, myconn1);
                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("修改成功");
            }
        }
    }
}
