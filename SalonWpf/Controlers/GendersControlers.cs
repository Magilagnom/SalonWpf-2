using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using Newtonsoft.Json;
using System.Net.Http;
using SalonWpf.Model;

namespace SalonWpf.Controlers
{
    class GendersControlers
    {
        public List<Genders> GetGenders()
        {
            using (HttpClient client = new HttpClient())
            {
                string query = $"{Manager.RootUrl}genders";
                Console.WriteLine(query);
                HttpResponseMessage response = client.GetAsync(query).Result;
                var content = response.Content.ReadAsStringAsync();
                var answer = JsonConvert.DeserializeObject<List<Genders>>(content.Result);
                return answer;

            }

        }
    }
}

