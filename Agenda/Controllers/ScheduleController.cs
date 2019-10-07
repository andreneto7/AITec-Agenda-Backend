using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Agenda.Models;
using Agenda.Models.Services;
using Microsoft.AspNetCore.Authorization;

namespace Agenda.Controllers
{
    [Authorize]
    [Route("api/v1/schedule")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {

        private readonly ISchenduleService _schenduleService;

        public ScheduleController(ISchenduleService schenduleService)
        {
            _schenduleService = schenduleService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Schedule>>> GetSchedules()
        {
            return await _schenduleService.ListAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Schedule>> Get(long id)
        {
            return await _schenduleService.GetOne(id);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Schedule>> Put([FromBody] Schedule schedule)
        {
            return await _schenduleService.Put(schedule);
        }


        [HttpPost("{id}/event")]
        public async Task<ActionResult<Event>> PostScheduleEvent([FromBody] Event schedule)
        {
            return CreatedAtAction("GetSchedule", new { id = schedule.Id }, schedule);
        }

        [HttpPost]
        public async Task<ActionResult<Schedule>> Post([FromBody] Schedule schedule)
        {
            return await _schenduleService.Post(schedule);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Schedule>> DeleteSchedule(long id)
        {
            return await _schenduleService.Delete(id);
        }
    }
}
