
namespace 校园测量控制点管理系统
{
    public partial class 控制点管理
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(控制点管理));
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableshow = new System.Windows.Forms.DataGridView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.current = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uiLinkLabel1 = new Sunny.UI.UILinkLabel();
            this.搜索 = new Sunny.UI.UIRadioButton();
            this.查询 = new Sunny.UI.UITextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.导出数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Chart1 = new Sunny.UI.UIDoughnutChart();
            this.char2 = new Sunny.UI.UIBarChart();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.skinFlowLayoutPanel2 = new CCWin.SkinControl.SkinFlowLayoutPanel();
            this.kong = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.yonghu = new System.Windows.Forms.Panel();
            this.menuy = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableshow)).BeginInit();
            this.panel10.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.skinFlowLayoutPanel2.SuspendLayout();
            this.kong.SuspendLayout();
            this.yonghu.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tableshow);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Location = new System.Drawing.Point(324, 39);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1083, 1171);
            this.panel6.TabIndex = 6;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // tableshow
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableshow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableshow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tableshow.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tableshow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableshow.DefaultCellStyle = dataGridViewCellStyle2;
            this.tableshow.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableshow.Location = new System.Drawing.Point(3, 135);
            this.tableshow.Name = "tableshow";
            this.tableshow.RowHeadersWidth = 82;
            this.tableshow.RowTemplate.Height = 40;
            this.tableshow.Size = new System.Drawing.Size(1075, 1036);
            this.tableshow.TabIndex = 9;
            this.tableshow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableshow_CellContentClick_1);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.current);
            this.panel10.Controls.Add(this.label1);
            this.panel10.Controls.Add(this.uiLinkLabel1);
            this.panel10.Controls.Add(this.搜索);
            this.panel10.Controls.Add(this.查询);
            this.panel10.Controls.Add(this.menuStrip2);
            this.panel10.Location = new System.Drawing.Point(0, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1624, 129);
            this.panel10.TabIndex = 8;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // current
            // 
            this.current.AutoSize = true;
            this.current.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.current.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.current.Location = new System.Drawing.Point(851, 72);
            this.current.Name = "current";
            this.current.Size = new System.Drawing.Size(0, 48);
            this.current.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(640, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 48);
            this.label1.TabIndex = 13;
            this.label1.Text = "当前数据：";
            // 
            // uiLinkLabel1
            // 
            this.uiLinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiLinkLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.uiLinkLabel1.Location = new System.Drawing.Point(3, 78);
            this.uiLinkLabel1.Name = "uiLinkLabel1";
            this.uiLinkLabel1.Size = new System.Drawing.Size(171, 46);
            this.uiLinkLabel1.TabIndex = 12;
            this.uiLinkLabel1.TabStop = true;
            this.uiLinkLabel1.Text = "搜索点名";
            this.uiLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiLinkLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // 搜索
            // 
            this.搜索.BackColor = System.Drawing.Color.Silver;
            this.搜索.Cursor = System.Windows.Forms.Cursors.Hand;
            this.搜索.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.搜索.Location = new System.Drawing.Point(500, 66);
            this.搜索.MinimumSize = new System.Drawing.Size(1, 1);
            this.搜索.Name = "搜索";
            this.搜索.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.搜索.Size = new System.Drawing.Size(115, 58);
            this.搜索.TabIndex = 3;
            this.搜索.Text = "搜索";
            this.搜索.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.搜索.CheckedChanged += new System.EventHandler(this.搜索_CheckedChanged);
            // 
            // 查询
            // 
            this.查询.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.查询.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.查询.Location = new System.Drawing.Point(174, 66);
            this.查询.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.查询.MinimumSize = new System.Drawing.Size(1, 16);
            this.查询.Name = "查询";
            this.查询.ShowText = false;
            this.查询.Size = new System.Drawing.Size(319, 58);
            this.查询.TabIndex = 11;
            this.查询.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.查询.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(138, 39);
            this.menuStrip2.TabIndex = 11;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出数据ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(130, 35);
            this.toolStripMenuItem1.Text = "数据处理";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 导出数据ToolStripMenuItem
            // 
            this.导出数据ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("导出数据ToolStripMenuItem.Image")));
            this.导出数据ToolStripMenuItem.Name = "导出数据ToolStripMenuItem";
            this.导出数据ToolStripMenuItem.Size = new System.Drawing.Size(243, 44);
            this.导出数据ToolStripMenuItem.Text = "导出数据";
            this.导出数据ToolStripMenuItem.Click += new System.EventHandler(this.导出数据ToolStripMenuItem_Click);
            // 
            // Chart1
            // 
            this.Chart1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Chart1.LegendFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Chart1.Location = new System.Drawing.Point(1413, 174);
            this.Chart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.Chart1.Name = "Chart1";
            this.Chart1.Size = new System.Drawing.Size(741, 606);
            this.Chart1.SubFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Chart1.TabIndex = 10;
            this.Chart1.TagString = "表";
            this.Chart1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Chart1.Click += new System.EventHandler(this.Chart1_Click);
            // 
            // char2
            // 
            this.char2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.char2.LegendFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.char2.Location = new System.Drawing.Point(1413, 786);
            this.char2.MinimumSize = new System.Drawing.Size(1, 1);
            this.char2.Name = "char2";
            this.char2.Size = new System.Drawing.Size(741, 424);
            this.char2.SubFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.char2.TabIndex = 10;
            this.char2.Text = "uiBarChart1";
            this.char2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.button8);
            this.panel11.Location = new System.Drawing.Point(3, 879);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(310, 69);
            this.panel11.TabIndex = 9;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(3, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(289, 63);
            this.button8.TabIndex = 0;
            this.button8.Text = "用户管理";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 784);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(480, 0);
            this.dataGridView1.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button7);
            this.panel9.Location = new System.Drawing.Point(3, 709);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(310, 69);
            this.panel9.TabIndex = 7;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(289, 63);
            this.button7.TabIndex = 0;
            this.button7.Text = "多条件查询";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button6);
            this.panel8.Location = new System.Drawing.Point(3, 634);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(310, 69);
            this.panel8.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(289, 63);
            this.button6.TabIndex = 0;
            this.button6.Text = "GNSS点";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button5);
            this.panel7.Location = new System.Drawing.Point(3, 559);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(310, 69);
            this.panel7.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(289, 63);
            this.button5.TabIndex = 0;
            this.button5.Text = "水准点";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button4);
            this.panel5.Location = new System.Drawing.Point(3, 484);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(310, 69);
            this.panel5.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(289, 63);
            this.button4.TabIndex = 0;
            this.button4.Text = "导线点";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Location = new System.Drawing.Point(3, 409);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 69);
            this.panel4.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(289, 63);
            this.button3.TabIndex = 0;
            this.button3.Text = "删除点信息";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(3, 334);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 69);
            this.panel3.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(289, 63);
            this.button2.TabIndex = 0;
            this.button2.Text = "修改点信息";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(3, 259);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 69);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "添加点信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 161);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(29, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(249, 154);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // skinFlowLayoutPanel2
            // 
            this.skinFlowLayoutPanel2.BackColor = System.Drawing.Color.Gainsboro;
            this.skinFlowLayoutPanel2.Controls.Add(this.panel1);
            this.skinFlowLayoutPanel2.Controls.Add(this.kong);
            this.skinFlowLayoutPanel2.Controls.Add(this.panel2);
            this.skinFlowLayoutPanel2.Controls.Add(this.panel3);
            this.skinFlowLayoutPanel2.Controls.Add(this.panel4);
            this.skinFlowLayoutPanel2.Controls.Add(this.panel5);
            this.skinFlowLayoutPanel2.Controls.Add(this.panel7);
            this.skinFlowLayoutPanel2.Controls.Add(this.panel8);
            this.skinFlowLayoutPanel2.Controls.Add(this.panel9);
            this.skinFlowLayoutPanel2.Controls.Add(this.dataGridView1);
            this.skinFlowLayoutPanel2.Controls.Add(this.yonghu);
            this.skinFlowLayoutPanel2.Controls.Add(this.panel11);
            this.skinFlowLayoutPanel2.Controls.Add(this.panel12);
            this.skinFlowLayoutPanel2.Controls.Add(this.panel14);
            this.skinFlowLayoutPanel2.Controls.Add(this.panel13);
            this.skinFlowLayoutPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinFlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.skinFlowLayoutPanel2.DownBack = null;
            this.skinFlowLayoutPanel2.Location = new System.Drawing.Point(8, 39);
            this.skinFlowLayoutPanel2.MaximumSize = new System.Drawing.Size(310, 1171);
            this.skinFlowLayoutPanel2.MinimumSize = new System.Drawing.Size(97, 1171);
            this.skinFlowLayoutPanel2.MouseBack = null;
            this.skinFlowLayoutPanel2.Name = "skinFlowLayoutPanel2";
            this.skinFlowLayoutPanel2.NormlBack = null;
            this.skinFlowLayoutPanel2.Size = new System.Drawing.Size(310, 1171);
            this.skinFlowLayoutPanel2.TabIndex = 0;
            this.skinFlowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.skinFlowLayoutPanel2_Paint);
            // 
            // kong
            // 
            this.kong.Controls.Add(this.button12);
            this.kong.Location = new System.Drawing.Point(3, 170);
            this.kong.Name = "kong";
            this.kong.Size = new System.Drawing.Size(310, 83);
            this.kong.TabIndex = 15;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.DarkOrange;
            this.button12.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button12.Location = new System.Drawing.Point(6, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(304, 77);
            this.button12.TabIndex = 0;
            this.button12.Text = "控制点管理";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // yonghu
            // 
            this.yonghu.Controls.Add(this.menuy);
            this.yonghu.Location = new System.Drawing.Point(3, 790);
            this.yonghu.Name = "yonghu";
            this.yonghu.Size = new System.Drawing.Size(310, 83);
            this.yonghu.TabIndex = 14;
            // 
            // menuy
            // 
            this.menuy.BackColor = System.Drawing.Color.DarkOrange;
            this.menuy.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuy.Location = new System.Drawing.Point(6, 3);
            this.menuy.Name = "menuy";
            this.menuy.Size = new System.Drawing.Size(304, 77);
            this.menuy.TabIndex = 0;
            this.menuy.Text = "用户信息管理";
            this.menuy.UseVisualStyleBackColor = false;
            this.menuy.Click += new System.EventHandler(this.menuy_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.button9);
            this.panel12.Location = new System.Drawing.Point(3, 954);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(310, 69);
            this.panel12.TabIndex = 10;
            this.panel12.Paint += new System.Windows.Forms.PaintEventHandler(this.panel12_Paint);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(3, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(289, 63);
            this.button9.TabIndex = 0;
            this.button9.Text = "申请管理";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.button11);
            this.panel14.Location = new System.Drawing.Point(3, 1029);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(310, 69);
            this.panel14.TabIndex = 12;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(3, 0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(289, 63);
            this.button11.TabIndex = 0;
            this.button11.Text = "注销所选账号";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.button10);
            this.panel13.Location = new System.Drawing.Point(3, 1104);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(310, 69);
            this.panel13.TabIndex = 11;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(3, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(289, 63);
            this.button10.TabIndex = 0;
            this.button10.Text = "通过所选账号申请";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // 控制点管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2590, 1630);
            this.Controls.Add(this.char2);
            this.Controls.Add(this.skinFlowLayoutPanel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.Chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "控制点管理";
            this.Text = "控制点管理";
            this.Load += new System.EventHandler(this.控制点管理_Load);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableshow)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.skinFlowLayoutPanel2.ResumeLayout(false);
            this.kong.ResumeLayout(false);
            this.yonghu.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel10;
        private Sunny.UI.UIBarChart char2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 导出数据ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Sunny.UI.UITextBox 查询;
        private Sunny.UI.UIRadioButton 搜索;
        public Sunny.UI.UIDoughnutChart Chart1;
        private Sunny.UI.UILinkLabel uiLinkLabel1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CCWin.SkinControl.SkinFlowLayoutPanel skinFlowLayoutPanel2;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button button11;
        public System.Windows.Forms.DataGridView tableshow;
        private System.Windows.Forms.Label current;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel yonghu;
        private System.Windows.Forms.Button menuy;
        private System.Windows.Forms.Panel kong;
        private System.Windows.Forms.Button button12;
    }
}