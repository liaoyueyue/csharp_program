namespace WarehouseManagementSystem
{
    partial class UserForm
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
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.warehouseTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.userTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.itemTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.operationGroupBox = new System.Windows.Forms.GroupBox();
			this.queryTxt = new System.Windows.Forms.TextBox();
			this.addBtn = new System.Windows.Forms.Button();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.updateBtn = new System.Windows.Forms.Button();
			this.queryBtn = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.UserId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip.SuspendLayout();
			this.operationGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.warehouseTSMI,
            this.userTSMI,
            this.itemTSMI});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(835, 28);
			this.menuStrip.TabIndex = 1;
			this.menuStrip.Text = "menuStrip1";
			// 
			// warehouseTSMI
			// 
			this.warehouseTSMI.Name = "warehouseTSMI";
			this.warehouseTSMI.Size = new System.Drawing.Size(83, 24);
			this.warehouseTSMI.Text = "仓库管理";
			this.warehouseTSMI.Click += new System.EventHandler(this.warehouseTSMI_Click);
			// 
			// userTSMI
			// 
			this.userTSMI.Name = "userTSMI";
			this.userTSMI.Size = new System.Drawing.Size(83, 24);
			this.userTSMI.Text = "用户管理";
			this.userTSMI.Click += new System.EventHandler(this.userTSMI_Click);
			// 
			// itemTSMI
			// 
			this.itemTSMI.Name = "itemTSMI";
			this.itemTSMI.Size = new System.Drawing.Size(83, 24);
			this.itemTSMI.Text = "物品管理";
			this.itemTSMI.Click += new System.EventHandler(this.itemTSMI_Click);
			// 
			// operationGroupBox
			// 
			this.operationGroupBox.Controls.Add(this.queryTxt);
			this.operationGroupBox.Controls.Add(this.addBtn);
			this.operationGroupBox.Controls.Add(this.deleteBtn);
			this.operationGroupBox.Controls.Add(this.updateBtn);
			this.operationGroupBox.Controls.Add(this.queryBtn);
			this.operationGroupBox.Location = new System.Drawing.Point(0, 35);
			this.operationGroupBox.Margin = new System.Windows.Forms.Padding(4);
			this.operationGroupBox.Name = "operationGroupBox";
			this.operationGroupBox.Padding = new System.Windows.Forms.Padding(4);
			this.operationGroupBox.Size = new System.Drawing.Size(835, 58);
			this.operationGroupBox.TabIndex = 9;
			this.operationGroupBox.TabStop = false;
			this.operationGroupBox.Text = "操作";
			// 
			// queryTxt
			// 
			this.queryTxt.Location = new System.Drawing.Point(40, 22);
			this.queryTxt.Margin = new System.Windows.Forms.Padding(4);
			this.queryTxt.Name = "queryTxt";
			this.queryTxt.Size = new System.Drawing.Size(301, 25);
			this.queryTxt.TabIndex = 1;
			// 
			// addBtn
			// 
			this.addBtn.Location = new System.Drawing.Point(676, 21);
			this.addBtn.Margin = new System.Windows.Forms.Padding(4);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(100, 29);
			this.addBtn.TabIndex = 0;
			this.addBtn.Text = "新增";
			this.addBtn.UseVisualStyleBackColor = true;
			this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
			// 
			// deleteBtn
			// 
			this.deleteBtn.Location = new System.Drawing.Point(568, 21);
			this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(100, 29);
			this.deleteBtn.TabIndex = 0;
			this.deleteBtn.Text = "删除";
			this.deleteBtn.UseVisualStyleBackColor = true;
			this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
			// 
			// updateBtn
			// 
			this.updateBtn.Location = new System.Drawing.Point(460, 21);
			this.updateBtn.Margin = new System.Windows.Forms.Padding(4);
			this.updateBtn.Name = "updateBtn";
			this.updateBtn.Size = new System.Drawing.Size(100, 29);
			this.updateBtn.TabIndex = 0;
			this.updateBtn.Text = "修改";
			this.updateBtn.UseVisualStyleBackColor = true;
			this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
			// 
			// queryBtn
			// 
			this.queryBtn.Location = new System.Drawing.Point(351, 21);
			this.queryBtn.Margin = new System.Windows.Forms.Padding(4);
			this.queryBtn.Name = "queryBtn";
			this.queryBtn.Size = new System.Drawing.Size(100, 29);
			this.queryBtn.TabIndex = 0;
			this.queryBtn.Text = "查询";
			this.queryBtn.UseVisualStyleBackColor = true;
			this.queryBtn.Click += new System.EventHandler(this.queryBtn_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.dataGridView.Location = new System.Drawing.Point(0, 100);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.RowTemplate.Height = 23;
			this.dataGridView.Size = new System.Drawing.Size(835, 412);
			this.dataGridView.TabIndex = 10;
			this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
			// 
			// UserId1
			// 
			this.UserId1.DataPropertyName = "UserId";
			this.UserId1.HeaderText = "用户编号";
			this.UserId1.MinimumWidth = 6;
			this.UserId1.Name = "UserId1";
			this.UserId1.Width = 125;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "Username";
			this.Column2.HeaderText = "用户名";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.Width = 125;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "Password";
			this.Column3.HeaderText = "密码";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.Width = 125;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "Nickname";
			this.Column4.HeaderText = "昵称";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.Width = 125;
			// 
			// Column5
			// 
			this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column5.DataPropertyName = "ContactInformation";
			this.Column5.HeaderText = "信息";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			// 
			// UserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(835, 514);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.operationGroupBox);
			this.Controls.Add(this.menuStrip);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "UserForm";
			this.Text = "仓库管理系统";
			this.Load += new System.EventHandler(this.Main_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.operationGroupBox.ResumeLayout(false);
			this.operationGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem itemTSMI;
        private System.Windows.Forms.GroupBox operationGroupBox;
        private System.Windows.Forms.Button queryBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox queryTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.ToolStripMenuItem userTSMI;
		private System.Windows.Forms.ToolStripMenuItem warehouseTSMI;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserId1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
	}
}