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


namespace WarehouseManagementSystem
{
    public partial class Main : Form
    {
        UserManager userManager = new UserManager();
        public Main()
        {
            InitializeComponent();
        }

        private void userTSMI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("显示用户管理界面");
        }

        private void LoadDataTable()
        {
            this.dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.DataSource = userManager.GetUserALL();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadDataTable();
        }
    }
}
