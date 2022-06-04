
namespace 校园测量控制点管理系统
{
    partial class 多条件查询
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
            this.biaoming = new System.Windows.Forms.ComboBox();
            this.weizhi = new System.Windows.Forms.TextBox();
            this.maishileix = new System.Windows.Forms.TextBox();
            this.level = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.queding = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // biaoming
            // 
            this.biaoming.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.biaoming.FormattingEnabled = true;
            this.biaoming.Items.AddRange(new object[] {
            "导线点表",
            "水准点表",
            "GNSS点表"});
            this.biaoming.Location = new System.Drawing.Point(384, 237);
            this.biaoming.Name = "biaoming";
            this.biaoming.Size = new System.Drawing.Size(263, 39);
            this.biaoming.TabIndex = 0;
            // 
            // weizhi
            // 
            this.weizhi.Location = new System.Drawing.Point(384, 301);
            this.weizhi.Name = "weizhi";
            this.weizhi.Size = new System.Drawing.Size(263, 38);
            this.weizhi.TabIndex = 1;
            this.weizhi.Text = "默认";
            // 
            // maishileix
            // 
            this.maishileix.Location = new System.Drawing.Point(384, 372);
            this.maishileix.Name = "maishileix";
            this.maishileix.Size = new System.Drawing.Size(263, 38);
            this.maishileix.TabIndex = 2;
            this.maishileix.Text = "默认";
            // 
            // level
            // 
            this.level.Location = new System.Drawing.Point(384, 445);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(263, 38);
            this.level.TabIndex = 3;
            this.level.Text = "默认";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(243, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "查找表：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(271, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "位置：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(215, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "埋石类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(271, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "等级：";
            // 
            // queding
            // 
            this.queding.Location = new System.Drawing.Point(287, 532);
            this.queding.Name = "queding";
            this.queding.Size = new System.Drawing.Size(150, 46);
            this.queding.TabIndex = 8;
            this.queding.Text = "查询";
            this.queding.UseVisualStyleBackColor = true;
            this.queding.Click += new System.EventHandler(this.queding_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(530, 532);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(150, 46);
            this.clear.TabIndex = 9;
            this.clear.Text = "清除";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // 多条件查询
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 748);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.queding);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.level);
            this.Controls.Add(this.maishileix);
            this.Controls.Add(this.weizhi);
            this.Controls.Add(this.biaoming);
            this.Name = "多条件查询";
            this.Text = "多条件查询";
            this.Load += new System.EventHandler(this.多条件查询_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox biaoming;
        private System.Windows.Forms.TextBox weizhi;
        private System.Windows.Forms.TextBox maishileix;
        private System.Windows.Forms.TextBox level;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button queding;
        private System.Windows.Forms.Button clear;
    }
}