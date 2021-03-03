using Journal.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal.Services
{
    class TimetableService : Database
    {
        public void Add(Timetable timetable)
        {
            string query = $"INSERT INTO `timetable` (`Date`, `GroupId`, `SubjectId`, `TeacherId`) " +
                    $"VALUES('{timetable.Date.ToString("yyyy-MM-dd")}', '{timetable.GroupId}', '{timetable.SubjectId}', '{timetable.TeacherId}')";

            ExecuteSqlCommand(query);
        }

        public void Update(Timetable timetable)
        {
            string query = $"UPDATE `timetable` SET `Date` = '{timetable.Date.ToString("yyyy-MM-dd")}', `GroupId` = '{timetable.GroupId}', " +
                $"`SubjectId` = '{timetable.SubjectId}', `TeacherId` = '{timetable.TeacherId}' " +
                            $"WHERE `id` = '{timetable.Id}'";

            ExecuteSqlCommand(query);
        }

        public void Delete(int id)
        {
            string query = $"DELETE FROM `timetable` WHERE `Id` = '{id}'";

            ExecuteSqlCommand(query);
        }

        public DataTable GetAll()
        {
            string query = "SELECT * FROM `timetable`";

            return SelectCommand(query);
        }

        public DataTable GetForDay(DateTime date)
        {
            string query = $"SELECT * FROM `timetable` WHERE `Date` = {date.ToString("yyyy-MM-dd")}";

            return SelectCommand(query);
        }

        public DataTable GetForPeriod(DateTime startDate, DateTime endDate)
        {
            string query = $"SELECT * FROM `timetable` WHERE `Date` >= {startDate.ToString("yyyy-MM-dd")} " +
                            $"AND `Date` <= {endDate.ToString("yyyy-MM-dd")}";

            return SelectCommand(query);
        }

        public ListView GetListSubjectGroup(DateTime date, int idGroup, ListView list)
        {
            string query = "SELECT timetable.Id, subjects.Name, teachers.Fio from groups " +
               "join timetable " +
               "on timetable.GroupId = groups.Id " +
               "join subjects " +
               "on timetable.SubjectId = subjects.Id " +
               "join teachers " +
               "on timetable.TeacherId = teachers.Id " +
               $"WHERE timetable.Date = '{date.ToString("yyyy-MM-dd")}' " +
               $"AND timetable.GroupId = '{idGroup}'";

            return ReadTable(query, list);
        }

        public DataTable GetTimetable(DateTime date)
        {
            string query = "SELECT * from groups " +
                "join timetable " +
                "on timetable.GroupId = groups.Id " +
                "join subjects " +
                "on timetable.SubjectId = subjects.Id " +
                "join teachers " +
                "on timetable.TeacherId = teachers.Id " +
                $"WHERE timetable.Date = '{date.ToString("yyyy-MM-dd")}' " +
                $"order by groups.Id";

            return SelectCommand(query);
        }

        public DataTable GetTimetable(DateTime date, int groupId)
        {
            string query = "SELECT * from groups " +
                "join timetable " +
                "on timetable.GroupId = groups.Id " +
                "join subjects " +
                "on timetable.SubjectId = subjects.Id " +
                "join teachers " +
                "on timetable.TeacherId = teachers.Id " +
                $"WHERE timetable.Date = '{date.ToString("yyyy-MM-dd")}' " +
                $"AND timetable.GroupId = '{groupId}'";

            return SelectCommand(query);
        }

        public DataTable GetTimetable(DateTime start, DateTime end, int groupId)
        {
            string query = "SELECT * from groups " +
                "join timetable " +
                "on timetable.GroupId = groups.Id " +
                "join subjects " +
                "on timetable.SubjectId = subjects.Id " +
                "join teachers " +
                "on timetable.TeacherId = teachers.Id " +
                $"WHERE timetable.Date >= '{start.ToString("yyyy-MM-dd")}' " +
                $"AND timetable.Date <= '{end.ToString("yyyy-MM-dd")}' " +
                $"AND timetable.GroupId = '{groupId}'";

            return SelectCommand(query);
        }

        public DataTable GetTimetable(DateTime start, DateTime end)
        {
            string query = "SELECT * from groups " +
                "join timetable " +
                "on timetable.GroupId = groups.Id " +
                "join subjects " +
                "on timetable.SubjectId = subjects.Id " +
                "join teachers " +
                "on timetable.TeacherId = teachers.Id " +
                $"WHERE timetable.Date >= '{start.ToString("yyyy-MM-dd")}' " +
                $"AND timetable.Date <= '{end.ToString("yyyy-MM-dd")}'";

            return SelectCommand(query);
        }
    }
}
