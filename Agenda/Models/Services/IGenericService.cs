using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Models.Services
{
    public interface IGenericService<T>
    {
        Task<ActionResult<IEnumerable<T>>> ListAll();
        Task<ActionResult<T>> GetOne(long id);
        Task<ActionResult> Put(T entity);
        Task<ActionResult> Post(T entity);
        Task<ActionResult> Delete(long id);
    }
}
