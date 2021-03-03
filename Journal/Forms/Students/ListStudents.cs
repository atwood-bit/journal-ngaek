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

namespace Journal.Forms.Students
{
    public partial class ListStudents : Form
    {
        private readonly CurrentUser User;
        private readonly StudentsService _service;
        private int StudentId = -1;
        DataView view = new DataView();

        public ListStudents(CurrentUser user)
        {
            InitializeComponent();
            User = user;
            _service = new StudentsService();
        }

        private void ListStudents_Load(object sender, EventArgs e)
        {
            if (User.Role == "Преподаватель" || User.Role == "Админ")
            {
                bindingNavigatorAddNewItem.Visible = true;
                bindingNavigatorDeleteItem.Visible = true;
            }
            BindingSource bs1 = new BindingSource();
            var table = _service.GetStudentsWithGroups();
            Grid.DataSource = table;
            bs1.DataSource = table;
            bindingNavigator1.BindingSource = bs1;
            Grid.Columns[0].Visible = false;
            Grid.Columns[2].Visible = false;
            Grid.Columns[3].Visible = false;
            Grid.Columns[4].Visible = false;
            Grid.Columns[1].HeaderText = "ФИО";
            Grid.Columns[5].HeaderText = "Группа";
            Grid.Columns[6].HeaderText = "Специальность";
            Grid.AutoResizeColumns();
            view = table.DefaultView;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            new Student("Добавить", User).Show();
            this.Hide();
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectRow = Grid.CurrentCell.RowIndex;
            StudentId = Convert.ToInt32(Grid.Rows[selectRow].Cells[0].Value.ToString());
            string nameStudent = Grid.Rows[selectRow].Cells[1].Value.ToString();
            int groupId = Convert.ToInt32(Grid.Rows[selectRow].Cells[2].Value.ToString());
            new Student(groupId, StudentId, "Изменить", User, nameStudent, "Студенты").Show();
            this.Hide();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (StudentId != -1)
            {
                _service.Delete(StudentId);
                Grid.Rows.Remove(Grid.SelectedRows[0]);
                Grid.Refresh();
            }
            else
            {
                MessageBox.Show("Выберите строку");
            }
        }

        private void Grid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            StudentId = Convert.ToInt32(Grid.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            ExcelHelper.SaveExcel(Grid, "Список учащихся");
        }

        private void SearchField_TextChanged(object sender, EventArgs e)
        {
            Grid = Search.SearchInGrid(Grid, "Name", SearchField.Text, view);
        }
    }
}
