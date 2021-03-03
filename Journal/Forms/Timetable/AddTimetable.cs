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

namespace Journal.Forms.Timetable
{
    public partial class AddTimetable : Form
    {
        private readonly CurrentUser User;
        private TimetableService _service;
        private readonly GroupsService _serviceGroups;
        private readonly SubjectsService _serviceSubjects;
        private readonly TeachersService _serviceTeachers;
        private DateTime StartDate;
        private DateTime EndDate;
        private int IdGroup;

        public AddTimetable(CurrentUser user, DateTime start, DateTime end, int idGroup)
        {
            InitializeComponent();
            User = user;
            _service = new TimetableService();
            _serviceGroups = new GroupsService();
            _serviceSubjects = new SubjectsService();
            _serviceTeachers = new TeachersService();
            StartDate = start;
            EndDate = end;
            IdGroup = idGroup;
        }

        private void AddTimetable_Load(object sender, EventArgs e)
        {
            SubjectsSelect.DataSource = _serviceSubjects.GetAllSubjects();
            SubjectsSelect.DisplayMember = "ShortName";
            SubjectsSelect.ValueMember = "Id";
            SubjectsSelect.SelectedIndex = -1;

            GroupSelect.DataSource = _serviceGroups.GetAllGroups();
            GroupSelect.DisplayMember = "Name";
            GroupSelect.ValueMember = "Id";
            GroupSelect.SelectedIndex = -1;

            TeacherSelect.DataSource = _serviceTeachers.GetAllTeachers();
            TeacherSelect.DisplayMember = "Fio";
            TeacherSelect.ValueMember = "Id";
            TeacherSelect.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Timetable(User, IdGroup, StartDate, EndDate).Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GroupSelect.SelectedIndex != -1 && SubjectsSelect.SelectedIndex != -1 && TeacherSelect.SelectedIndex != -1)
            {
                Models.Timetable timetable = new Models.Timetable();
                timetable.Date = dateTimePicker1.Value;
                timetable.GroupId = Convert.ToInt32(GroupSelect.SelectedValue);
                timetable.SubjectId = Convert.ToInt32(SubjectsSelect.SelectedValue);
                timetable.TeacherId = Convert.ToInt32(TeacherSelect.SelectedValue);

                _service.Add(timetable);
                ClearField();
                MessageBox.Show("Добавлено");
            }
            else
            {
                MessageBox.Show("Заполните данные");
            }
        }

        private void ClearField()
        {
            SubjectsSelect.SelectedIndex = -1;
            GroupSelect.SelectedIndex = -1;
            TeacherSelect.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
