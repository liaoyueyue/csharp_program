namespace WarehouseManagementSystem
{
    partial class MainForm
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
            this.IncomingTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.outgoingTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.operationGroupBox = new System.Windows.Forms.GroupBox();
            this.queryTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.queryBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip.SuspendLayout();
            this.operationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.warehouseTSMI,
            this.userTSMI,
            this.itemTSMI,
            this.IncomingTSMI,
            this.outgoingTSMI});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(626, 25);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // warehouseTSMI
            // 
            this.warehouseTSMI.Name = "warehouseTSMI";
            this.warehouseTSMI.Size = new System.Drawing.Size(68, 21);
            this.warehouseTSMI.Text = "仓库管理";
            // 
            // userTSMI
            // 
            this.userTSMI.Name = "userTSMI";
            this.userTSMI.Size = new System.Drawing.Size(68, 21);
            this.userTSMI.Text = "用户管理";
            this.userTSMI.Click += new System.EventHandler(this.userTSMI_Click);
            // 
            // itemTSMI
            // 
            this.itemTSMI.Name = "itemTSMI";
            this.itemTSMI.Size = new System.Drawing.Size(68, 21);
            this.itemTSMI.Text = "物品管理";
            // 
            // IncomingTSMI
            // 
            this.IncomingTSMI.Name = "IncomingTSMI";
            this.IncomingTSMI.Size = new System.Drawing.Size(68, 21);
            this.IncomingTSMI.Text = "入库管理";
            // 
            // outgoingTSMI
            // 
            this.outgoingTSMI.Name = "outgoingTSMI";
            this.outgoingTSMI.Size = new System.Drawing.Size(68, 21);
            this.outgoingTSMI.Text = "出库管理";
            // 
            // operationGroupBox
            // 
            this.operationGroupBox.Controls.Add(this.queryTxt);
            this.operationGroupBox.Controls.Add(this.addBtn);
            this.operationGroupBox.Controls.Add(this.deleteBtn);
            this.operationGroupBox.Controls.Add(this.updateBtn);
            this.operationGroupBox.Controls.Add(this.queryBtn);
            this.operationGroupBox.Location = new System.Drawing.Point(0, 28);
            this.operationGroupBox.Name = "operationGroupBox";
            this.operationGroupBox.Size = new System.Drawing.Size(626, 46);
            this.operationGroupBox.TabIndex = 9;
            this.operationGroupBox.TabStop = false;
            this.operationGroupBox.Text = "操作";
            // 
            // queryTxt
            // 
            this.queryTxt.Location = new System.Drawing.Point(30, 18);
            this.queryTxt.Name = "queryTxt";
            this.queryTxt.Size = new System.Drawing.Size(227, 21);
            this.queryTxt.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(507, 17);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "新增";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(426, 17);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 0;
            this.deleteBtn.Text = "删除";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(345, 17);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 0;
            this.updateBtn.Text = "修改";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // queryBtn
            // 
            this.queryBtn.Location = new System.Drawing.Point(263, 17);
            this.queryBtn.Name = "queryBtn";
            this.queryBtn.Size = new System.Drawing.Size(75, 23);
            this.queryBtn.TabIndex = 0;
            this.queryBtn.Text = "查询";
            this.queryBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 80);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(626, 330);
            this.dataGridView.TabIndex = 10;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 411);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.operationGroupBox);
            this.Controls.Add(this.menuStrip);
            this.Name = "MainForm";
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
        private System.Windows.Forms.ToolStripMenuItem warehouseTSMI;
        private System.Windows.Forms.ToolStripMenuItem userTSMI;
        private System.Windows.Forms.ToolStripMenuItem itemTSMI;
        private System.Windows.Forms.ToolStripMenuItem IncomingTSMI;
        private System.Windows.Forms.ToolStripMenuItem outgoingTSMI;
        private System.Windows.Forms.GroupBox operationGroupBox;
        private System.Windows.Forms.Button queryBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox queryTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
    }
}