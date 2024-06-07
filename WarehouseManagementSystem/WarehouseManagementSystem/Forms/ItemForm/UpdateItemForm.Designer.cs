namespace WarehouseManagementSystem.Forms.ItemForm
{
	partial class UpdateItemForm
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
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.warehouseIdTxt = new System.Windows.Forms.TextBox();
			this.stockQuantityTxt = new System.Windows.Forms.TextBox();
			this.locationTxt = new System.Windows.Forms.TextBox();
			this.itemDescriptionTxt = new System.Windows.Forms.TextBox();
			this.ItemNameTxt = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// updateBtn
			// 
			this.updateBtn.Location = new System.Drawing.Point(65, 259);
			this.updateBtn.Margin = new System.Windows.Forms.Padding(4);
			this.updateBtn.Name = "updateBtn";
			this.updateBtn.Size = new System.Drawing.Size(249, 29);
			this.updateBtn.TabIndex = 34;
			this.updateBtn.Text = "修改";
			this.updateBtn.UseVisualStyleBackColor = true;
			this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("华文行楷", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label5.Location = new System.Drawing.Point(103, 30);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(165, 39);
			this.label5.TabIndex = 33;
			this.label5.Text = "修改物品";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(62, 230);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 15);
			this.label6.TabIndex = 28;
			this.label6.Text = "管理员编号";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(62, 197);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 15);
			this.label4.TabIndex = 29;
			this.label4.Text = "库存";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(62, 164);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 15);
			this.label3.TabIndex = 30;
			this.label3.Text = "物品位置";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(62, 130);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 15);
			this.label2.TabIndex = 31;
			this.label2.Text = "物品详情";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(62, 96);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 15);
			this.label1.TabIndex = 32;
			this.label1.Text = "物品名";
			// 
			// warehouseIdTxt
			// 
			this.warehouseIdTxt.Location = new System.Drawing.Point(182, 226);
			this.warehouseIdTxt.Margin = new System.Windows.Forms.Padding(4);
			this.warehouseIdTxt.Name = "warehouseIdTxt";
			this.warehouseIdTxt.Size = new System.Drawing.Size(132, 25);
			this.warehouseIdTxt.TabIndex = 23;
			// 
			// stockQuantityTxt
			// 
			this.stockQuantityTxt.Location = new System.Drawing.Point(182, 193);
			this.stockQuantityTxt.Margin = new System.Windows.Forms.Padding(4);
			this.stockQuantityTxt.Name = "stockQuantityTxt";
			this.stockQuantityTxt.Size = new System.Drawing.Size(132, 25);
			this.stockQuantityTxt.TabIndex = 24;
			// 
			// locationTxt
			// 
			this.locationTxt.Location = new System.Drawing.Point(182, 160);
			this.locationTxt.Margin = new System.Windows.Forms.Padding(4);
			this.locationTxt.Name = "locationTxt";
			this.locationTxt.Size = new System.Drawing.Size(132, 25);
			this.locationTxt.TabIndex = 25;
			// 
			// itemDescriptionTxt
			// 
			this.itemDescriptionTxt.Location = new System.Drawing.Point(182, 130);
			this.itemDescriptionTxt.Margin = new System.Windows.Forms.Padding(4);
			this.itemDescriptionTxt.Name = "itemDescriptionTxt";
			this.itemDescriptionTxt.Size = new System.Drawing.Size(132, 25);
			this.itemDescriptionTxt.TabIndex = 26;
			// 
			// ItemNameTxt
			// 
			this.ItemNameTxt.Location = new System.Drawing.Point(182, 93);
			this.ItemNameTxt.Margin = new System.Windows.Forms.Padding(4);
			this.ItemNameTxt.Name = "ItemNameTxt";
			this.ItemNameTxt.Size = new System.Drawing.Size(132, 25);
			this.ItemNameTxt.TabIndex = 27;
			// 
			// UpdateItemForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(377, 319);
			this.Controls.Add(this.updateBtn);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.warehouseIdTxt);
			this.Controls.Add(this.stockQuantityTxt);
			this.Controls.Add(this.locationTxt);
			this.Controls.Add(this.itemDescriptionTxt);
			this.Controls.Add(this.ItemNameTxt);
			this.Name = "UpdateItemForm";
			this.Text = "修改物品";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button updateBtn;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox warehouseIdTxt;
		private System.Windows.Forms.TextBox stockQuantityTxt;
		private System.Windows.Forms.TextBox locationTxt;
		private System.Windows.Forms.TextBox itemDescriptionTxt;
		private System.Windows.Forms.TextBox ItemNameTxt;
	}
}