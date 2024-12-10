using Microsoft.AspNetCore.Mvc;

namespace TestConAngular.Controllers
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login([FromBody] Auth auth)
        {
            var res = new
            {
                status = true,
                statusCode = 200,
                message = "Se ha autenticado correctamente.",
                data = new
                {
                    menuProfile = new[]
                    {
                        new { idMenuParent = 0, idMenu = 0, nameModule = "Inicio", upLevel = 2, idUser = 6035 },
                        new { idMenuParent = 0, idMenu = 1, nameModule = "Ventas", upLevel = 2, idUser = 6035 },
                        // Resto de elementos del menú
                    },
                    userLoginResponse = new
                    {
                        idUser = 6035,
                        userName = "multiposiva1@julian.com",
                        name1 = "Multiposiva",
                        name2 = "",
                        lastName1 = "1",
                        lastName2 = "",
                        fullName = "tiendañaña",
                        id_TypeDocument = 0,
                        documentNumber = "12311111111",
                        id_Country = 47,
                        id_State = 800,
                        id_City = 13358,
                        email = "",
                        phone = "3215465854",
                        altPhone = "",
                        state = true,
                        idProfile = 0,
                        userAddress = "",
                        userUrlPhoto = (string?)null,
                        id_Platform = "8000",
                        id_User = "6035",
                        id_UserPlatform = "6035",
                        creation_Date = "12/12/2023 00:00:00",
                        tacId = 16,
                        uLastIdPartnerSelected = (object?)null
                    },
                    userPartnerInformation = new {
                    
                        societiesMenuResponse = new[]
                        {
                            new
                            {
                                sId = 1,
                                sCode = "800001",
                                sName = "Sociedad Un Pos y Una Bodega",
                                routes = new[]
                                {
                                    new { idRoute = 1, routeName = "POS 1 - Bodega 1", sCode = (string?)null },
                                    new { idRoute = 7, routeName = "POS 7 - Bodega Unipos sin trydistri", sCode = (string?)null },
                                    new { idRoute = 17, routeName = "POS - 17", sCode = (string?)null }
                                }
                            },
                            new
                            {
                                sId = 16,
                                sCode = "8000010",
                                sName = "Sociedad UAT Unipos",
                                routes = new[]
                                {
                                    new { idRoute = 18, routeName = "TIENDA UAT", sCode = (string?)null }
                                }
                            }
                        }
                    },
                    jwtToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJPbmxpbmUgSldUIEJ1aWxkZXIiLCJpYXQiOjE3MzM3OTc5NTIsImV4cCI6MTc2NTMzMzk1MiwiYXVkIjoid3d3LmV4YW1wbGUuY29tIiwic3ViIjoianJvY2tldEBleGFtcGxlLmNvbSIsIkdpdmVuTmFtZSI6IkpvaG5ueSIsIlN1cm5hbWUiOiJSb2NrZXQiLCJFbWFpbCI6Impyb2NrZXRAZXhhbXBsZS5jb20iLCJSb2xlIjpbIk1hbmFnZXIiLCJQcm9qZWN0IEFkbWluaXN0cmF0b3IiXX0.VgloYJTRzPY60hn3wfAjd9qfbjJriTzVzv3_vD1fMe0"
                },
                count = 0
            };

            if (true)
            {
                return Ok(res);
            }

            return BadRequest();
        }


        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
