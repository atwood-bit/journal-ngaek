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
    class TeachersService : Database
    {
        public void Create(CurrentUser user)
        {
            string query = "INSERT INTO `teachers` (`Fio`, `UserId`) " +
                    $"VALUES ('{user.Name}', '{user.Id}')";

            ExecuteSqlCommand(query);
        }

        public void Create(string name)
        {
            string query = "INSERT INTO `teachers` (`Fio`) " +
                    $"VALUES ('{name}')";

            ExecuteSqlCommand(query);
        }

        public DataTable GetAllTeachers()
        {
            string query = $"SELECT * FROM `teachers`";

            return SelectCommand(query);
        }

        public DataTable GetTeacher(int id)
        {
            string query = $"SELECT * FROM `teachers` WHERE `Id` = '{id}'";

            return SelectCommand(query);
        }

        public void Delete(int id)
        {
            string query = $"DELETE FROM `teachers` WHERE `Id` = '{id}'";

            ExecuteSqlCommand(query);
        }

        public void Update(string name, int id)
        {
            string query = $"UPDATE `teachers` SET `Fio` = '{name}' WHERE `Id` = {id}";

            ExecuteSqlCommand(query);
        }
    }
}
