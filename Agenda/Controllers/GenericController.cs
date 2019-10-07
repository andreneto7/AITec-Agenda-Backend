using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Controllers
{
    public abstract class GenericController<T> : ControllerBase
    {
        [HttpGet]
        public abstract Task<ActionResult<IEnumerable<T>>> GetAll();

        [HttpGet("{id}")]
        public abstract Task<ActionResult<T>> Get(long id);

        [HttpPost]
        public abstract Task<ActionResult<T>> Post(T entity);

        [HttpPut("{id}")]
        public abstract Task<ActionResult<T>> Put(T entity);

    }
}
