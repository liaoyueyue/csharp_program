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

namespace WarehouseManagementSystem.Forms.UserForm
{
    public partial class UpdateUserForm : Form
    {
        User newUser { get; set; }
        UserManager userManager = new UserManager();
        private User user;
        public UpdateUserForm(User user)
        {
            InitializeComponent();
            this.user = user;
            usernameTxt.Text = user.Username;
            passwordTxt.Text = user.Password;
            nameTxt.Text = user.Nickname;
            informationTxt.Text = user.ContactInformation;
        }

        protected void updateUserBtn_Click(object sender, EventArgs e)
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
            newUser = new User(user.UserId, username, password, name, contactInformation);
            message = userManager.UpdateUser(newUser);
            MessageBox.Show(message, "提交提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
