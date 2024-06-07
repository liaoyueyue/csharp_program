using System;
using System.Windows.Forms;
using WarehouseBLL;
using WarehouseModels;

namespace WarehouseManagementSystem.Forms.WarehouseForm
{
	public partial class UpdateWarehouseForm : Form
	{
		Warehouse newWarehouse { get; set; }
		WarehouseManager manager = new WarehouseManager();
		private Warehouse warehouse;
		public UpdateWarehouseForm(Warehouse warehouse)
		{
			InitializeComponent();
			this.warehouse = warehouse;
			warehouseNameTxt.Text = warehouse.warehouseName;
			warehouseAddressTxt.Text = warehouse.warehouseAddress;
			warehouseManagerTxt.Text = Convert.ToString(warehouse.warehouseManager);
		}

		private void updateBtn_Click(object sender, EventArgs e)
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
			newWarehouse = new Warehouse(warehouse.warehouseId, name, address, Convert.ToInt32(manger));
			message = manager.UpdateWarehouse(newWarehouse);
			MessageBox.Show(message, "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}
	}
}
