using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal.Models
{
    class Timetable
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int GroupId { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }
    }
}
