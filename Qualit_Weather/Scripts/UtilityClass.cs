using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;

namespace Qualit_Weather.Scripts
{
    public static class UtilityClass
    {
        #region Funcionalidades

        public static string ObterDiaSemana(string dataString)
        {
            if (!DateTime.TryParseExact(
                    dataString,
                    "yyyy-MM-dd",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime data))
            {
                throw new ArgumentException("Erro");
            }

            var culture = new CultureInfo("pt-BR");
            string nomeDia = culture.DateTimeFormat.GetDayName(data.DayOfWeek);

            return char.ToUpper(nomeDia[0]) + nomeDia.Substring(1);
        }

        public static string RemoverAcentos(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return texto;

            string textoNormalizado = texto.Normalize(NormalizationForm.FormD);

            var sb = new StringBuilder();
            foreach (char c in textoNormalizado)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    sb.Append(c);
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }

        #endregion

        #region Classes API
        public class WeatherApiResponse
        {
            [JsonProperty("location")]
            public Location Location { get; set; }

            [JsonProperty("current")]
            public Current Current { get; set; }

            [JsonProperty("forecast")]
            public Forecast Forecast { get; set; }
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
    }
}