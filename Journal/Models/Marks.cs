using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal.Models
{
    public class Marks
    {
        public int Id { get; set; }
        public int Mark { get; set; }
        public DateTime DateMark { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
    }
}
