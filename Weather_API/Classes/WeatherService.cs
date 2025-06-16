using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using static Weather_API.Classes.UtilityClass;

namespace Weather_API.Classes
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;

        //Chave da API para realizar as consultas
        private readonly string _apiKey = "99bf862319174eec868163908251406";

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetWeatherAsync(string city)
        {
            //GET na API oficial "WeatherAPI" de uma cidade, aguardar e retornar o JSON como string
            try
            {
                string url = $"http://api.weatherapi.com/v1/current.json?key={_apiKey}&q={Uri.EscapeDataString(city)}&lang=pt";

                HttpResponseMessage response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return jsonResponse;
                }
                else
                {
                    return $"Erro ao consultar o clima: {response.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                CriarLog($"Erro ao consultar GetWeatherAsync: {ex.Message}");
                return $"Erro ao consultar o clima: {ex.Message}";
            }
        }

        public async Task<string> GetWeatherAsync5Days(string city)
        {
            //GET na API oficial "WeatherAPI" de uma cidade para 5 dias, aguardar e retornar o JSON como string
            try
            {
                string url = $"http://api.weatherapi.com/v1/forecast.json?key={_apiKey}&q={Uri.EscapeDataString(city)}&days=5&lang=pt";

                HttpResponseMessage response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return jsonResponse;
                }
                else
                {
                    return $"Erro ao consultar o clima: {response.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                CriarLog($"Erro ao consultar GetWeatherAsync5Days: {ex.Message}");
                return $"Erro ao consultar o clima 5 dias: {ex.Message}";
            }
        }

        public async Task<int> FavoritarCidade(string city)
        {
            //Função para Inserir no banco de dados uma cidade favorita, inserindo IDUsuario e NomeCidade (IDUsuario 0 pois não foi criado painel de usuários)
            try
            {
                int alterado = await ExecuteAsync($"Insert into CidadesFavoritas values (@cidade, @id)", new { cidade = city, id = 0 });

                return alterado;
            }
            catch (Exception ex)
            {
                CriarLog($"Erro ao Favoritar cidade: {ex.Message}");
                return 0;
            }
        }

        public async Task<int> RemoverFavoritoCidade(string city)
        {
            //Função para Remover do banco de dados uma cidade favorita, inserindo IDUsuario e NomeCidade (IDUsuario 0 pois não foi criado painel de usuários)
            try
            {
                int alterado = await ExecuteAsync($"Delete from CidadesFavoritas WHERE NomeCidade = @cidade and IDUsuario = @id", new { cidade = city, id = 0 });

                return alterado;
            }
            catch (Exception ex)
            {
                CriarLog($"Erro ao Remover cidade dos favoritos: {ex.Message}");
                return 0;
            }
        }

        public async Task<List<string>> ListarCidadesFavoritas(string IDUsuario)
        {
            //Função para listar cidades marcadas como favoritas (passando o IDUsuario)
            try
            {
                List<string> list = new List<string>();
                var Favoritos = await GetAsync<Favoritas>($"select NomeCidade from CidadesFavoritas where IDUsuario = @id", new { id = IDUsuario });

                foreach (var fav in Favoritos)
                {
                    list.Add(fav.NomeCidade);
                }

                return list;
            }
            catch (Exception ex)
            {
                CriarLog($"Erro ao listar cidades favoritas: {ex.Message}");
                return null;
            }
        }
    }
}
