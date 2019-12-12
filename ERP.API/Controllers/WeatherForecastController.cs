using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP.API.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ERP.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        // localhost:5000/api/weatherforecast
        [HttpGet]
        public ActionResult<IEnumerable<Evento>> Get()
        {
            return new Evento[] {
                new Evento() {
                    EventoId = 1,
                    Tema = "Angular 1",
                    Local = "Belo Horizonte",
                    Lote = "1º Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                },
                new Evento() {
                    EventoId = 2,
                    Tema = "Angular 3",
                    Local = "Rio de Janeiro",
                    Lote = "1º Lote",
                    QtdPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
                },
            };
        }
        
        // localhost:5000/api/weatherforecast/2
        [HttpGet("{id}")]
        public ActionResult<Evento> GetAction(int id)
        {
            return new Evento[] {
                new Evento() {
                    EventoId = 1,
                    Tema = "Angular 1",
                    Local = "Belo Horizonte",
                    Lote = "1º Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                },
                new Evento() {
                    EventoId = 2,
                    Tema = "Angular 3",
                    Local = "Rio de Janeiro",
                    Lote = "1º Lote",
                    QtdPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
                },
            }.FirstOrDefault(x => x.EventoId == id);
        }
    }
}
