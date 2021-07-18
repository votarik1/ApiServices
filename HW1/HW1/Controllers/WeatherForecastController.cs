using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW1.Controllers
{
    [ApiController]
    [Route("WeatherForecast")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly WeatherForecast _holder;

        public WeatherForecastController(WeatherForecast holder)
        {
            _holder = holder;
        }

        [HttpPost("create")]
        public IActionResult Create(int t)
        {
            _holder.AddNewNote(t);
            return Ok();
        }

        [HttpGet ("read")]
        public IActionResult Read(DateTime from , DateTime till)
        {
            return Ok(_holder.ReadNotes(from, till));           
        }

        [HttpPut("update")]
        public IActionResult Update(DateTime date, int t)
        {
            _holder.UpdateNote(date, t);
            return Ok();
        }

        [HttpDelete("delete")]
        public IActionResult Delete(DateTime date)
        {
            _holder.Delete(date);
            return Ok();
        }
    }
}
