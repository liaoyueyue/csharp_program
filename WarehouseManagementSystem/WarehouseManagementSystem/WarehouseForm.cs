using System;
using System.Windows.Forms;
using WarehouseBLL;
using WarehouseManagementSystem.Forms.WarehouseForm;
using WarehouseModels;

namespace WarehouseManagementSystem
{
    public partial class WarehouseForm : Form
    {
        string warehouseId = string.Empty;
        Warehouse warehouse = new Warehouse();
        WarehouseManager warehouserManager = new WarehouseManager();
        public WarehouseForm()
        {
            InitializeComponent();
        }

        private void Warehouse_Load(object sender, EventArgs e)
        {
            LoadDataTable();
        }

        private void LoadDataTable()
        {
            this.dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.DataSource = warehouserManager.GetWarehouseAll();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            warehouseId = dataGridView.Rows[e.RowIndex].Cells["WarehouseId1"].Value.ToString();
            warehouse = warehouserManager.GetWarehouseById(Convert.ToInt32(warehouseId));
        }

        private void queryBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.queryTxt.Text))
                LoadDataTable();
            else
                this.dataGridView.DataSource = warehouserManager.GetWarehouseListByName(this.queryTxt.Text);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
			if (string.IsNullOrEmpty(warehouseId))
				MessageBox.Show("没有可修改信息，请选择要修改的信息！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
			{
				using (var form = new UpdateWarehouseForm(warehouse))
				{
					var result = form.ShowDialog();
				}
				LoadDataTable();
			}
		}

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(warehouseId))
            {
                DialogResult result = MessageBox.Show("您确实要删除此信息吗？", "提交提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    warehouserManager.DeleteWarehouseById(Convert.ToInt32(warehouseId));
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
			using (var form = new AddWarehouseForm())
			{
				var result = form.ShowDialog();
			}
			LoadDataTable();
		}
    }
}
