
namespace seizeBiliName
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.AimName = new System.Windows.Forms.ListBox();
            this.AllowName = new System.Windows.Forms.ListBox();
            this.check = new System.Windows.Forms.Timer(this.components);
            this.state = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.ifSendEmail = new System.Windows.Forms.CheckBox();
            this.start = new System.Windows.Forms.Button();
            this.over = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.CheckBox();
            this.checkEmail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 266);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 21);
            this.textBox1.TabIndex = 3;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(125, 266);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(54, 24);
            this.Add.TabIndex = 4;
            this.Add.Text = "添加";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(125, 296);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(54, 24);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "删除";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // AimName
            // 
            this.AimName.FormattingEnabled = true;
            this.AimName.ItemHeight = 12;
            this.AimName.Location = new System.Drawing.Point(23, 76);
            this.AimName.Name = "AimName";
            this.AimName.Size = new System.Drawing.Size(156, 184);
            this.AimName.TabIndex = 6;
            // 
            // AllowName
            // 
            this.AllowName.FormattingEnabled = true;
            this.AllowName.ItemHeight = 12;
            this.AllowName.Location = new System.Drawing.Point(307, 76);
            this.AllowName.Name = "AllowName";
            this.AllowName.Size = new System.Drawing.Size(156, 88);
            this.AllowName.TabIndex = 7;
            // 
            // check
            // 
            this.check.Interval = 5000;
            this.check.Tick += new System.EventHandler(this.check_Tick);
            // 
            // state
            // 
            this.state.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.state.Location = new System.Drawing.Point(191, 76);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(97, 24);
            this.state.TabIndex = 8;
            this.state.Text = "未发现异常";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.email.Location = new System.Drawing.Point(191, 140);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(110, 24);
            this.email.TabIndex = 9;
            this.email.Text = "邮件系统正常";
            // 
            // ifSendEmail
            // 
            this.ifSendEmail.AutoSize = true;
            this.ifSendEmail.Location = new System.Drawing.Point(307, 170);
            this.ifSendEmail.Name = "ifSendEmail";
            this.ifSendEmail.Size = new System.Drawing.Size(96, 16);
            this.ifSendEmail.TabIndex = 10;
            this.ifSendEmail.TabStop = false;
            this.ifSendEmail.Text = "是否发送邮件";
            this.ifSendEmail.UseVisualStyleBackColor = true;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(307, 236);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(54, 24);
            this.start.TabIndex = 11;
            this.start.Text = "开始";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // over
            // 
            this.over.Location = new System.Drawing.Point(367, 236);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(54, 24);
            this.over.TabIndex = 12;
            this.over.Text = "结束";
            this.over.UseVisualStyleBackColor = true;
            this.over.Click += new System.EventHandler(this.over_Click);
            // 
            // hide
            // 
            this.hide.AutoSize = true;
            this.hide.Location = new System.Drawing.Point(307, 192);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(120, 16);
            this.hide.TabIndex = 13;
            this.hide.TabStop = false;
            this.hide.Text = "开始后隐藏主界面";
            this.hide.UseVisualStyleBackColor = true;
            // 
            // checkEmail
            // 
            this.checkEmail.Location = new System.Drawing.Point(206, 184);
            this.checkEmail.Name = "checkEmail";
            this.checkEmail.Size = new System.Drawing.Size(71, 24);
            this.checkEmail.TabIndex = 14;
            this.checkEmail.Text = "测试邮件";
            this.checkEmail.UseVisualStyleBackColor = true;
            this.checkEmail.Click += new System.EventHandler(this.checkEmail_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(249, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "还未开始";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(185, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "目前状态：";
            // 
            // e
            // 
            this.e.Location = new System.Drawing.Point(427, 236);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(54, 24);
            this.e.TabIndex = 17;
            this.e.Text = "重启";
            this.e.UseVisualStyleBackColor = true;
            this.e.Click += new System.EventHandler(this.e_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 337);
            this.Controls.Add(this.e);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkEmail);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.over);
            this.Controls.Add(this.start);
            this.Controls.Add(this.ifSendEmail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.state);
            this.Controls.Add(this.AllowName);
            this.Controls.Add(this.AimName);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.85D;
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "B站抢昵称";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ListBox AimName;
        private System.Windows.Forms.ListBox AllowName;
        private System.Windows.Forms.Timer check;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.CheckBox ifSendEmail;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button over;
        private System.Windows.Forms.CheckBox hide;
        private System.Windows.Forms.Button checkEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button e;
    }
}

