using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Models.Repository
{
    public interface IEventRepository: IBaseRepository<Event>
    {
    
    }
}
