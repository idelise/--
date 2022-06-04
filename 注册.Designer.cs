
namespace 校园测量控制点管理系统
{
    partial class 注册
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
            this.用户名 = new System.Windows.Forms.TextBox();
            this.密码 = new System.Windows.Forms.TextBox();
            this.确认密码 = new System.Windows.Forms.TextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 用户名
            // 
            this.用户名.Location = new System.Drawing.Point(349, 131);
            this.用户名.Name = "用户名";
            this.用户名.Size = new System.Drawing.Size(200, 38);
            this.用户名.TabIndex = 0;
            // 
            // 密码
            // 
            this.密码.Location = new System.Drawing.Point(349, 204);
            this.密码.Name = "密码";
            this.密码.Size = new System.Drawing.Size(200, 38);
            this.密码.TabIndex = 1;
            // 
            // 确认密码
            // 
            this.确认密码.Location = new System.Drawing.Point(349, 279);
            this.确认密码.Name = "确认密码";
            this.确认密码.Size = new System.Drawing.Size(200, 38);
            this.确认密码.TabIndex = 2;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.skinLabel1.Location = new System.Drawing.Point(207, 134);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(86, 31);
            this.skinLabel1.TabIndex = 3;
            this.skinLabel1.Text = "用户名";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.skinLabel2.Location = new System.Drawing.Point(231, 211);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(62, 31);
            this.skinLabel2.TabIndex = 4;
            this.skinLabel2.Text = "密码";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.skinLabel3.Location = new System.Drawing.Point(183, 282);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(110, 31);
            this.skinLabel3.TabIndex = 5;
            this.skinLabel3.Text = "确认密码";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "申请";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 注册
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 581);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.确认密码);
            this.Controls.Add(this.密码);
            this.Controls.Add(this.用户名);
            this.Name = "注册";
            this.Text = "注册";
            this.Load += new System.EventHandler(this.注册_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox 用户名;
        private System.Windows.Forms.TextBox 密码;
        private System.Windows.Forms.TextBox 确认密码;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private System.Windows.Forms.Button button1;
    }
}