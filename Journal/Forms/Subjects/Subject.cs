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

namespace Journal.Forms.Subjects
{
    public partial class Subject : Form
    {
        private readonly CurrentUser User;
        private readonly SubjectsService _service;
        private readonly TeachersService _serviceTeachers;
        private string Action;
        private readonly Models.Subjects SubjectModel;
        private int Id;

        public Subject(string action, CurrentUser user)
        {
            InitializeComponent();
            User = user;
            Action = action;
            _service = new SubjectsService();
            _serviceTeachers = new TeachersService();
            SubjectModel = new Models.Subjects();
        }

        public Subject(string action, CurrentUser user, Models.Subjects subject, int id)
        {
            InitializeComponent();
            _service = new SubjectsService();
            _serviceTeachers = new TeachersService();
            User = user;
            Action = action;
            SubjectModel = subject;
            Id = id;
        }

        private void Subject_Load(object sender, EventArgs e)
        {
            NameBox.Visible = false;
            SelectSubjects.DataSource = _service.GetAllSubjects();
            SelectSubjects.DisplayMember = "Name";
            SelectSubjects.ValueMember = "Id";
            SelectTeachers.DataSource = _serviceTeachers.GetAllTeachers();
            SelectTeachers.DisplayMember = "Fio";
            SelectTeachers.ValueMember = "Id";
            SelectTeachers.SelectedIndex = -1;
            SelectSubjects.SelectedIndex = -1;
            if (Action == "Изменить")
            {
                SelectSubjects.SelectedValue = SubjectModel.Id;
                SelectTeachers.SelectedValue = SubjectModel.TeacherId;
                NewSubject.Visible = false;
            }
            ActionBtn.Text = Action;
        }

        private void NewSubject_CheckedChanged(object sender, EventArgs e)
        {
            if (NewSubject.Checked == true)
            {
                SelectSubjects.Visible = false;
                NameBox.Visible = true;
            }
            else
            {
                SelectSubjects.Visible = true;
                NameBox.Visible = false;
            }
        }

        private void ActionBtn_Click(object sender, EventArgs e)
        {
            if (Action == "Добавить")
            {
                if (NewSubject.Checked == true && !String.IsNullOrWhiteSpace(NameBox.Text) && SelectTeachers.SelectedIndex != -1)
                {
                    SubjectModel.Name = NameBox.Text;
                    SubjectModel.TeacherId = Convert.ToInt32(SelectTeachers.SelectedValue);
                    _service.CreateSubjectAndInsertList(SubjectModel);
                    
                }
                else if (NewSubject.Checked == false && SelectTeachers.SelectedIndex != -1 && SelectSubjects.SelectedIndex != -1)
                {
                    SubjectModel.Id = Convert.ToInt32(SelectSubjects.SelectedValue);
                    SubjectModel.TeacherId = Convert.ToInt32(SelectTeachers.SelectedValue);
                    _service.InsertList(SubjectModel);
                }
                else
                {
                    MessageBox.Show("Введите данные");
                }
            }
            else if (Action == "Изменить")
            {
                if (SelectTeachers.SelectedIndex != -1 && SelectSubjects.SelectedIndex != -1)
                {
                    SubjectModel.Id = Convert.ToInt32(SelectSubjects.SelectedValue);
                    SubjectModel.TeacherId = Convert.ToInt32(SelectTeachers.SelectedValue);
                    _service.UpdateList(SubjectModel, Id);
                }
                else
                {
                    MessageBox.Show("Введите данные");
                }
            }
            new ListSubjects(User).Show();
            this.Hide();
        }
    }
}
