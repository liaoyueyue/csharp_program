namespace WarehouseManagementSystem.Forms.UserForm
{
    partial class UpdateUserForm
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
			this.updateUserBtn = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.informationTxt = new System.Windows.Forms.TextBox();
			this.nameTxt = new System.Windows.Forms.TextBox();
			this.passwordTxt = new System.Windows.Forms.TextBox();
			this.usernameTxt = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// updateUserBtn
			// 
			this.updateUserBtn.Location = new System.Drawing.Point(113, 251);
			this.updateUserBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.updateUserBtn.Name = "updateUserBtn";
			this.updateUserBtn.Size = new System.Drawing.Size(211, 29);
			this.updateUserBtn.TabIndex = 14;
			this.updateUserBtn.Text = "修改";
			this.updateUserBtn.UseVisualStyleBackColor = true;
			this.updateUserBtn.Click += new System.EventHandler(this.updateUserBtn_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("华文行楷", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label5.Location = new System.Drawing.Point(91, 38);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(239, 39);
			this.label5.TabIndex = 13;
			this.label5.Text = "修改用户信息";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(111, 207);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 15);
			this.label4.TabIndex = 9;
			this.label4.Text = "联系方式";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(111, 173);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 15);
			this.label3.TabIndex = 10;
			this.label3.Text = "昵称";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(111, 140);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 15);
			this.label2.TabIndex = 11;
			this.label2.Text = "密码";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(111, 106);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 15);
			this.label1.TabIndex = 12;
			this.label1.Text = "用户名";
			// 
			// informationTxt
			// 
			this.informationTxt.Location = new System.Drawing.Point(191, 203);
			this.informationTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.informationTxt.Name = "informationTxt";
			this.informationTxt.Size = new System.Drawing.Size(132, 25);
			this.informationTxt.TabIndex = 5;
			// 
			// nameTxt
			// 
			this.nameTxt.Location = new System.Drawing.Point(191, 170);
			this.nameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.nameTxt.Name = "nameTxt";
			this.nameTxt.Size = new System.Drawing.Size(132, 25);
			this.nameTxt.TabIndex = 6;
			// 
			// passwordTxt
			// 
			this.passwordTxt.Location = new System.Drawing.Point(191, 136);
			this.passwordTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.passwordTxt.Name = "passwordTxt";
			this.passwordTxt.Size = new System.Drawing.Size(132, 25);
			this.passwordTxt.TabIndex = 7;
			// 
			// usernameTxt
			// 
			this.usernameTxt.Location = new System.Drawing.Point(191, 102);
			this.usernameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.usernameTxt.Name = "usernameTxt";
			this.usernameTxt.Size = new System.Drawing.Size(132, 25);
			this.usernameTxt.TabIndex = 8;
			// 
			// UpdateUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(427, 313);
			this.Controls.Add(this.updateUserBtn);
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
			this.Name = "UpdateUserForm";
			this.Text = "修改用户";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateUserBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox informationTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox usernameTxt;
    }
}