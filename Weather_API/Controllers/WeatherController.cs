using Microsoft.AspNetCore.Mvc;
using Weather_API.Classes;

namespace Weather_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly WeatherService _weatherService;

        public WeatherController(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet("Cidade/{city}")] //API GET para Retornar resultado de uma cidade no horário atual
        public async Task<IActionResult> GetWeather(string city)
        {
            var result = await _weatherService.GetWeatherAsync(city);
            return Ok(result);
        }

        [HttpGet("CidadeWeek/{city}")] //API GET para Retornar resultado de uma cidade para 5 dias
        public async Task<IActionResult> GetWeather5Days(string city)
        {
            var result = await _weatherService.GetWeatherAsync5Days(city);
            return Ok(result);
        }

        [HttpGet("Favoritos/{IDUser}")] //API GET para Retornar uma lista de string das cidades favoritas de um Usuario
        public async Task<IActionResult> ListFavourites(string IDUser)
        {
            var result = await _weatherService.ListarCidadesFavoritas(IDUser);
            return Ok(result);
        }

        [HttpGet("Favoritar/{NMCidade}")] //API GET para favoritar uma cidade
        public async Task<IActionResult> FavoritarCidade(string NMCidade)
        {
            var result = await _weatherService.FavoritarCidade(NMCidade);
            return Ok(result);
        }

        [HttpGet("RemFavoritos/{NMCidade}")] //API GET para remover uma cidade dos favoritos
        public async Task<IActionResult> RemFavoritosCidade(string NMCidade)
        {
            var result = await _weatherService.RemoverFavoritoCidade(NMCidade);
            return Ok(result);
        }
    }
}
