using System;
using System.Windows.Forms;
using WarehouseBLL;
using WarehouseManagementSystem.Forms.UserForm;
using WarehouseModels;

namespace WarehouseManagementSystem
{
    public partial class UserForm : Form
    {
        string userId = string.Empty;
        User user = new User();
        UserManager userManager = new UserManager();
        public UserForm()
        {
            InitializeComponent();
        }

        private void userTSMI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("显示用户管理界面", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadDataTable()
        {
            this.dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.DataSource = userManager.GetUserALL();
        }

        private void queryBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.queryTxt.Text))
                LoadDataTable();
            else
                this.dataGridView.DataSource = userManager.GetUserListByUsername(this.queryTxt.Text);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadDataTable();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using(var form = new AddUserForm())
            {
                var result = form.ShowDialog();
            }
            LoadDataTable();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userId))
            {
                DialogResult result = MessageBox.Show("您确实要删除此信息吗？", "提交提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    userManager.DeleteUserById(Convert.ToInt32(userId));
                    LoadDataTable();
                    MessageBox.Show("信息删除成功！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的信息！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //获取用户id
            userId = dataGridView.Rows[e.RowIndex].Cells["UserId1"].Value.ToString();
            //调用业务逻辑层GetUserById
            user = userManager.GetUserById(Convert.ToInt32(userId));
            /*MessageBox.Show(user.ToString(), "选择id用户信息");*/
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userId))
                MessageBox.Show("没有可修改信息，请选择要修改的信息！", "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                using (var form = new UpdateUserForm(user))
                {
                    var result = form.ShowDialog();
                }
                LoadDataTable();
            }
        }

        private void warehouseTSMI_Click(object sender, EventArgs e)
        {
            WarehouseForm warehouseForm = new WarehouseForm();
			this.Hide();
			warehouseForm.ShowDialog();
            this.Show();
		}

		private void itemTSMI_Click(object sender, EventArgs e)
		{
            ItemForm itemForm = new ItemForm();
			this.Hide();
			itemForm.ShowDialog();
			this.Show();
		}
	}
}
