using System;
namespace Agenda.Models
{
    public class SchenduleEvent
    {
        public int ScheduleId { get; set; }
        public Schedule schendule { get; set; }

        public int EventId { get; set; }
        public Event eventt { get; set; }
    }
}
