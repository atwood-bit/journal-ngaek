using Journal.Models;
using Journal.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal.Forms.Users
{
    public partial class User : Form
    {
        private readonly CurrentUser UserModel;
        private readonly UsersService _service;
        private Models.User Model;

        public User(CurrentUser user, Models.User model)
        {
            InitializeComponent();
            UserModel = user;
            _service = new UsersService();
            Model = model;
        }

        private void User_Load(object sender, EventArgs e)
        {
            NameBox.Text = Model.Login;
            NameBox.Enabled = false;
            SelectRoles.DataSource = _service.GetRoles();
            SelectRoles.DisplayMember = "Role";
            SelectRoles.ValueMember = "Id";
            SelectRoles.SelectedValue = Model.Role;
        }

        private void ActionBtn_Click(object sender, EventArgs e)
        {
            Model.Role = Convert.ToInt32(SelectRoles.SelectedValue);
            _service.Update(Model);

            new ListUsers(UserModel).Show();
            this.Hide();
        }
    }
}
