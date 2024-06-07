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
using WarehouseBLL;

namespace WarehouseManagementSystem
{
    public partial class AddUserForm : Form
    {
        #region Private Members
        User user = new User();
        UserManager userManager = new UserManager();
        #endregion

        public AddUserForm()
        {
            InitializeComponent();
        }

        private void addUserBtn_Click(object sender, EventArgs e)
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
            user = new User(username, password, name, contactInformation);
            message = userManager.AddUser(user);
            MessageBox.Show(message, "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            usernameTxt.Clear();
            passwordTxt.Clear();
            nameTxt.Clear();
            informationTxt.Clear();
        }
    }
}
