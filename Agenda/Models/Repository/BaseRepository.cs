using System;
using System.Linq;
using System.Threading.Tasks;
using Agenda.Persistence.Contexts;

namespace Agenda.Models
{
    public abstract class BaseRepository<T>
    {
        protected readonly AppDBContext _context;
        public BaseRepository(AppDBContext context)
        {
            _context = context;
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
