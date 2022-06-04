using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace 校园测量控制点管理系统
{
    public class sqliteClass
    {
        string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;//获取当前路径
        SQLiteConnection m_dbConnection;
        public sqliteClass()
        {
            m_dbConnection = new SQLiteConnection(@"Data Source=" + path + "数据库.db" + ";Version=3;");//数据库连接
            m_dbConnection.Open();
        }
        public int CreateTable(string name)
        {
            string sql = "create table " + name + " (word varchar(200), image text)";
            SQLiteCommand cmd = new SQLiteCommand(sql, m_dbConnection);
            return cmd.ExecuteNonQuery();

        }
        //插入元素
        public void InsertRow(string word1,string word2,string col1 ,string col2,string table)
        {
            string sql;
            sql= "insert into " + table + " ("+col1+","+col2+")"+$" values ('{word1}','{word2}')"+";";//插入元素
            SQLiteCommand cmd = new SQLiteCommand(sql, m_dbConnection);
            cmd.ExecuteNonQuery();
            m_dbConnection.Close();
        }
        public List<string> GetTableNames()
        {
            List<string> Res = new List<string>();
            string[] restrictions = new string[4];
            restrictions[3] = "Table";
            DataTable Tables = null;
            //获取表名
            Tables = m_dbConnection.GetSchema("Tables", restrictions);

            for (int i = 0; i < Tables.Rows.Count; i++)
            {

                Res.Add(Tables.Rows[i][2].ToString());//这个Rows代表行，[i]代表行数[2]代表维度，第一维[0]是对象名，[1]是行属性，[2]才开始代表第一行
            }
            return Res;
        }
        //获取相应表
        public DataTable GetTable(string name)
        {

            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM " + name, m_dbConnection);
            da.Fill(dt);
            return dt;
        }
        //获取列名
        public List<string> GetColumnNames(string tableName)
        {
            List<string> Res = new List<string>();
            using (var cmd = new SQLiteCommand("select * from " + tableName, m_dbConnection))
            using (SQLiteDataReader reader = cmd.ExecuteReader(CommandBehavior.SchemaOnly))
            {
                var table = reader.GetSchemaTable();
                var nameCol = table.Columns["ColumnName"];
                foreach (DataRow row in table.Rows)
                {
                    Res.Add(row[nameCol].ToString());
                }
            }
            return Res;
        }
        //读取数据库
        public SQLiteDataReader Read(string str)
        {
            return  Command(str).ExecuteReader();
        }
        //建立数据库控制
        public SQLiteCommand Command(string str)
        {
            SQLiteCommand sqlcom = new SQLiteCommand(str, m_dbConnection);
            return sqlcom;
        }
        public void Delet(string zh)
        {
            string str = "";
            str = "DELETE FROM 注册用户 WHERE 账号 =" + zh;
            m_dbConnection.Close();
        }
        public void doNonQuery(string command, string path)
        {
            int ret = -1;
            using (SQLiteConnection conn = new SQLiteConnection(@"Data Source = " + path + "数据库.db" + "; Version = 3;"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(command, conn))
                {
                    cmd.Connection.Open();
                    
                    ret = cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

