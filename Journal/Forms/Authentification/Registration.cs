using Journal.Models;
using Journal.Services;
using System;
using System.Windows.Forms;

namespace Journal.Forms
{
    public partial class Registration : Form
    {
        private CurrentUser User;
        private readonly GroupsService _serviceGroups;
        private readonly StudentsService _serviceStudents;

        public Registration(CurrentUser user)
        {
            InitializeComponent();
            User = user;
            _serviceGroups = new GroupsService();
            _serviceStudents = new StudentsService();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            Role.SelectedIndex = 0;
            SelectBox.DataSource = _serviceGroups.GetAllGroups();
            SelectBox.DisplayMember = "Name";
            SelectBox.ValueMember = "Id";
            SelectBox.SelectedIndex = -1;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            new Authorization(User).Show();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(NameUser.Text))
            {
                MessageBox.Show("Введите имя");
            }
            else if (String.IsNullOrWhiteSpace(Login.Text))
            {
                MessageBox.Show("Введите логин");
            }
            else if (String.IsNullOrWhiteSpace(Password.Text))
            {
                MessageBox.Show("Введите пароль");
            }
            else if (String.IsNullOrWhiteSpace(Password.Text) && (Password.Text.Length < 6 || Password.Text.Length > 16))
            {
                MessageBox.Show("Длина пароля должна быть от 6 до 16 символов");
            }
            else if (Role.Text == "Родитель" && (SelectBox.SelectedIndex == -1 || SelectStudents.SelectedIndex == -1))
            {
                MessageBox.Show("Заполните данные");
            }
            else if (Role.Text == "Учащийся" && SelectBox.SelectedIndex == -1)
            {
                MessageBox.Show("Заполните данные");
            }
            else if (Role.Text == "Преподаватель" && String.IsNullOrWhiteSpace(TeacherPass.Text))
            {
                MessageBox.Show("Заполните данные");
            }
            else
            {
                try
                {
                    User.Name = NameUser.Text;
                    User.Role = Role.Text;
                    User.Login = Login.Text;
                    User.Password = Password.Text;
                    if (Role.Text == "Учащийся")
                    {
                        User.GroupId = Convert.ToInt32(SelectBox.SelectedValue);
                    }
                    if (Role.Text == "Родитель")
                    {
                        User.StudentId = Convert.ToInt32(SelectStudents.SelectedValue);
                    }
                    if (Role.Text == "Преподаватель")
                    {
                        if (TeacherPass.Text == "teacherNGAEK")
                        {
                            User.TeachPass = TeacherPass.Text;
                        }
                        else
                        {
                            throw new Exception("Пароль неверный");
                        }
                    }
                    new UsersService().Register(User);
                    MessageBox.Show("Вы зарегистрировались");
                    this.Hide();
                    new Authorization().Show();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Попробуйте еще раз\n\n{ex.Message}", "Ошибка регистрации");
                }
            }
        }

        private void Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Role.Text == "Учащийся")
            {
                CustomLabel.Text = "Номер группы";
                SelectBox.Visible = true;
                StudentsName.Visible = false;
                SelectStudents.Visible = false;
            }
            else if (Role.Text == "Родитель")
            {
                CustomLabel.Text = "Выберите группу:";
                SelectBox.Visible = true;
                
            }
            else if (Role.Text == "Преподаватель")
            {
                SelectBox.Visible = false;
                StudentsName.Visible = false;
                SelectStudents.Visible = false;
                CustomLabel.Text = "Пароль преподавателя";
            }
        }

        private void SelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Role.Text == "Родитель")
            {
                StudentsName.Visible = true;
                SelectStudents.DataSource = _serviceStudents.GetStudentsGroup(Convert.ToInt32(SelectBox.SelectedValue));
                SelectStudents.DisplayMember = "Name";
                SelectStudents.ValueMember = "Id";
                SelectStudents.SelectedIndex = -1;
                SelectStudents.Visible = true;
            }
        }
    }
}
