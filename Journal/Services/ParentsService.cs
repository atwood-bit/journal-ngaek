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
    class ParentsService : Database
    {
        public void Create(CurrentUser user)
        {
            string query = "INSERT INTO `parents` (`Name`, `StudentId`, `UserId`) " +
                    $"VALUES ('{user.Name}', '{user.StudentId}', '{user.Id}') ";

            ExecuteSqlCommand(query);
        }

        public DataTable GetAllParents()
        {
            string query = $"SELECT * FROM `parents`";

            return SelectCommand(query);
        }

        public DataTable GetParent(int id)
        {
            string query = $"SELECT * FROM `parents` WHERE `Id` = '{id}'";

            return SelectCommand(query);
        }

        public void Delete(int id)
        {
            string query = $"DELETE FROM `parents` WHERE `Id` = '{id}'";

            ExecuteSqlCommand(query);
        }

        public void Update(string name, int studentId, int id)
        {
            string query = $"UPDATE `parents` SET `Name` = '{name}', `StudentId` = '{studentId}' WHERE `Id` = {id}";

            ExecuteSqlCommand(query);
        }
    }
}
