using Newtonsoft.Json;
using SalonWpf.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SalonWpf.Controlers
{
    public class ServicesControlers
    {
        /// <summary>
        /// Вывод всех услуг
        /// </summary>
        /// <returns></returns>
        public static List<Services> GetServices()

        {
            using (HttpClient client = new HttpClient())

            {
                string query = $"{Manager.RootUrl}services";
                Console.WriteLine(query);
                HttpResponseMessage response = client.GetAsync(query).Result;
                var content = response.Content.ReadAsStringAsync();
                var answer = JsonConvert.DeserializeObject<List<Services>>(content.Result);
                return answer;

            }
        }
    }
}
