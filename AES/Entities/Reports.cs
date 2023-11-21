using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES.Entities
{
    class Reports
    {
        public int IdReport { get; set; }
        public string FirstName { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan ArriveTime { get; set; }
        public TimeSpan DepartureTime { get; set; }

    }
}
