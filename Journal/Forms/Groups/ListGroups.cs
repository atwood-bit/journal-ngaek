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

namespace Journal.Forms.Groups
{
    public partial class ListGroups : Form
    {
        private readonly CurrentUser User;
        private readonly GroupsService _service;
        private int GroupId = -1;
        DataView view = new DataView();

        public ListGroups(CurrentUser user)
        {
            InitializeComponent();
            User = user;
            _service = new GroupsService();
        }

        private void ListGroups_Load(object sender, EventArgs e)
        {
            if (User.Role == "Преподаватель" || User.Role == "Админ")
            {
                bindingNavigatorAddNewItem.Visible = true;
                bindingNavigatorDeleteItem.Visible = true;
            }
            BindingSource bs1 = new BindingSource();
            var table = _service.GetAllGroups();
            Grid.DataSource = table;
            bs1.DataSource = table;
            bindingNavigator1.BindingSource = bs1;
            Grid.Columns[0].Visible = false;
            Grid.Columns[1].HeaderText = "Группа";
            Grid.Columns[2].HeaderText = "Специальность";
            Grid.AutoResizeColumns();
            view = table.DefaultView;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            new Group(User, "Добавить").Show();
            this.Hide();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (GroupId != -1)
            {
                _service.Delete(GroupId);
                Grid.Rows.Remove(Grid.SelectedRows[0]);
                Grid.Refresh();
                GroupId = -1;
            }
            else
            {
                MessageBox.Show("Поле не выбрано");
            }
        }

        private void Grid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GroupId = Convert.ToInt32(Grid.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Models.Groups group = new Models.Groups();
            int selectRow = Grid.CurrentCell.RowIndex;
            group.Id = Convert.ToInt32(Grid.Rows[selectRow].Cells[0].Value.ToString());
            group.Name = Grid.Rows[selectRow].Cells[1].Value.ToString();
            group.Specialty = Grid.Rows[selectRow].Cells[2].Value.ToString();
            new Group(User, "Изменить", group).Show();
            this.Hide();
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            ExcelHelper.SaveExcel(Grid, "Список групп");
        }

        private void SearchField_TextChanged(object sender, EventArgs e)
        {
            Grid = Search.SearchInGrid(Grid, "Name", SearchField.Text, view);
            Grid = Search.SearchInGrid(Grid, "", SearchField.Text, view);
        }
    }
}
