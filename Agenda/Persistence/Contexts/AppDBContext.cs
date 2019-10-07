using System;
using Agenda.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Persistence.Contexts
{
    public class AppDBContext : IdentityDbContext
    {
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Event> Events { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=tcp:andredbserver.database.windows.net,1433;Initial Catalog=agenda_db;Persist Security Info=False;User ID=andreneto;Password=aL58070102&77;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;", providerOptions => providerOptions.CommandTimeout(60))
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Schedule>().ToTable("Schedule");
            builder.Entity<Schedule>().HasKey(p => p.Id);
            builder.Entity<Schedule>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Schedule>().Property(p => p.Name).IsRequired().HasMaxLength(30);

            builder.Entity<Schedule>().HasData
            (
                new Schedule { Id = 1, Name = "Agenda principal" } // Id set manually due to in-memory provider
            );

            builder.Entity<Event>().ToTable("Event");
            builder.Entity<Event>().HasKey(p => p.Id);
            builder.Entity<Event>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Event>().Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Entity<Event>().Property(p => p.Date).IsRequired();
            builder.Entity<Event>().Property(p => p.Local).IsRequired();
            builder.Entity<Event>().Property(p => p.Type).IsRequired();

            builder.Entity<SchenduleEvent>().HasKey(sc => new { sc.ScheduleId, sc.EventId});
        }
    }
}
