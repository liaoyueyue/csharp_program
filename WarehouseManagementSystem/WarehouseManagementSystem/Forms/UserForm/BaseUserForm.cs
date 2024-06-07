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
    public partial class BaseUserForm : Form
    {
        public User newUser { get; protected set; }
        public UserManager userManager;
        public BaseUserForm()
        {
            userManager = new UserManager();
        }

        protected virtual void addUserBtn_Click(object sender, EventArgs e)
        {
            
        }

        protected virtual void updateUserBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
