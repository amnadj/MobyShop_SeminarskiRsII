using Flurl.Http;
using MobyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobyShop.WinUI
{
    public class APIService
    {

        private readonly string _route;
        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();


                }

                return await url.GetJsonAsync<T>();

            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Niste authentificirani");
                }
                throw;
            }
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            return await url.GetJsonAsync<T>();
        }
        public async Task<T> GetBySifra<T>(string sifra)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/GetBySifra/{sifra}";

            return await url.GetJsonAsync<T>();
        }
        public async Task<T> Authenticiraj<T>(string username, string password)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/Authenticiraj/{username},{password}";

            return await url.GetJsonAsync<T>();
        }
        public async Task<T> ProvjeriAdmin<T>(int UlogaId)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/ProvjeriAdmin/{UlogaId}";

            return await url.GetJsonAsync<T>();
        }

        public async Task<T> SveUloge<T>(int KorisnikId)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/SveUloge/{KorisnikId}";

            return await url.GetJsonAsync<T>();
        }

        public async void Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

            try
            {
                await url.PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void Update<T>(int id, object request)
        {
            try
            {
                var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

                var obj = Newtonsoft.Json.JsonConvert.SerializeObject(request);

                await url.PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }
}
