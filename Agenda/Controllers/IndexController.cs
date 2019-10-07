using System;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Controllers
{
    [ApiController]
    [Route("/")]
    public class IndexController : ControllerBase
    {
        [HttpGet]
        public String index()
        {
            return "Servico de gerenciamento de eventos.";
        }

    }
}
