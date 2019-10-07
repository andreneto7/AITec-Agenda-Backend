using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Models.Repository
{
    public interface IBaseRepository<T>
    {
        Task<ActionResult<IEnumerable<T>>> ListAll();
        Task<ActionResult<T>> GetOne(long id);
        Task Put(T entity);
        Task Post(T entity);
        Task Delete(long id);
    }
}
