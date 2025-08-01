using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] {
            new Evento {
                EventoId = 1,
                Local = "São Paulo",
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                Tema = "Angular 11 e .NET 5",
                QtdPessoas = 100,
                Lote = "Lote 1",
                ImagemURL = "Foto1.png"
            },
            new Evento {
                EventoId = 2,
                Local = "Salvador-BA",
                DataEvento = DateTime.Now.AddDays(3).ToString(),
                Tema = "Angular e suas novidades",
                QtdPessoas = 300,
                Lote = "Lote 2",
                ImagemURL = "Foto2.png"
            }
        };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetByID(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}
