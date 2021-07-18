using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW1
{
    public class Note
    {
        public DateTime Date { get; set; }
        public int Temperature { get; set; }
        public Note(DateTime date, int t)
        {
            Temperature = t;
            Date = date;
        }
    }
}
