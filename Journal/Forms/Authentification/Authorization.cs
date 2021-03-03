using Journal.Forms;
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

namespace Journal
{
    public partial class Authorization : Form
    {
        public CurrentUser CurrentUser;
        private readonly UsersService _service;
        public Authorization()
        {
            InitializeComponent();
            CurrentUser = new CurrentUser();
            _service = new UsersService();
        }

        public Authorization(CurrentUser user)
        {
            InitializeComponent();
            CurrentUser = user;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            new Registration(CurrentUser).Show();
            this.Hide();
        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(LoginTxt.Text) && !String.IsNullOrWhiteSpace(PassTxt.Text))
            {
                CurrentUser.Login = LoginTxt.Text;
                CurrentUser.Password = PassTxt.Text;
                CurrentUser = _service.Authorize(CurrentUser);
                if (CurrentUser.IsAuthorized)
                {
                    this.Hide();
                    new MainWindow(CurrentUser).Show();
                }
                else
                {
                    MessageBox.Show("Ошибка входа\n\nНеверные данные", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Введите данные", "Ошибка");
            }
        }
    }
}
