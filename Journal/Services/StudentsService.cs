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
    public class StudentsService : Database
    {
        public DataTable GetStudentsGroup(int group_id)
        {
            string query = $"SELECT * FROM `students` WHERE `GroupId` = '{group_id}'";

            return SelectCommand(query);
        }

        public void Create(CurrentUser user)
        {
            string query = "INSERT INTO `students` (`Name`, `GroupId`) " +
                    $"VALUES ('{user.Name}', '{user.GroupId}')";

            ExecuteSqlCommand(query);
        }

        public void Create(string name, int groupId)
        {
            string query = "INSERT INTO `students` (`Name`, `GroupId`, `UserId`) " +
                    $"VALUES ('{name}', '{groupId}', '0')";

            ExecuteSqlCommand(query);
        }

        public DataTable GetAllStudents()
        {
            string query = $"SELECT * FROM `students`";

            return SelectCommand(query);
        }

        public DataTable GetStudent(int id)
        {
            string query = $"SELECT * FROM `students` WHERE `Id` = '{id}'";

            return SelectCommand(query);
        }

        public DataTable GetStudentsWithGroups()
        {
            string query = $"SELECT * FROM `students` " +
                        $"join groups on students.GroupId = groups.Id " +
                        $"order by groups.Name";

            return SelectCommand(query);
        }

        public void Delete(int id)
        {
            string query = $"DELETE FROM `students` WHERE `Id` = '{id}'";

            ExecuteSqlCommand(query);

            query = $"DELETE FROM `users` WHERE `ID` = '{id}'";

            ExecuteSqlCommand(query);
        }

        public void Update(string name, int groupId, int id)
        {
            string query = $"UPDATE `students` SET `Name` = '{name}', `GroupId` = '{groupId}' WHERE `Id` = {id}";

            ExecuteSqlCommand(query);
        }

        public DataTable GetAllMarksStudent(int id_student)
        {
            string query = "SELECT students.Id, students.Name, marks.Mark, marks.DateMark, subjects.Name  FROM groups " +
                            "join students " +
                            "ON students.GroupId = groups.Id " +
                            "RIGHT join marks " +
                            "on marks.studentId = students.Id " +
                            "JOIN subjects " +
                            "on marks.subjectId = subjects.Id " +
                            $"WHERE students.Id = '{id_student}'";

            return SelectCommand(query);
        }

        public DataTable GetPerfomanceStudent(int idStudent)
        {
            string query = $"select subjects.Name, " +
                $"(SELECT ROUND(AVG(marks.Mark),2) " +
                $"from marks " +
                $"WHERE marks.subjectId = subjects.Id " +
                $"AND marks.studentId = '{idStudent}') " +
                $"from subjects ";
                //$"left join marks " +
                //$"on marks.subjectId = subjects.Id " +
                //$"WHERE marks.studentId = '{idStudent}'";

            return SelectCommand(query);
        }

        public List<string> GetListStudents(int idGroup)
        {
            string query = $"select Name from `students` " +
                $"WHERE GroupId = '{idGroup}' " +
                $"order by Name";

            return GetListTable(query);
        }

        public List<string> GetIdStudents(int idGroup)
        {
            string query = $"select Id from `students` " +
                $"WHERE GroupId = '{idGroup}' " +
                $"order by Name";

            return GetListTable(query);
        }
    }
}
