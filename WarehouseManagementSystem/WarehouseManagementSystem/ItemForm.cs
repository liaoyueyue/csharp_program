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
using WarehouseManagementSystem.Forms.ItemForm;
using WarehouseManagementSystem.Forms.WarehouseForm;
using WarehouseModels;

namespace WarehouseManagementSystem
{
	public partial class ItemForm : Form
	{
		string itemId = string.Empty;
		Item item = new Item();
		ItemManager itemManager = new ItemManager();

		public ItemForm()
		{
			InitializeComponent();
		}

		private void queryBtn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.queryTxt.Text))
				LoadDataTable();
			else
				this.dataGridView.DataSource = itemManager.GetItemListByName(this.queryTxt.Text);
		}

		private void updateBtn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(itemId))
				MessageBox.Show("没有可修改信息，请选择要修改的信息！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
			{
				using (var form = new UpdateItemForm(item))
				{
					var result = form.ShowDialog();
				}
				LoadDataTable();
			}
		}

		private void deleteBtn_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(itemId))
			{
				DialogResult result = MessageBox.Show("您确实要删除此信息吗？", "提交提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
				if (result == DialogResult.OK)
				{
					itemManager.DeleteItemById(Convert.ToInt32(itemId));
					LoadDataTable();
					MessageBox.Show("信息删除成功！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else
			{
				MessageBox.Show("请选择要删除的信息！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void addBtn_Click(object sender, EventArgs e)
		{
			using (var form = new AddItemForm())
			{
				var result = form.ShowDialog();
			}
			LoadDataTable();
		}

		private void ItemForm_Load(object sender, EventArgs e)
		{
			LoadDataTable();
		}
		private void LoadDataTable()
		{
			this.dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.DataSource = itemManager.GetItemAll();
		}

		private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			itemId = dataGridView.Rows[e.RowIndex].Cells["ItemId1"].Value.ToString();
			item = itemManager.GetItemById(Convert.ToInt32(itemId));
		}
	}
}
