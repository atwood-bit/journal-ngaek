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
    public partial class ChangeTimetable : Form
    {
        private readonly SubjectsService _serviceSubjects;
        private readonly TeachersService _serviceTeachers;
        private readonly TimetableService _service;
        private CurrentUser User;
        private int IdGroup;
        private DateTime Date;
        private string GroupName = "";
        private DateTime EndDate;
        private DateTime StartDate;

        public ChangeTimetable(CurrentUser user, int idGroup, DateTime date, string groupName, DateTime endDate, DateTime startDate)
        {
            InitializeComponent();
            _service = new TimetableService();
            _serviceSubjects = new SubjectsService();
            _serviceTeachers = new TeachersService();
            User = user;
            IdGroup = idGroup;
            Date = Convert.ToDateTime(date.ToString("yyyy-MM-dd"));
            GroupName = groupName;
            StartDate = startDate;
            EndDate = endDate;
        }

        private void ChangeTimetable_Load(object sender, EventArgs e)
        {
            FillList();
            DateLbl.Text = $"Дата: {Date.ToString("yyyy-MM-dd")}";
            GroupLbl.Text = $"Группа: {GroupName}";
            SubjectSelect.DataSource = _serviceSubjects.GetAllSubjects();
            SubjectSelect.DisplayMember = "Name";
            SubjectSelect.ValueMember = "Id";
            SubjectSelect.SelectedIndex = -1;
            TeacherSelect.DataSource = _serviceTeachers.GetAllTeachers();
            TeacherSelect.DisplayMember = "Fio";
            TeacherSelect.ValueMember = "Id";
            TeacherSelect.SelectedIndex = -1;
        }

        private void FillList()
        {
            listView1.Items.Clear();
            listView1 = _service.GetListSubjectGroup(Date, IdGroup, listView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SubjectSelect.SelectedIndex != -1 && TeacherSelect.SelectedIndex != -1)
            {
                int subj = Convert.ToInt32(SubjectSelect.SelectedValue);
                int teach = Convert.ToInt32(TeacherSelect.SelectedValue);
                Models.Timetable timetable = new Models.Timetable() { Date = Date, GroupId = IdGroup, SubjectId = subj, TeacherId = teach };
                _service.Add(timetable);
                FillList();
            }
            else
            {
                MessageBox.Show("Заполните данные");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _service.Delete(Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text));
                FillList();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Выберите ID");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Timetable(User, IdGroup, StartDate, EndDate).Show();
            this.Hide();
        }
    }
}
