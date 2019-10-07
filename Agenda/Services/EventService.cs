using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Agenda.Models;
using Agenda.Models.Repository;
using Agenda.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Services
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;

        public EventService(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public async Task<ActionResult> Delete(long id)
        {
            await _eventRepository.Delete(id);
            return null;
        }

        public Task<ActionResult<Event>> GetOne(long id)
        {
            return _eventRepository.GetOne(id);
        }

        public Task<ActionResult<IEnumerable<Event>>> ListAll()
        {
            return _eventRepository.ListAll();
        }

        public async Task<ActionResult> Post(Event entity)
        {
            await _eventRepository.Post(entity);
            return null;
        }

        public async Task<ActionResult> Put(Event entity)
        {
            await _eventRepository.Put(entity);
            return null;
        }
    }
}
