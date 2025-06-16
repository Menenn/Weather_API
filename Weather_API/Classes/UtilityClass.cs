using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System.Data;
using Dapper;
using System.Net;
using System.Text.Json.Serialization;

namespace Weather_API.Classes
{
    public static class UtilityClass
    {
        //String de conexão do banco de dados (apenas conexão local)
        static string SQLConn = "Data Source=192.168.100.118; Initial Catalog=Weather; User Id=Weather; Password=QualitWeather@123; TrustServerCertificate=True; Encrypt=False;";

        #region Funcionalidades

        public static async Task<IEnumerable<T>> GetAsync<T>(string sql, object parameters = null) //Função para o Dapper consultar em um banco de dados e retornar uma classe dinâmica
        {
            using var db = new SqlConnection(SQLConn);
            db.Open();
            return await db.QueryAsync<T>(sql, parameters);
        }

        public static async Task<int> ExecuteAsync(string sql, object parameters = null) //Função para o Dapper executar um comando em um banco de dados e retornar o n° de linhas atualizados
        {
            using var db = new SqlConnection(SQLConn);
            db.Open();
            return await db.ExecuteAsync(sql, parameters);
        }

        public static void CriarLog(string Mensagem) //Função para registrar em um txt um registro caso ocorra algum erro
        {
            try
            {
                using (StreamWriter LogFile = File.AppendText($"C:\\Qualit_Weather\\Logs\\{DateTime.Now.Day}_{DateTime.Now.Month}_{DateTime.Now.Year}.txt"))
                {
                    LogFile.WriteLine("[" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "]: " + Mensagem);
                    LogFile.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        #endregion

        #region Classes

        #region Gerais

        public class Favoritas //Classe para retornar do Dapper as informações de Cidades favoritas
        {
            public string ID = "";
            public string IDUsuario = "";
            public string NomeCidade = "";
        }

        #endregion

        #region API Weather
        public class WeatherApiResponse
        {
            [JsonProperty("location")]
            public Location Location { get; set; }

            [JsonProperty("current")]
            public Current Current { get; set; }
        }

        public class Location
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("region")]
            public string Region { get; set; }

            [JsonProperty("country")]
            public string Country { get; set; }

            [JsonProperty("lat")]
            public double Lat { get; set; }

            [JsonProperty("lon")]
            public double Lon { get; set; }

            [JsonProperty("tz_id")]
            public string TimezoneId { get; set; }

            [JsonProperty("localtime_epoch")]
            public long LocaltimeEpoch { get; set; }

            [JsonProperty("localtime")]
            public string Localtime { get; set; }
        }

        public class Current
        {
            [JsonProperty("last_updated_epoch")]
            public long LastUpdatedEpoch { get; set; }

            [JsonProperty("last_updated")]
            public string LastUpdated { get; set; }

            [JsonProperty("temp_c")]
            public double TempC { get; set; }

            [JsonProperty("temp_f")]
            public double TempF { get; set; }

            [JsonProperty("is_day")]
            public int IsDay { get; set; }

            [JsonProperty("condition")]
            public Condition Condition { get; set; }

            [JsonProperty("wind_mph")]
            public double WindMph { get; set; }

            [JsonProperty("wind_kph")]
            public double WindKph { get; set; }

            [JsonProperty("wind_degree")]
            public int WindDegree { get; set; }

            [JsonProperty("wind_dir")]
            public string WindDir { get; set; }

            [JsonProperty("pressure_mb")]
            public double PressureMb { get; set; }

            [JsonProperty("pressure_in")]
            public double PressureIn { get; set; }

            [JsonProperty("precip_mm")]
            public double PrecipMm { get; set; }

            [JsonProperty("precip_in")]
            public double PrecipIn { get; set; }

            [JsonProperty("humidity")]
            public int Humidity { get; set; }

            [JsonProperty("cloud")]
            public int Cloud { get; set; }

            [JsonProperty("feelslike_c")]
            public double FeelslikeC { get; set; }

            [JsonProperty("feelslike_f")]
            public double FeelslikeF { get; set; }

            [JsonProperty("windchill_c")]
            public double WindchillC { get; set; }

            [JsonProperty("windchill_f")]
            public double WindchillF { get; set; }

            [JsonProperty("heatindex_c")]
            public double HeatindexC { get; set; }

            [JsonProperty("heatindex_f")]
            public double HeatindexF { get; set; }

            [JsonProperty("dewpoint_c")]
            public double DewpointC { get; set; }

            [JsonProperty("dewpoint_f")]
            public double DewpointF { get; set; }

            [JsonProperty("vis_km")]
            public double VisibilityKm { get; set; }

            [JsonProperty("vis_miles")]
            public double VisibilityMiles { get; set; }

            [JsonProperty("uv")]
            public double UV { get; set; }

            [JsonProperty("gust_mph")]
            public double GustMph { get; set; }

            [JsonProperty("gust_kph")]
            public double GustKph { get; set; }
        }

        public class Condition
        {
            [JsonProperty("text")]
            public string Text { get; set; }

            [JsonProperty("icon")]
            public string Icon { get; set; }

            [JsonProperty("code")]
            public int Code { get; set; }
        }

        public class RootObject
        {
            [JsonPropertyName("location")]
            public Location Location { get; set; }

            [JsonPropertyName("current")]
            public Current Current { get; set; }

            [JsonPropertyName("forecast")]
            public Forecast Forecast { get; set; }
        }
        public class Forecast
        {
            public List<ForecastDay> Forecastday { get; set; }
        }

        public class ForecastDay
        {
            public string Date { get; set; }
            public long Date_Epoch { get; set; }
            public Day Day { get; set; }
            public Astro Astro { get; set; }
            public List<Hour> Hour { get; set; }
        }

        public class Day
        {
            public double Maxtemp_C { get; set; }
            public double Maxtemp_F { get; set; }
            public double Mintemp_C { get; set; }
            public double Mintemp_F { get; set; }
            public double Avgtemp_C { get; set; }
            public double Avgtemp_F { get; set; }
            public double Maxwind_Mph { get; set; }
            public double Maxwind_Kph { get; set; }
            public double Totalprecip_Mm { get; set; }
            public double Totalprecip_In { get; set; }
            public double Totalsnow_Cm { get; set; }
            public double Avgvis_Km { get; set; }
            public double Avgvis_Miles { get; set; }
            public int Avghumidity { get; set; }
            public int Daily_Will_It_Rain { get; set; }
            public int Daily_Chance_Of_Rain { get; set; }
            public int Daily_Will_It_Snow { get; set; }
            public int Daily_Chance_Of_Snow { get; set; }
            public Condition Condition { get; set; }
            public double Uv { get; set; }
        }

        public class Astro
        {
            public string Sunrise { get; set; }
            public string Sunset { get; set; }
            public string Moonrise { get; set; }
            public string Moonset { get; set; }
            public string Moon_Phase { get; set; }
            public int Moon_Illumination { get; set; }
            public int Is_Moon_Up { get; set; }
            public int Is_Sun_Up { get; set; }
        }

        public class Hour
        {
            public long Time_Epoch { get; set; }
            public string Time { get; set; }
            public double Temp_C { get; set; }
            public double Temp_F { get; set; }
            public int Is_Day { get; set; }
            public Condition Condition { get; set; }
            public double Wind_Mph { get; set; }
            public double Wind_Kph { get; set; }
            public int Wind_Degree { get; set; }
            public string Wind_Dir { get; set; }
            public double Pressure_Mb { get; set; }
            public double Pressure_In { get; set; }
            public double Precip_Mm { get; set; }
            public double Precip_In { get; set; }
            public double Snow_Cm { get; set; }
            public int Humidity { get; set; }
            public int Cloud { get; set; }
            public double Feelslike_C { get; set; }
            public double Feelslike_F { get; set; }
            public double Windchill_C { get; set; }
            public double Windchill_F { get; set; }
            public double Heatindex_C { get; set; }
            public double Heatindex_F { get; set; }
            public double Dewpoint_C { get; set; }
            public double Dewpoint_F { get; set; }
            public int Will_It_Rain { get; set; }
            public int Chance_Of_Rain { get; set; }
            public int Will_It_Snow { get; set; }
            public int Chance_Of_Snow { get; set; }
            public double Vis_Km { get; set; }
            public double Vis_Miles { get; set; }
            public double Gust_Mph { get; set; }
            public double Gust_Kph { get; set; }
            public double Uv { get; set; }
        }

        #endregion

        #endregion
    }
}
