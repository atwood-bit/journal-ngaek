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
    public class GroupsService : Database
    {
        public DataTable GetAllGroups()
        {
            string query = $"SELECT * FROM `groups` order by groups.Name";

            return SelectCommand(query);
        }

        public DataTable GetGroup(int id)
        {
            string query = $"SELECT * FROM `groups` WHERE `Id` = '{id}'";

            return SelectCommand(query);
        }

        public void AddGroup(Groups group)
        {
            string query = "INSERT INTO `groups` (`Name`, `Specialty`) " +
                    $"VALUES ('{group.Name}', '{group.Specialty}') ";

            ExecuteSqlCommand(query);
        }

        public void Delete(int id)
        {
            string query = $"DELETE FROM `groups` WHERE `Id` = '{id}'";

            ExecuteSqlCommand(query);
        }

        public void Update(Groups group)
        {
            string query = $"UPDATE `groups` SET `Name` = '{group.Name}', `Specialty` = '{group.Specialty}' " +
                            $"WHERE `Id` = {group.Id}";

            ExecuteSqlCommand(query);
        }

        public DataTable GetGroupInfo(int id_group)
        {
            string query = $"SELECT students.Id, students.Name, " + 
                            "(SELECT round(AVG(marks.Mark), 2) FROM marks " +
                            "WHERE marks.studentId = students.Id " +
                            $"AND marks.DateMark >= '{DateTime.Now.AddMonths(-3).ToString("yyyy-MM-dd")}' " +
                            $"AND marks.DateMark <= '{DateTime.Now.ToString("yyyy-MM-dd")}') " +
                            "FROM `students` " +
                            $"WHERE students.GroupId = '{id_group}'";

            return SelectCommand(query);
        }
    }
}
