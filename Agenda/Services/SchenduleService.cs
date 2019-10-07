using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Agenda.Models;
using Agenda.Models.Repository;
using Agenda.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Services
{
    public class SchenduleService : ISchenduleService
    {
        private readonly ISchenduleRepository _schenduleRepository;

        public SchenduleService(ISchenduleRepository schenduleRepository)
        {
            _schenduleRepository = schenduleRepository;
        }

        public async Task<ActionResult> Delete(long id)
        {
            await _schenduleRepository.Delete(id);
            return null;
        }

        public Task<ActionResult<Schedule>> GetOne(long id)
        {
            return _schenduleRepository.GetOne(id);
        }

        public Task<ActionResult<IEnumerable<Schedule>>> ListAll()
        {
            return _schenduleRepository.ListAll();
        }

        public async Task<ActionResult> Post(Schedule entity)
        {
            await _schenduleRepository.Post(entity);
            return null;
        }

        public async Task<ActionResult> Put(Schedule entity)
        {
            await _schenduleRepository.Put(entity);
            return null;
        }
    }
}
