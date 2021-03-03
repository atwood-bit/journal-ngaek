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

namespace Journal.Forms.Groups
{
    public partial class Group : Form
    {
        private readonly CurrentUser User;
        private readonly GroupsService _service;
        private readonly Models.Groups group;
        private string Action;

        public Group(CurrentUser user, string action)
        {
            InitializeComponent();
            User = user;
            _service = new GroupsService();
            Action = action;
            group = new Models.Groups();
        }

        public Group(CurrentUser user, string action, Models.Groups editGroup)
        {
            InitializeComponent();
            User = user;
            _service = new GroupsService();
            Action = action;
            group = editGroup;
        }

        private void Group_Load(object sender, EventArgs e)
        {
            ActionBtn.Text = Action;
            NameBox.Text = group.Name;
            SpecialtyBox.Text = group.Specialty;
        }

        private void ActionBtn_Click(object sender, EventArgs e)
        {
            group.Name = NameBox.Text;
            group.Specialty = SpecialtyBox.Text;
            if (Action == "Добавить")
            {
                _service.AddGroup(group);
            }
            else if (Action == "Изменить")
            {
                _service.Update(group);
            }
            new ListGroups(User).Show();
            this.Hide();
        }
    }
}
