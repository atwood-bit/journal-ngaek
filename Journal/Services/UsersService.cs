using Journal.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal.Services
{
    public class UsersService : Database
    {
        private readonly StudentsService _serviceStudents;
        private readonly ParentsService _serviceParents;
        private readonly TeachersService _serviceTeachers;

        public UsersService()
        {
            _serviceStudents = new StudentsService();
            _serviceParents = new ParentsService();
            _serviceTeachers = new TeachersService();
        }

        public void Register(CurrentUser user)
        {
            if (CheckUser(user.Login))
            {
                int role_id = 0;
                switch (user.Role)
                {
                    case "Учащийся":
                        role_id = 1;
                        break;
                    case "Преподаватель":
                        role_id = 3;
                        break;
                    case "Родитель":
                        role_id = 2;
                        break;
                }
                string query = "INSERT INTO `users` (`Login`, `Password`, `Role`) " +
                        $"VALUES ('{user.Login}', '{CryptService.HashPassword(user.Password)}', '{role_id}') ";
                user.Id = ExecuteSqlCommand(query);
                switch (role_id)
                {
                    case 1:
                        _serviceStudents.Create(user);
                        break;
                    case 2:
                        _serviceParents.Create(user);
                        break;
                    case 3:
                        _serviceTeachers.Create(user);
                        break;
                }
            }
            else
            {
                throw new Exception("Пользователь существует");
            }
        }

        public CurrentUser Authorize(CurrentUser user)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                string hashPass = string.Empty;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand($"SELECT users.Login, users.Password, roles.Role " +
                    $"FROM `users` " +
                    $"join roles on users.Role = roles.Id " +
                    $"WHERE `Login` = '{user.Login}'", conn);
                conn.Open();
                using (MySqlDataReader read = command.ExecuteReader())
                {
                    if (read.Read())
                    {
                        //if (read.IsDBNull(1))
                        //{
                        //    hashPass = string.Empty;
                        //    return false;
                        //}
                        hashPass = Convert.ToString(read.GetValue(1));
                        user.Role = Convert.ToString(read.GetValue(2));
                    }

                    read.Close();
                }
                conn.Close();
                if (!String.IsNullOrEmpty(hashPass))
                {
                    user.IsAuthorized = CryptService.VerifyHashedPassword(hashPass, user.Password);
                }

                return user;
            }
        }

        public DataTable GetAll()
        {
            string query = "SELECT * FROM `users` " +
                        "join roles " +
                        "on users.Role = roles.Id";

            return SelectCommand(query);
        }

        public void Delete(int id)
        {
            string query = $"DELETE FROM `users` WHERE ID = '{id}'";

            ExecuteSqlCommand(query);
        }

        public DataTable GetRoles()
        {
            string query = "SELECT * FROM `roles`";

            return SelectCommand(query);
        }

        public void Update(Models.User user)
        {
            string query = $"UPDATE `users` SET `Role` = '{user.Role}' WHERE ID = '{user.Id}'";

            ExecuteSqlCommand(query);
        }
    }
}
