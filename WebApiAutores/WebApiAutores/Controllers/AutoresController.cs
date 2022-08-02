using System;
using Microsoft.AspNetCore.Mvc;
using WebApiAutores.Entities;

namespace WebApiAutores.Controllers
{
    [ApiController]
    [Route("api/autores")]
    public class AutoresController: ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Autor>> Get()
        {
            return new List<Autor>() {
                new Autor() { Id = 1, Nombre = "Andres" },
                new Autor() { Id = 2, Nombre = "Juan" }
            };
        }
    }
}

