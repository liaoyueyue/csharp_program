using System;
using System.Windows.Forms;
using WarehouseBLL;
using WarehouseModels;

namespace WarehouseManagementSystem.Forms.WarehouseForm
{
	public partial class AddWarehouseForm : Form
	{
		Warehouse newWarehouse { get; set; }
		WarehouseManager manager = new WarehouseManager();

		public AddWarehouseForm()
		{
			InitializeComponent();
		}

		private void addBtn_Click(object sender, System.EventArgs e)
		{
			string name = warehouseNameTxt.Text;
			string address = warehouseAddressTxt.Text;
			string manger = warehouseManagerTxt.Text;
			if (name == string.Empty || address == string.Empty || name == string.Empty || manger == string.Empty)
			{
				MessageBox.Show("请填写完整信息");
				return;
			}
			string message = string.Empty;
			newWarehouse = new Warehouse(name, address, Convert.ToInt32(manger));
			message = manager.AddWarehouse(newWarehouse);
			MessageBox.Show(message, "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			if (message == "添加仓库成功")
			{
				this.Close();
			}
		}
	}
}
