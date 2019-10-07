using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agenda.Models
{
    public class Event
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public String Local { get; set; }
        public int Type { get; set; }
        public IList<SchenduleEvent> StudentCourses { get; set; }
    }

}
