using System;
using System.Windows.Forms;
using WarehouseModels;
using WarehouseBLL;

namespace WarehouseManagementSystem.Forms.UserForm
{
    public partial class AddUserForm : Form
    {
        User newUser { get; set; }
        UserManager userManager = new UserManager();
        public AddUserForm()
        {
            InitializeComponent();
        }

        protected void addUserBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;
            string name = nameTxt.Text;
            string contactInformation = informationTxt.Text;
            if (username == string.Empty || password == string.Empty || name == string.Empty || contactInformation == string.Empty)
            {
                MessageBox.Show("请填写完整信息");
                return;
            }
            string message = string.Empty;
            newUser = new User(username, password, name, contactInformation);
            message = userManager.AddUser(newUser);
            MessageBox.Show(message, "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (message == "添加用户成功")
            {
                this.Close();
            }
        }
    }
}
