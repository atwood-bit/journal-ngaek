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

namespace Journal.Forms.Timetable
{
    public partial class Timetable : Form
    {
        private readonly CurrentUser User;
        private int IdGroup = -1;
        private readonly TimetableService _service;
        private DateTime StartDate;
        private DateTime EndDate;
        DataView view = new DataView();

        public Timetable(CurrentUser user, int idGroup, DateTime start, DateTime end)
        {
            InitializeComponent();
            User = user;
            IdGroup = idGroup;
            _service = new TimetableService();
            StartDate = start;
            EndDate = end;
        }

        private void Timetable_Load(object sender, EventArgs e)
        {
            BindingSource bs1 = new BindingSource();
            DataTable table = new DataTable();
            if (User.Role == "Преподаватель" || User.Role == "Админ")
            {
                BtnAdd.Visible = true;
            }
            if (IdGroup == 0 && StartDate == EndDate)
            {
                label1.Visible = true;
                SearchField.Visible = true;
                table = _service.GetTimetable(StartDate);
            }
            else if (IdGroup != 0 && StartDate == EndDate)
            {
                table = _service.GetTimetable(StartDate, IdGroup);
            }
            else if (IdGroup != 0 && StartDate != EndDate)
            {
                table = _service.GetTimetable(StartDate, EndDate, IdGroup);
            }
            else if (IdGroup == 0 && StartDate != EndDate)
            {
                label1.Visible = true;
                SearchField.Visible = true;
                table = _service.GetTimetable(StartDate, EndDate);
            }
            Grid.DataSource = table;
            bs1.DataSource = table;
            AddTimetable.BindingSource = bs1;
            Grid.Columns[0].Visible = false;
            Grid.Columns[3].Visible = false;
            Grid.Columns[5].Visible = false;
            Grid.Columns[6].Visible = false;
            Grid.Columns[7].Visible = false;
            Grid.Columns[8].Visible = false;
            Grid.Columns[10].Visible = false;
            Grid.Columns[11].Visible = false;
            Grid.Columns[13].Visible = false;
            Grid.Columns[1].HeaderText = "Группа";
            Grid.Columns[2].HeaderText = "Специальность";
            Grid.Columns[4].HeaderText = "Дата";
            Grid.Columns[9].HeaderText = "Предмет";
            Grid.Columns[12].HeaderText = "Преподаватель";
            Grid.AutoResizeColumns();
            view = table.DefaultView;
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (User.Role == "Преподаватель" || User.Role == "Админ")
            {
                DateTime date = Convert.ToDateTime(Grid.Rows[Grid.CurrentCell.RowIndex].Cells[4].Value.ToString());
                int id = Convert.ToInt32(Grid.Rows[Grid.CurrentCell.RowIndex].Cells[0].Value.ToString());
                string name = Convert.ToString(Grid.Rows[Grid.CurrentCell.RowIndex].Cells[1].Value.ToString());
                new ChangeTimetable(User, id, date, name, StartDate, EndDate).Show();
                this.Hide();
            }
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            ExcelHelper.SaveExcel(Grid, "Расписание");
        }

        private void SearchField_TextChanged(object sender, EventArgs e)
        {
            Grid = Search.SearchInGrid(Grid, "Name", SearchField.Text, view);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            new AddTimetable(User, StartDate, EndDate, IdGroup).Show();
            this.Hide();
        }
    }
}
