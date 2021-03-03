using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal.Models
{
    public class CurrentUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int GroupId { get; set; } = 0;
        public int StudentId { get; set; } = 0;
        public string TeachPass { get; set; }
        public bool IsAuthorized { get; set; } = false;
    }
}
