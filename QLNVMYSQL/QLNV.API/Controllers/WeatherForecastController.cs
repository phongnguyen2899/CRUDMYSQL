using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySqlConnector;
using QLNV.DATA.DBContext;
using QLNV.DATA.Entiti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.API.Controllers
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger,DbContext context)
        {
            _logger = logger;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> getAllPostion()
        {
            List<Posittion> list = new List<Posittion>();

            using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;password=anhphong1;port=3306;database=qlnv;"))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM position", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Posittion()
                        {
                            Id = reader.GetInt32("Id"),
                            PositionName = reader.GetString("PosittionName")
                        });
                    }
                }
            }
            return Ok(list);
        }
    }
}
