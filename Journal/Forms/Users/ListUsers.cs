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

namespace Journal.Forms.Users
{
    public partial class ListUsers : Form
    {
        private readonly CurrentUser User;
        private readonly UsersService _service;
        DataView view = new DataView();

        public ListUsers(CurrentUser user)
        {
            InitializeComponent();
            User = user;
            _service = new UsersService();
        }

        private void ListUsers_Load(object sender, EventArgs e)
        {
            BindingSource bs1 = new BindingSource();
            var table = _service.GetAll();
            Grid.DataSource = table;
            bs1.DataSource = table;
            bindingNavigator1.BindingSource = bs1;
            Grid.Columns[0].Visible = false;
            Grid.Columns[2].Visible = false;
            Grid.Columns[3].Visible = false;
            Grid.Columns[4].Visible = false;
            Grid.Columns[1].HeaderText = "Логин";
            Grid.Columns[5].HeaderText = "Роль";
            Grid.AutoResizeColumns();
            view = table.DefaultView;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Grid.Rows[Grid.CurrentCell.RowIndex].Cells[0].Value.ToString());

            _service.Delete(id);
            Grid.Rows.Remove(Grid.SelectedRows[0]);
            Grid.Refresh();
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Models.User user = new Models.User();
            user.Id = Convert.ToInt32(Grid.Rows[Grid.CurrentCell.RowIndex].Cells[0].Value.ToString());
            user.Login = Convert.ToString(Grid.Rows[Grid.CurrentCell.RowIndex].Cells[1].Value.ToString());
            user.Role = Convert.ToInt32(Grid.Rows[Grid.CurrentCell.RowIndex].Cells[3].Value.ToString());
            new User(User, user).Show();
            this.Hide();
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            ExcelHelper.SaveExcel(Grid, "Список пользователей");
        }

        private void SearchField_TextChanged(object sender, EventArgs e)
        {
            Grid = Search.SearchInGrid(Grid, "Login", SearchField.Text, view);
        }
    }
}
