using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models
{
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentId { get; set; }
        public List<string> Courses { get; set; }

    }
}
