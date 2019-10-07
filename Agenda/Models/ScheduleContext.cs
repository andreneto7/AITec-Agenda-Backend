using System;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Models
{
    public class ScheduleContext: DbContext
    {
        public ScheduleContext(DbContextOptions<ScheduleContext> options) : base(options)
        {

        }

        public DbSet<Schedule> Schedules { get; set; }
    }
}
