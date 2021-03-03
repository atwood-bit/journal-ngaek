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

namespace Journal.Forms.Teachers
{
    public partial class ListTeachers : Form
    {
        private readonly CurrentUser CurrentUser;
        private readonly TeachersService _service;
        private int TeacherId;
        DataView view = new DataView();

        public ListTeachers(CurrentUser user)
        {
            InitializeComponent();
            CurrentUser = user;
            _service = new TeachersService();
            TeacherId = -1;
        }

        private void ListTeachers_Load(object sender, EventArgs e)
        {
            if (CurrentUser.Role == "Преподаватель" || CurrentUser.Role == "Админ")
            {
                bindingNavigatorAddNewItem.Visible = true;
                bindingNavigatorDeleteItem.Visible = true;
            }
            BindingSource bs1 = new BindingSource();
            var table = _service.GetAllTeachers();
            Grid.DataSource = table;
            bs1.DataSource = table;
            bindingNavigator1.BindingSource = bs1;
            Grid.Columns[0].Visible = false;
            Grid.Columns[2].Visible = false;
            Grid.Columns[1].HeaderText = "ФИО";
            Grid.AutoResizeColumns();
            view = table.DefaultView;
        }

        private void Grid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TeacherId = Convert.ToInt32(Grid.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (TeacherId != -1)
            {
                _service.Delete(TeacherId);
                Grid.Rows.Remove(Grid.SelectedRows[0]);
                Grid.Refresh();
            }
            else
            {
                MessageBox.Show("Поле не выбрано");
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            new Teacher("Добавить", CurrentUser).Show();
            this.Hide();
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectRow = Grid.CurrentCell.RowIndex;
            TeacherId = Convert.ToInt32(Grid.Rows[selectRow].Cells[0].Value.ToString());
            string name = Grid.Rows[selectRow].Cells[1].Value.ToString();
            new Teacher("Изменить", TeacherId, name, CurrentUser).Show();
            this.Hide();
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            ExcelHelper.SaveExcel(Grid, "Список преподавателей");
        }

        private void SearchField_TextChanged(object sender, EventArgs e)
        {
            Grid = Search.SearchInGrid(Grid, "Fio", SearchField.Text, view);
        }
    }
}
