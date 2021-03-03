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
    public partial class AddMarkJournal : Form
    {
        private readonly CurrentUser User;
        private readonly MarksService _service;
        private readonly SubjectsService _serviceSubjects;
        private readonly StudentsService _serviceStudents;
        private int IdGroup;

        public AddMarkJournal(CurrentUser user, int id)
        {
            InitializeComponent();
            User = user;
            IdGroup = id;
            _service = new MarksService();
            _serviceSubjects = new SubjectsService();
            _serviceStudents = new StudentsService();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new JournalGroup(User, IdGroup).Show();
            this.Hide();
        }

        private void AddMarkJournal_Load(object sender, EventArgs e)
        {
            SubjectsSelect.DataSource = _serviceSubjects.GetAllSubjects();
            SubjectsSelect.DisplayMember = "ShortName";
            SubjectsSelect.ValueMember = "Id";
            SubjectsSelect.SelectedIndex = -1;

            StudentsSelect.DataSource = _serviceStudents.GetStudentsGroup(IdGroup);
            StudentsSelect.DisplayMember = "Name";
            StudentsSelect.ValueMember = "Id";
            StudentsSelect.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SubjectsSelect.SelectedIndex != -1 && StudentsSelect.SelectedIndex != -1)
            {
                try
                {
                    int mark = Convert.ToInt32(MarkTxt.Text);

                    _service.AddMark(Convert.ToInt32(StudentsSelect.SelectedValue), Convert.ToInt32(SubjectsSelect.SelectedValue), mark);
                    MessageBox.Show("Добавлено");
                }
                catch
                {
                    MessageBox.Show("Оценка должна быть целым числом");
                }
            }
            else
            {
                MessageBox.Show("Выберите учащегося и предмет");
            }
        }
    }
}
