using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_React.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ASP_React.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        //private readonly ITaskRepository _taskRepository;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            //_taskRepository = taskRepository;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }


        //public IEnumerable<Models.Task> GetTasks()
        //{
        //    return _taskRepository.AllTasks;
        //}
    }
}
