using Journal.Forms.Journal;
using Journal.Forms.Perfomance;
using Journal.Forms.Timetable;
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

namespace Journal.Forms
{
    public partial class SelectModalWindow : Form
    {
        private readonly GroupsService _service;
        private readonly StudentsService _serviceStud;
        private readonly CurrentUser CurrentUser;
        private string SelectList = null;
        private bool IsLoad = false;

        public SelectModalWindow(CurrentUser user)
        {
            InitializeComponent();
            _service = new GroupsService();
            CurrentUser = user;
        }

        public SelectModalWindow(CurrentUser user, string list)
        {
            InitializeComponent();
            _service = new GroupsService();
            _serviceStud = new StudentsService();
            CurrentUser = user;
            SelectList = list;
        }

        private void SelectGroupModalWindow_Load(object sender, EventArgs e)
        {
            var table = _service.GetAllGroups();
            if (SelectList == "Расписание")
            {
                label2.Text = "Выберите дату";
                label3.Visible = true;
                label4.Visible = true;
                StartDate.Visible = true;
                EndDate.Visible = true;
                var row = table.NewRow();
                row[0] = "0";
                row[1] = "Все группы";
                table.Rows.InsertAt(row, 0);
            }
            GroupSelect.DataSource = table;
            GroupSelect.DisplayMember = "Name";
            GroupSelect.ValueMember = "Id";
            if(SelectList == "Расписание")
            {
                GroupSelect.SelectedIndex = 0;
            }
            else
            {
                GroupSelect.SelectedIndex = -1;
            }
            IsLoad = true;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (SelectList == "Студенты")
            {
                if (SelectStudents.SelectedIndex != -1)
                {
                    new ListPerfomance(CurrentUser, Convert.ToInt32(SelectStudents.SelectedValue), SelectStudents.Text).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Выберите студента");
                }
            }
            else if (SelectList == "Расписание")
            {
                if (GroupSelect.SelectedIndex != -1)
                {
                    new Timetable.Timetable(CurrentUser, Convert.ToInt32(GroupSelect.SelectedValue), StartDate.Value, EndDate.Value).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Выберите студента");
                }
            }
            else if (SelectList == "Журнал")
            {
                if (GroupSelect.SelectedIndex != -1)
                {
                    new JournalGroup(CurrentUser, Convert.ToInt32(GroupSelect.SelectedValue)).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Выберите группу");
                }
            }
            else
            {
                if (GroupSelect.SelectedIndex != -1)
                {
                    new GroupInfo(Convert.ToInt32(GroupSelect.SelectedValue), CurrentUser).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Выберите группу", "Ошибка");
                }
            }
        }

        private void GroupSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectList == "Студенты" && IsLoad)
            {
                SelectStudents.DataSource = _serviceStud.GetStudentsGroup(Convert.ToInt32(GroupSelect.SelectedValue));
                SelectStudents.DisplayMember = "Name";
                SelectStudents.ValueMember = "Id";
                SelectStudents.SelectedIndex = -1;
                label2.Visible = true;
                SelectStudents.Visible = true;
            }
        }
    }
}
