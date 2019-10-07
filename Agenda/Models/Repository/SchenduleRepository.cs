using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Agenda.Persistence.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Models.Repository
{
    public class SchenduleRepository : BaseRepository<Schedule>, ISchenduleRepository
    {
        public SchenduleRepository(AppDBContext context) : base(context)
        {
        }

        public async Task Delete(long id)
        {
            var schendule = await _context.Schedules.FindAsync(id);
            if (schendule != null)
            {
                _context.Schedules.Remove(schendule);
            }
            await SaveAsync();
        }

        public async Task<ActionResult<Schedule>> GetOne(long id)
        {
            return await _context.Schedules.FindAsync(id);
        }

        public async Task<ActionResult<IEnumerable<Schedule>>> ListAll()
        {
            return null;
        }

        public async Task Post(Schedule entity)
        {
            _context.Schedules.Add(new Schedule { Name = entity.Name });
            await SaveAsync();
        }

        public async Task Put(Schedule entity)
        {
            _context.Schedules.Update(entity);
            await SaveAsync();
        }
    }
}
