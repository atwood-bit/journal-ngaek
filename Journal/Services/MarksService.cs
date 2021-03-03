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
    class MarksService : Database
    {
        public void Create(Marks mark)
        {
            string query = "INSERT INTO `marks` (`Mark`, `DateMark`, `studentId`, `subjectId`) " +
                    $"VALUES ('{mark.Mark}', '{mark.DateMark.ToString("yyyy-MM-dd")}', '{mark.StudentId}', '{mark.SubjectId}') ";

            ExecuteSqlCommand(query);
        }

        public DataTable GetAllMarks()
        {
            string query = $"SELECT * FROM `marks`";

            return SelectCommand(query);
        }

        public DataTable GetMark(int id)
        {
            string query = $"SELECT * FROM `marks` WHERE `Id` = '{id}'";

            return SelectCommand(query);
        }

        public void Delete(int id)
        {
            string query = $"DELETE FROM `marks` WHERE `Id` = '{id}'";

            ExecuteSqlCommand(query);
        }

        public void Update(Marks mark)
        {
            string query = $"UPDATE `marks` SET `Mark` = '{mark.Mark}', `DateMark` = '{mark.DateMark.ToString("yyyy-MM-dd")}', " +
                    $"`studentId` = '{mark.StudentId}', `subjectId` = '{mark.SubjectId}' WHERE `Id` = {mark.Id}";

            ExecuteSqlCommand(query);
        }

        public List<string> GetMarkStudent(int subjectId, int studentId)
        {
            string query = $"select round(AVG(marks.Mark), 2) " +
                $"from marks " +
                $"join students " +
                $"on students.Id = marks.studentId " +
                $"JOIN subjects " +
                $"on subjects.Id = marks.subjectId " +
                $"WHERE marks.studentId = '{studentId}' " +
                $"AND marks.subjectId = '{subjectId}'";

            return GetListTable(query);
        }

        public void AddMark(int studentId, int subjectId, int mark)
        {
            string query = $"INSERT INTO `marks` (`Mark`, `DateMark`, `studentId`, `subjectId`) " +
                        $"VALUES ('{mark}', '{DateTime.Now.ToString("yyyy-MM-dd")}', '{studentId}', '{subjectId}') ";

            ExecuteSqlCommand(query);
        }
    }
}
