using System;
using System.Web;
using Wisej.Web;
using System.Net.Http;
using System.Threading.Tasks;
using static Qualit_Weather.Scripts.UtilityClass;
using Newtonsoft.Json;
using Microsoft.Ajax.Utilities;
using System.Collections.Generic;
using System.Linq;

namespace Qualit_Weather
{
    public partial class Main : Page
    {
        #region Variaveis

        List<string> CidadesFavoritas = new List<string>();
        string IDUsuario = "";
        string MainHTMLStr = "";
        string NomeConsultar = "";
        private static readonly string BaseUrl = "https://localhost:7256/";

        #endregion
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            MainHTMLStr = htmlMain.Html;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNomeCidade.Text == "")
            {
                MessageBox.Show("Por favor insira um nome de cidade para pesquisar!", icon: MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    NomeConsultar = txtNomeCidade.Text;

                    if (cbEstado.Text != "")
                    {
                        var Estado = cbEstado.Text.Split('-')[1].Substring(1);
                        NomeConsultar = $"{RemoverAcentos(NomeConsultar)},{RemoverAcentos(Estado)}";
                    }

                    if (cb5Dias.Checked)
                    {
                        string resultado = GetWeather5DaysFromApi(NomeConsultar);
                        if (resultado.Contains("Erro ao consultar o clima"))
                        {
                            MessageBox.Show("Cidade não encontrada, por favor tente novamente", icon: MessageBoxIcon.Warning);
                            txtNomeCidade.Text = "";
                        }
                        else
                        {
                            htmlMain.Html = MainHTMLStr;

                            WeatherApiResponse response = JsonConvert.DeserializeObject<WeatherApiResponse>(resultado);

                            foreach (var dia in response.Forecast.Forecastday)
                            {
                                string DiaMes = "";

                                if(DateTime.TryParse(dia.Date, out DateTime result))
                                {
                                    DiaMes = $"{result.Day.ToString("00")}/{result.Month.ToString("00")}";
                                }

                                string HTMLContent = $@"<div class='weather-card'>
                                <h2>{ObterDiaSemana(dia.Date)} - {DiaMes}</h2>
                                <div class='weather-icon'>
                                  <img src='{dia.Day.Condition.Icon}' alt=''>
                                </div>
                                <div class='temp'>{dia.Day.Maxtemp_C} °C / {dia.Day.Mintemp_C} °C</div>
                                <div class='condition'>{dia.Day.Condition.Text.Replace("Ã©","é")}</div>
                                <div class='details'>
                                  <p><strong>Vento:</strong> {dia.Day.Maxwind_Kph} km/h</p>
                                  <p><strong>Umidade:</strong> {dia.Day.Avghumidity}%</p>
                                  <p><strong>Chance de Chuva:</strong> {dia.Day.Daily_Chance_Of_Rain} mb</p>
                                </div>
                              </div>";

                                int lastDivIndex = this.htmlMain.Html.LastIndexOf("</div>");
                                string htmlBeforeLastDiv = this.htmlMain.Html.Substring(0, lastDivIndex);
                                string updatedHtml = htmlBeforeLastDiv + HTMLContent + @"</div></body></html>";
                                this.htmlMain.Html = updatedHtml;
                            }
                        }
                    }
                    else
                    {
                        string resultado = GetWeatherFromApi(NomeConsultar);
                        if (resultado.Contains("Erro ao consultar o clima"))
                        {
                            MessageBox.Show("Cidade não encontrada, por favor tente novamente", icon: MessageBoxIcon.Warning);
                            txtNomeCidade.Text = "";
                        }
                        else
                        {
                            //txtInfo.Text = resultado;
                            htmlMain.Html = MainHTMLStr;

                            WeatherApiResponse response = JsonConvert.DeserializeObject<WeatherApiResponse>(resultado);

                            var Hr = DateTime.Now;
                            string Horario = $"{Hr.Day.ToString("00")}/{Hr.Month.ToString("00")}/{Hr.Year.ToString("0000")} {Hr.Hour.ToString("00")}:{Hr.Minute.ToString("00")}:{Hr.Second.ToString("00")}";

                            try
                            {
                                DateTime dtLocal = DateTime.Parse(response.Location.Localtime);
                                Horario = $"{dtLocal.Day.ToString("00")}/{dtLocal.Month.ToString("00")}/{dtLocal.Year.ToString("0000")} {dtLocal.Hour.ToString("00")}:{dtLocal.Minute.ToString("00")}:{dtLocal.Second.ToString("00")}";
                            }
                            catch { }

                            string HTMLContent = $@"<div class='weather-card'>
                            <h2>Clima em {response.Location.Name} - {response.Location.Region}</h2>
                                <small>Atualizado em: {Horario}</small>
                
                                <div class='weather-icon'>
                                    <img src='{response.Current.Condition.Icon}' alt=''>
                                </div>
                                <div class='temp'>{response.Current.TempC} °C</div>
                                <div class='condition'>{response.Current.Condition.Text.Replace("Ã©","é")}</div>

                                <div class='details'>
                                    <p><strong>Vento:</strong> {response.Current.WindKph} km/h (NNW - {response.Current.WindDegree}°)</p>
                                    <p><strong>Rajadas de vento:</strong> {response.Current.GustKph} km/h</p>
                                    <p><strong>Pressão atmosférica:</strong> {response.Current.PressureMb} mb</p>
                                    <p><strong>Umidade relativa:</strong> {response.Current.Humidity}%</p>
                                    <p><strong>Nuvens no céu:</strong> {response.Current.Cloud}%</p>
                                    <p><strong>Visibilidade:</strong> {response.Current.VisibilityKm} km</p>
                                    <p><strong>Índice UV:</strong> {response.Current.UV}</p>
                                    <p><strong>Ponto de orvalho:</strong> {response.Current.DewpointC} °C</p>
                                    <p><strong>Precipitação acumulada:</strong> {response.Current.PrecipMm} mm</p>
                                </div>
                            </div>";

                            int lastDivIndex = this.htmlMain.Html.LastIndexOf("</div>");
                            string htmlBeforeLastDiv = this.htmlMain.Html.Substring(0, lastDivIndex);
                            string updatedHtml = htmlBeforeLastDiv + HTMLContent + @"</div></body></html>";
                            this.htmlMain.Html = updatedHtml;

                            btnFavoritarCidade.Visible = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }

        private void btnFavoritarCidade_Click(object sender, EventArgs e)
        {
            if (IDUsuario == "")
            {
                MessageBox.Show("Por favor faça Login para favoritar cidades!", icon: MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (!CidadesFavoritas.Contains(NomeConsultar))
                {
                    AddFav(NomeConsultar);
                    CidadesFavoritas.Add(NomeConsultar);
                    RefreshFavorites();
                }
                else
                {
                    MessageBox.Show("Cidade já adicionada nos favoritos!");
                }
            }
        }

        void RefreshFavorites()
        {
            var listaFavs = ListarFavoritos(IDUsuario);
            CidadesFavoritas = JsonConvert.DeserializeObject<List<string>>(listaFavs);
            dtFavoritos.DataSource = CidadesFavoritas;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IDUsuario = "0";
            pnlFavoritos.Visible = true;
            RefreshFavorites();
            MessageBox.Show("Login realizado com sucesso!");
        }

        private void btnPesquisarCidadeFav_Click(object sender, EventArgs e)
        {
            var selecionado = CidadesFavoritas[dtFavoritos.CurrentItemIndex];
            txtNomeCidade.Text = selecionado;
            btnPesquisar.PerformClick();
        }

        private void btnDeletarCidadeFav_Click(object sender, EventArgs e)
        {
            var selecionado = CidadesFavoritas[dtFavoritos.CurrentItemIndex];
            DialogResult result = MessageBox.Show($"Deseja remover dos favoritos a cidade '{selecionado}'?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                RemFav(selecionado);
                RefreshFavorites();
            }
        }

        private void dtFavoritos_ItemUpdate(object sender, DataRepeaterItemEventArgs e)
        {
            var controls = e.DataRepeaterItem.Controls;
            string info = CidadesFavoritas[e.DataRepeaterItem.ItemIndex];

            controls["txtCidade"].Text = $"{info}";
        }

        #region Calls API

        private string AddFav(string city)
        {
            using (var client = new System.Net.WebClient())
            {
                client.Headers.Add("User-Agent", "WiseJ-App");
                string url = $"https://localhost:7256/Weather/Favoritar/{Uri.EscapeDataString(city)}";

                return client.DownloadString(url);
            }
        }

        private string RemFav(string city)
        {
            using (var client = new System.Net.WebClient())
            {
                client.Headers.Add("User-Agent", "WiseJ-App");
                string url = $"https://localhost:7256/Weather/RemFavoritos/{Uri.EscapeDataString(city)}";

                return client.DownloadString(url);
            }
        }

        private string ListarFavoritos(string ID)
        {
            using (var client = new System.Net.WebClient())
            {
                client.Headers.Add("User-Agent", "WiseJ-App");
                string url = $"https://localhost:7256/Weather/Favoritos/{Uri.EscapeDataString(ID)}";

                return client.DownloadString(url);
            }
        }

        private string GetWeatherFromApi(string city)
        {
            using (var client = new System.Net.WebClient())
            {
                client.Headers.Add("User-Agent", "WiseJ-App");
                string url = $"https://localhost:7256/Weather/Cidade/{Uri.EscapeDataString(city)}";

                return client.DownloadString(url);
            }
        }

        private string GetWeather5DaysFromApi(string city)
        {
            using (var client = new System.Net.WebClient())
            {
                client.Headers.Add("User-Agent", "WiseJ-App");
                string url = $"https://localhost:7256/Weather/CidadeWeek/{Uri.EscapeDataString(city)}";

                return client.DownloadString(url);
            }
        }

        #endregion
    }
}
