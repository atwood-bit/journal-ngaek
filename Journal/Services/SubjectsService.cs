using Journal.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal.Services
{
    class SubjectsService : Database
    {
        public void Create(Subjects sub)
        {
            string query = "INSERT INTO `subjects` (`Name`) " +
                    $"VALUES ('{sub.Name}')";

            ExecuteSqlCommand(query);
        }

        public DataTable GetAllSubjects()
        {
            string query = $"SELECT * FROM `subjects`";

            return SelectCommand(query);
        }

        public DataTable GetSubject(int id)
        {
            string query = $"SELECT * FROM `subjects` WHERE `Id` = '{id}'";

            return SelectCommand(query);
        }

        public void Delete(int id)
        {
            string query = $"DELETE FROM `subjects` WHERE `Id` = '{id}'";

            ExecuteSqlCommand(query);
        }

        public void DeleteFromListTeacher(int id)
        {
            string query = $"DELETE FROM `teachersubject` WHERE `Id` = '{id}'";

            ExecuteSqlCommand(query);
        }

        public void Update(Subjects sub)
        {
            string query = $"UPDATE `subjects` SET `Name` = '{sub.Name}' WHERE `Id` = {sub.Id}";

            ExecuteSqlCommand(query);
        }

        public DataTable GetAllAndTeacher()
        {
            string query = "SELECT * FROM `subjects` " +
                            "left join teachersubject " +
                            "on subjects.Id = teachersubject.SubjectId " +
                            "left join teachers " +
                            "on teachers.Id = teachersubject.TeacherId";

            return SelectCommand(query);
        }

        public void CreateSubjectAndInsertList(Subjects sub)
        {
            Create(sub);
            InsertList(sub);
        }

        public void InsertList(Subjects sub)
        {
            string query = "INSERT INTO `teachersubject` (`SubjectId`, `TeacherId`) " +
                    $"VALUES ('{sub.Id}', '{sub.TeacherId}')";

            ExecuteSqlCommand(query);
        }

        public void UpdateList(Subjects sub, int id)
        {
            string query = $"UPDATE `teachersubject` SET `SubjectId` = '{sub.Id}', `TeacherId` = '{sub.TeacherId}' " +
                            $"WHERE `id` = {id}";

            ExecuteSqlCommand(query);
        }

        public List<string> GetListSubject()
        {
            string query = "SELECT ShortName from `subjects` order by Id";

            return GetListTable(query);
        }

        public List<string> GetIdSubjects()
        {
            string query = "SELECT Id from `subjects` order by Id";

            return GetListTable(query);
        }
    }
}
