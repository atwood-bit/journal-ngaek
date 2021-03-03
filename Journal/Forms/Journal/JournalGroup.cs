using Journal.Helpers;
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

namespace Journal.Forms.Journal
{
    public partial class JournalGroup : Form
    {
        private readonly MarksService _service;
        private readonly StudentsService _serviceStudents;
        private readonly SubjectsService _serviceSubjects;
        private readonly CurrentUser User;
        private int IdGroup;

        public JournalGroup(CurrentUser user, int idGroup)
        {
            InitializeComponent();
            _service = new MarksService();
            _serviceStudents = new StudentsService();
            _serviceSubjects = new SubjectsService();
            User = user;
            IdGroup = idGroup;
        }

        private void JournalGroup_Load(object sender, EventArgs e)
        {
            FillLeftColumn();
            CreateHeaderTable();
            FillAllTable();
            Grid.AutoResizeColumns();
            if (User.Role == "Преподаватель" || User.Role == "Админ")
            {
                MarkBtn.Visible = true;
            }
        }

        private void CreateHeaderTable()
        {
            var subjects = _serviceSubjects.GetListSubject();
            var ids = _serviceSubjects.GetIdSubjects();
            for (int i = 0; i < subjects.Count; i++)
            {
                Grid.Columns.Add(ids[i], subjects[i]);
                Grid.Columns[i + 1].Name = ids[i];
            }
        }

        private void FillLeftColumn()
        {
            Grid.Columns.Add("Students", " ");
            var students = _serviceStudents.GetListStudents(IdGroup);
            for (int i = 0; i < students.Count; i++)
            {
                Grid.Rows.Add();
                Grid.Rows[i].Cells[0].Value = students[i];
            }
        }

        private void FillAllTable()
        {
            var ids_stud = _serviceStudents.GetIdStudents(IdGroup);
            for (int j = 0; j < ids_stud.Count; j++)
            {
                for (int i = 1; i < Grid.Columns.Count; i++)
                {
                    int subjId = Convert.ToInt32(Grid.Columns[i].Name);
                    Grid.Rows[j].Cells[i].Value = _service.GetMarkStudent(subjId, Convert.ToInt32(ids_stud[j]))[0];
                }
            }
        }

        private void MarkBtn_Click(object sender, EventArgs e)
        {
            new AddMarkJournal(User, IdGroup).Show();
            this.Hide();
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            ExcelHelper.SaveExcel(Grid, "Журнал группы");
        }
    }
}
