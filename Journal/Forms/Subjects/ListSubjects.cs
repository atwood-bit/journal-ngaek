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

namespace Journal.Forms.Subjects
{
    public partial class ListSubjects : Form
    {
        private readonly CurrentUser User;
        private readonly SubjectsService _service;
        private int SubjectId = -1;
        DataView view = new DataView();

        public ListSubjects(CurrentUser user)
        {
            InitializeComponent();
            User = user;
            _service = new SubjectsService();
        }

        private void ListSubjects_Load(object sender, EventArgs e)
        {
            if (User.Role == "Преподаватель" || User.Role == "Админ")
            {
                bindingNavigatorAddNewItem.Visible = true;
                bindingNavigatorDeleteItem.Visible = true;
            }
            BindingSource bs1 = new BindingSource();
            var table = _service.GetAllAndTeacher();
            Grid.DataSource = table;
            bs1.DataSource = table;
            bindingNavigator1.BindingSource = bs1;
            Grid.Columns[0].Visible = false;
            Grid.Columns[3].Visible = false;
            Grid.Columns[4].Visible = false;
            Grid.Columns[5].Visible = false;
            Grid.Columns[6].Visible = false;
            Grid.Columns[8].Visible = false;
            Grid.Columns[7].HeaderText = "ФИО преподавателя";
            Grid.Columns[1].HeaderText = "Предмет";
            Grid.Columns[2].HeaderText = "Аббревиатура";
            Grid.AutoResizeColumns();
            view = table.DefaultView;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            new Subject("Добавить", User).Show();
            this.Hide();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (SubjectId != -1)
            {
                _service.DeleteFromListTeacher(SubjectId);
                Grid.Rows.Remove(Grid.SelectedRows[0]);
                Grid.Refresh();
            }
            else
            {
                MessageBox.Show("Поле не выбрано");
            }
        }

        private void Grid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SubjectId = Convert.ToInt32(Grid.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Models.Subjects subject = new Models.Subjects();
            int selectRow = Grid.CurrentCell.RowIndex;
            subject.Id = Convert.ToInt32(Grid.Rows[selectRow].Cells[1].Value.ToString());
            subject.TeacherId = Convert.ToInt32(Grid.Rows[selectRow].Cells[2].Value.ToString());
            subject.Name = Grid.Rows[selectRow].Cells[4].Value.ToString();
            int id = Convert.ToInt32(Grid.Rows[selectRow].Cells[0].Value.ToString());
            new Subject("Изменить", User, subject, id).Show();
            this.Hide();
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            ExcelHelper.SaveExcel(Grid, "Список предметов");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SearchField_TextChanged(object sender, EventArgs e)
        {
            Grid = Search.SearchInGrid(Grid, "Name", SearchField.Text, view);
            Grid = Search.SearchInGrid(Grid, "ShortName", SearchField.Text, view);
            Grid = Search.SearchInGrid(Grid, "Fio", SearchField.Text, view);
        }
    }
}
