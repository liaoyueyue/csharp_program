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
using WarehouseModels;

namespace WarehouseManagementSystem.Forms.ItemForm
{
	public partial class UpdateItemForm : Form
	{
		Item newItem {  get; set; }
		ItemManager manager = new ItemManager();
		private Item item;
		public UpdateItemForm(Item item)
		{
			InitializeComponent();
			this.item = item;
			ItemNameTxt.Text = item.ItemName;
			itemDescriptionTxt.Text = item.ItemDescription;
			locationTxt.Text = item.Location;
			stockQuantityTxt.Text = Convert.ToString(item.StockQuantity);
			warehouseIdTxt.Text = Convert.ToString(item.WarehouseId);
		}

		private void updateBtn_Click(object sender, EventArgs e)
		{
			string itemName = ItemNameTxt.Text;
			string ItemDescription = itemDescriptionTxt.Text;
			string Location = locationTxt.Text;
			string StockQuantity = stockQuantityTxt.Text;
			string WarehouseId = warehouseIdTxt.Text;
			if (itemName == string.Empty || ItemDescription == string.Empty || Location == string.Empty || StockQuantity == string.Empty || WarehouseId == string.Empty)
			{
				MessageBox.Show("请填写完整信息");
				return;
			}
			string message = string.Empty;
			newItem = new Item(item.ItemId, itemName, ItemDescription, Location, Convert.ToInt32(StockQuantity), Convert.ToInt32(WarehouseId));
			message = manager.UpdateItem(newItem);
			MessageBox.Show(message, "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}
	}
}
