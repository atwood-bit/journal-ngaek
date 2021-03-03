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

namespace Journal.Forms.Students
{
    public partial class Student : Form
    {
        private readonly int GroupId;
        private readonly GroupsService _serviceGroup;
        private readonly StudentsService _serviceStudent;
        private readonly string Action;
        private readonly int StudentId;
        private readonly CurrentUser User = null;
        private readonly CurrentUser Current = null;
        private readonly string NameStudent = null;

        public Student(string action, CurrentUser user)
        {
            InitializeComponent();
            GroupId = -1;
            _serviceGroup = new GroupsService();
            _serviceStudent = new StudentsService();
            Action = action;
            StudentId = -1;
            Current = user;
        }

        public Student(int id_group, string action, CurrentUser user)
        {
            InitializeComponent();
            GroupId = id_group;
            _serviceGroup = new GroupsService();
            _serviceStudent = new StudentsService();
            Action = action;
            StudentId = -1;
            User = user;
        }

        public Student(int id_group, int studentId, string action, CurrentUser user, string name)
        {
            InitializeComponent();
            GroupId = id_group;
            _serviceGroup = new GroupsService();
            _serviceStudent = new StudentsService();
            Action = action;
            StudentId = studentId;
            User = user;
            NameStudent = name;
        }
        public Student(int id_group, int studentId, string action, CurrentUser user, string name, string form)
        {
            InitializeComponent();
            GroupId = id_group;
            _serviceGroup = new GroupsService();
            _serviceStudent = new StudentsService();
            Action = action;
            StudentId = studentId;
            Current = user;
            NameStudent = name;
        }

        private void AddStudents_Load(object sender, EventArgs e)
        {
            SelectGroup.DataSource = _serviceGroup.GetAllGroups();
            SelectGroup.DisplayMember = "Name";
            SelectGroup.ValueMember = "Id";
            SelectGroup.SelectedValue = GroupId;
            ActionBtn.Text = Action;
            if (NameStudent != null)
            {
                NameBox.Text = NameStudent;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(NameBox.Text) && SelectGroup.SelectedIndex != -1)
            {
                if (Action == "Добавить")
                {
                    _serviceStudent.Create(NameBox.Text, Convert.ToInt32(SelectGroup.SelectedValue));
                }
                else if (Action == "Изменить")
                {
                    _serviceStudent.Update(NameBox.Text, Convert.ToInt32(SelectGroup.SelectedValue), StudentId);
                    
                }
                if (User != null)
                {
                    new GroupInfo(GroupId, User).Show();
                }
                else
                {
                    new ListStudents(Current).Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Введите данные");
            }
        }
    }
}
