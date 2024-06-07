namespace WarehouseManagementSystem.Forms.UserForm
{
    partial class AddUserForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
			this.usernameTxt = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.passwordTxt = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.nameTxt = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.informationTxt = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.addUserBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// usernameTxt
			// 
			this.usernameTxt.Location = new System.Drawing.Point(185, 109);
			this.usernameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.usernameTxt.Name = "usernameTxt";
			this.usernameTxt.Size = new System.Drawing.Size(132, 25);
			this.usernameTxt.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(105, 112);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "用户名";
			// 
			// passwordTxt
			// 
			this.passwordTxt.Location = new System.Drawing.Point(185, 142);
			this.passwordTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.passwordTxt.Name = "passwordTxt";
			this.passwordTxt.Size = new System.Drawing.Size(132, 25);
			this.passwordTxt.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(105, 146);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "密码";
			// 
			// nameTxt
			// 
			this.nameTxt.Location = new System.Drawing.Point(185, 176);
			this.nameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.nameTxt.Name = "nameTxt";
			this.nameTxt.Size = new System.Drawing.Size(132, 25);
			this.nameTxt.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(105, 180);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "昵称";
			// 
			// informationTxt
			// 
			this.informationTxt.Location = new System.Drawing.Point(185, 210);
			this.informationTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.informationTxt.Name = "informationTxt";
			this.informationTxt.Size = new System.Drawing.Size(132, 25);
			this.informationTxt.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(105, 214);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 15);
			this.label4.TabIndex = 2;
			this.label4.Text = "联系方式";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("华文行楷", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label5.Location = new System.Drawing.Point(129, 38);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(165, 39);
			this.label5.TabIndex = 3;
			this.label5.Text = "添加用户";
			// 
			// addUserBtn
			// 
			this.addUserBtn.Location = new System.Drawing.Point(108, 258);
			this.addUserBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addUserBtn.Name = "addUserBtn";
			this.addUserBtn.Size = new System.Drawing.Size(211, 29);
			this.addUserBtn.TabIndex = 4;
			this.addUserBtn.Text = "添加";
			this.addUserBtn.UseVisualStyleBackColor = true;
			this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
			// 
			// AddUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(427, 313);
			this.Controls.Add(this.addUserBtn);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.informationTxt);
			this.Controls.Add(this.nameTxt);
			this.Controls.Add(this.passwordTxt);
			this.Controls.Add(this.usernameTxt);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "AddUserForm";
			this.Text = "添加用户";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox informationTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addUserBtn;
    }
}

