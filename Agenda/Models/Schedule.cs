using System;
using System.Collections.Generic;

namespace Agenda.Models
{
    public class Schedule
    {
        public long Id { get; set; }
        public String Name { get; set; }

        public IList<SchenduleEvent> StudentCourses { get; set; }
    }
}
