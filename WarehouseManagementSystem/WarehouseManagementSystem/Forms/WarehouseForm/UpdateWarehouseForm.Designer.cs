namespace WarehouseManagementSystem.Forms.WarehouseForm
{
	partial class UpdateWarehouseForm
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
			this.updateBtn = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.warehouseManagerTxt = new System.Windows.Forms.TextBox();
			this.warehouseAddressTxt = new System.Windows.Forms.TextBox();
			this.warehouseNameTxt = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// updateBtn
			// 
			this.updateBtn.Location = new System.Drawing.Point(65, 203);
			this.updateBtn.Margin = new System.Windows.Forms.Padding(4);
			this.updateBtn.Name = "updateBtn";
			this.updateBtn.Size = new System.Drawing.Size(249, 29);
			this.updateBtn.TabIndex = 22;
			this.updateBtn.Text = "修改";
			this.updateBtn.UseVisualStyleBackColor = true;
			this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("华文行楷", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label5.Location = new System.Drawing.Point(75, 36);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(239, 39);
			this.label5.TabIndex = 21;
			this.label5.Text = "修改仓库信息";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(62, 164);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 15);
			this.label3.TabIndex = 18;
			this.label3.Text = "仓库管理人编号";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(62, 130);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 15);
			this.label2.TabIndex = 19;
			this.label2.Text = "仓库地址";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(62, 96);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 15);
			this.label1.TabIndex = 20;
			this.label1.Text = "仓库名";
			// 
			// warehouseManagerTxt
			// 
			this.warehouseManagerTxt.Location = new System.Drawing.Point(182, 160);
			this.warehouseManagerTxt.Margin = new System.Windows.Forms.Padding(4);
			this.warehouseManagerTxt.Name = "warehouseManagerTxt";
			this.warehouseManagerTxt.Size = new System.Drawing.Size(132, 25);
			this.warehouseManagerTxt.TabIndex = 15;
			// 
			// warehouseAddressTxt
			// 
			this.warehouseAddressTxt.Location = new System.Drawing.Point(182, 126);
			this.warehouseAddressTxt.Margin = new System.Windows.Forms.Padding(4);
			this.warehouseAddressTxt.Name = "warehouseAddressTxt";
			this.warehouseAddressTxt.Size = new System.Drawing.Size(132, 25);
			this.warehouseAddressTxt.TabIndex = 16;
			// 
			// warehouseNameTxt
			// 
			this.warehouseNameTxt.Location = new System.Drawing.Point(182, 93);
			this.warehouseNameTxt.Margin = new System.Windows.Forms.Padding(4);
			this.warehouseNameTxt.Name = "warehouseNameTxt";
			this.warehouseNameTxt.Size = new System.Drawing.Size(132, 25);
			this.warehouseNameTxt.TabIndex = 17;
			// 
			// UpdateWarehouseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(377, 263);
			this.Controls.Add(this.updateBtn);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.warehouseManagerTxt);
			this.Controls.Add(this.warehouseAddressTxt);
			this.Controls.Add(this.warehouseNameTxt);
			this.Name = "UpdateWarehouseForm";
			this.Text = "修改仓库";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button updateBtn;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox warehouseManagerTxt;
		private System.Windows.Forms.TextBox warehouseAddressTxt;
		private System.Windows.Forms.TextBox warehouseNameTxt;
	}
}