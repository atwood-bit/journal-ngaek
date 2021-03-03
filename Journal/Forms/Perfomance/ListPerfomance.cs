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

namespace Journal.Forms.Perfomance
{
    public partial class ListPerfomance : Form
    {
        private readonly StudentsService _service;
        private readonly CurrentUser User;
        private readonly int StudentId;
        DataView view = new DataView();
        private string NameStudent;

        public ListPerfomance(CurrentUser user, int id, string name)
        {
            InitializeComponent();
            User = user;
            StudentId = id;
            _service = new StudentsService();
            NameStudent = name;
        }

        private void ListPerfomance_Load(object sender, EventArgs e)
        {
            BindingSource bs1 = new BindingSource();
            var table = _service.GetPerfomanceStudent(StudentId);
            Grid.DataSource = table;
            bs1.DataSource = table;
            bindingNavigator1.BindingSource = bs1;
            Grid.Columns[0].HeaderText = "Предмет";
            Grid.Columns[1].HeaderText = "Ср. балл";
            Grid.AutoResizeColumns();
            view = table.DefaultView;
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            ExcelHelper.SaveExcel(Grid, $"Успеваемость - {NameStudent}");
        }

        private void SearchField_TextChanged(object sender, EventArgs e)
        {
            Grid = Search.SearchInGrid(Grid, "Name", SearchField.Text, view);
        }
    }
}
