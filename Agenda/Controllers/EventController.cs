using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Agenda.Models;
using Agenda.Models.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Controllers
{
    [Authorize]
    [Route("api/v1/event")]
    [ApiController]
    public class EventController : GenericController<Event>
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public override async Task<ActionResult<Event>> Get(long id)
        {
            return await _eventService.GetOne(id);
        }

        public override async Task<ActionResult<IEnumerable<Event>>> GetAll()
        {
            return await _eventService.ListAll();
        }

        public override async Task<ActionResult<Event>> Post([FromBody] Event entity)
        {
            return await _eventService.Post(entity);
        }

        public override async Task<ActionResult<Event>> Put([FromBody] Event entity)
        {
            return await _eventService.Put(entity);
        }
    }
}
