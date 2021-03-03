using Journal.Forms.Groups;
using Journal.Forms.Students;
using Journal.Forms.Subjects;
using Journal.Forms.Teachers;
using Journal.Forms.Users;
using Journal.Models;
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
    public partial class MainWindow : Form
    {
        private CurrentUser CurrentUser;
        public MainWindow(CurrentUser user)
        {
            InitializeComponent();
            CurrentUser = user;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (CurrentUser.Role == "Админ")
            {
                UsersBtn.Visible = true;
            }
        }

        private void GroupInfo_Click(object sender, EventArgs e)
        {
            new SelectModalWindow(CurrentUser).Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ViewPerfomance_Click(object sender, EventArgs e)
        {
            new SelectModalWindow(CurrentUser, "Студенты").Show();
        }

        private void TeacherList_Click(object sender, EventArgs e)
        {
            new ListTeachers(CurrentUser).Show();
        }

        private void SubjectList_Click(object sender, EventArgs e)
        {
            new ListSubjects(CurrentUser).Show();
        }

        private void StudentsList_Click(object sender, EventArgs e)
        {
            new ListStudents(CurrentUser).Show();
        }

        private void GroupList_Click(object sender, EventArgs e)
        {
            new ListGroups(CurrentUser).Show();
        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            new ListUsers(CurrentUser).Show();
        }

        private void Timetable_Click(object sender, EventArgs e)
        {
            new SelectModalWindow(CurrentUser, "Расписание").Show();
        }

        private void JournalBtn_Click(object sender, EventArgs e)
        {
            new SelectModalWindow(CurrentUser, "Журнал").Show();
        }

        private void InfoItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программное средство разработал учащийся группы 2218\nГрибович Артём Дмитриевич.");
        }
    }
}
