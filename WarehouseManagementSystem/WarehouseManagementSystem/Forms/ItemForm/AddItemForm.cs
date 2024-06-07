using ItemBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseBLL;
using WarehouseModels;

namespace WarehouseManagementSystem.Forms.ItemForm
{
	public partial class AddItemForm : Form
	{
		Item newItem {  get; set; }
		ItemManager manager = new ItemManager();
		public AddItemForm()
		{
			InitializeComponent();
		}

		private void addBtn_Click(object sender, EventArgs e)
		{
			string name = ItemNameTxt.Text;
			string description = itemDescriptionTxt.Text;
			string location = locationTxt.Text;
			string stockQuantity = stockQuantityTxt.Text;
			string warehouseId = warehouseIdTxt.Text;
			if (name == string.Empty || description == string.Empty || location == string.Empty || stockQuantity == string.Empty || warehouseId == string.Empty)
			{
				MessageBox.Show("请填写完整信息");
				return;
			}
			string message = string.Empty;
			newItem = new Item(name, description, location, Convert.ToInt32(stockQuantity), Convert.ToInt32(warehouseId));
			message = manager.AddItem(newItem);
			MessageBox.Show(message, "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			if (message == "添加物品成功")
			{
				this.Close();
			}
		}
	}
}
