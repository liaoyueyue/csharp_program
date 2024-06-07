namespace WarehouseManagementSystem
{
    partial class WarehouseForm
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
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.operationGroupBox = new System.Windows.Forms.GroupBox();
			this.queryTxt = new System.Windows.Forms.TextBox();
			this.addBtn = new System.Windows.Forms.Button();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.updateBtn = new System.Windows.Forms.Button();
			this.queryBtn = new System.Windows.Forms.Button();
			this.warehouseTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.WarehouseId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.operationGroupBox.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WarehouseId1,
            this.Column2,
            this.Column3,
            this.Column4});
			this.dataGridView.Location = new System.Drawing.Point(0, 100);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.RowTemplate.Height = 23;
			this.dataGridView.Size = new System.Drawing.Size(835, 412);
			this.dataGridView.TabIndex = 13;
			this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
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
			this.operationGroupBox.TabIndex = 12;
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
			// warehouseTSMI
			// 
			this.warehouseTSMI.Name = "warehouseTSMI";
			this.warehouseTSMI.Size = new System.Drawing.Size(83, 24);
			this.warehouseTSMI.Text = "仓库管理";
			// 
			// menuStrip
			// 
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.warehouseTSMI});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(835, 28);
			this.menuStrip.TabIndex = 11;
			this.menuStrip.Text = "menuStrip1";
			// 
			// WarehouseId1
			// 
			this.WarehouseId1.DataPropertyName = "WarehouseId";
			this.WarehouseId1.HeaderText = "仓库编号";
			this.WarehouseId1.MinimumWidth = 6;
			this.WarehouseId1.Name = "WarehouseId1";
			this.WarehouseId1.Width = 125;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "WarehouseName";
			this.Column2.HeaderText = "仓库名称";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.Width = 125;
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column3.DataPropertyName = "WarehouseAddress";
			this.Column3.HeaderText = "仓库地址";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "WarehouseManager";
			this.Column4.HeaderText = "仓库管理人";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.Width = 125;
			// 
			// WarehouseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(835, 514);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.operationGroupBox);
			this.Controls.Add(this.menuStrip);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "WarehouseForm";
			this.Text = "仓库管理系统";
			this.Load += new System.EventHandler(this.Warehouse_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.operationGroupBox.ResumeLayout(false);
			this.operationGroupBox.PerformLayout();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox operationGroupBox;
        private System.Windows.Forms.TextBox queryTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button queryBtn;
		private System.Windows.Forms.ToolStripMenuItem warehouseTSMI;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.DataGridViewTextBoxColumn WarehouseId1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
	}
}