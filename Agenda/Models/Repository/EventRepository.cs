using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Agenda.Persistence.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Models.Repository
{
    public class EventRepository : BaseRepository<Event>, IEventRepository
    {
        public EventRepository(AppDBContext context) : base(context)
        {
        }

        public async Task Delete(long id)
        {
            var eventt = await _context.Events.FindAsync(id);
            if (eventt != null)
            {
                _context.Events.Remove(eventt);
            }
            await SaveAsync();
        }

        public async Task<ActionResult<Event>> GetOne(long id)
        {
            return await _context.Events.FindAsync(id);
        }

        public Task<ActionResult<IEnumerable<Event>>> ListAll()
        {
            throw new NotImplementedException();
        }

        public async Task Post(Event entity)
        {
            _context.Events.Add(new Event { Name = entity.Name, Date = entity.Date, Local = entity.Local, Type = entity.Type });
            await SaveAsync();
        }

        public async Task Put(Event entity)
        {
            _context.Events.Update(entity);
            await SaveAsync();
        }
    }
}
