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

namespace Journal.Forms.Teachers
{
    public partial class Teacher : Form
    {
        private readonly TeachersService _service;
        private readonly int TeacherId = -1;
        private readonly CurrentUser User = null;
        private readonly string NameTeacher = null;

        public Teacher(string action, CurrentUser user)
        {
            InitializeComponent();
            _service = new TeachersService();
            ActionBtn.Text = action;
            User = user;
        }

        public Teacher(string action, int teacherId, string name, CurrentUser user)
        {
            InitializeComponent();
            _service = new TeachersService();
            ActionBtn.Text = action;
            TeacherId = teacherId;
            User = user;
            NameTeacher = name;
        }

        private void ActionBtn_Click(object sender, EventArgs e)
        {
            if (ActionBtn.Text == "Добавить")
            {
                _service.Create(NameBox.Text);
                if (User != null)
                {
                    new ListTeachers(User).Show();
                }
            }
            else if (ActionBtn.Text == "Изменить")
            {
                _service.Update(ActionBtn.Text, TeacherId);
                if (User != null)
                {
                    new ListTeachers(User).Show();
                }
            }
            this.Hide();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            if (NameTeacher != null)
            {
                NameBox.Text = NameTeacher;
            }
        }
    }
}
