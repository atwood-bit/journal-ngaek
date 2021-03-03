using Journal.Forms.Groups;
using Journal.Forms.Students;
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

namespace Journal.Forms
{
    public partial class GroupInfo : Form
    {
        private readonly int GroupId;
        private readonly GroupsService _serviceGroup;
        private readonly StudentsService _serviceStudent;
        private readonly MarksService _serviceMarks;
        private int StudentId = -1;
        private readonly CurrentUser CurrentUser;
        DataView view = new DataView();

        public GroupInfo(int groupd_id, CurrentUser user)
        {
            InitializeComponent();
            GroupId = groupd_id;
            _serviceGroup = new GroupsService();
            _serviceStudent = new StudentsService();
            _serviceMarks = new MarksService();
            CurrentUser = user;
        }

        private void GroupInfo_Load(object sender, EventArgs e)
        {
            if (CurrentUser.Role == "Преподаватель" || CurrentUser.Role == "Админ")
            {
                bindingNavigatorAddNewItem.Visible = true;
                bindingNavigatorDeleteItem.Visible = true;
            }
            UpdateGrid();
        }

        private void GroupInfoGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            StudentId = Convert.ToInt32(GroupInfoGrid.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (StudentId != -1)
            {
                _serviceStudent.Delete(StudentId);
                GroupInfoGrid.Rows.Remove(GroupInfoGrid.SelectedRows[0]);
                GroupInfoGrid.Refresh();
            }
            else
            {
                MessageBox.Show("Поле не выбрано");
            }
        }

        private void GroupInfoGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectRow = GroupInfoGrid.CurrentCell.RowIndex;
            StudentId = Convert.ToInt32(GroupInfoGrid.Rows[selectRow].Cells[0].Value.ToString());
            string nameStudent = GroupInfoGrid.Rows[selectRow].Cells[1].Value.ToString();
            new Student(GroupId, StudentId, "Изменить", CurrentUser, nameStudent).Show();
            this.Hide();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            new Student(GroupId, "Добавить", CurrentUser).Show();
            this.Hide();
        }

        public void UpdateGrid()
        {
            BindingSource bs1 = new BindingSource();
            var table = _serviceGroup.GetGroupInfo(GroupId);
            GroupInfoGrid.DataSource = table;
            bs1.DataSource = table;
            bindingNavigator1.BindingSource = bs1;
            GroupInfoGrid.Columns[0].Visible = false;
            GroupInfoGrid.Columns[1].HeaderText = "Учащийся";
            GroupInfoGrid.Columns[2].HeaderText = "Ср. балл за 3 месяца";
            GroupInfoGrid.AutoResizeColumns();
            view = table.DefaultView;
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            ExcelHelper.SaveExcel(GroupInfoGrid, $"Информация о группе");
        }

        private void SearchField_TextChanged(object sender, EventArgs e)
        {
            GroupInfoGrid = Search.SearchInGrid(GroupInfoGrid, "Name", SearchField.Text, view);
        }
    }
}
