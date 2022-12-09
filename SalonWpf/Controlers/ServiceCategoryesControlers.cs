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
   public class ServiceCategoryesControlers
    {

        /// <summary>
        /// Вывод категорий салона
        /// </summary>
        /// <returns></returns>
        public static List<ServiceCategoryes> GetServiceCategoryes()

        {

            using (HttpClient client = new HttpClient())
            {
                string query = $"{Manager.RootUrl}servicecategoryes";
                Console.WriteLine(query);
                HttpResponseMessage response = client.GetAsync(query).Result;
                var content = response.Content.ReadAsStringAsync();
                var answer = JsonConvert.DeserializeObject<List<ServiceCategoryes>>(content.Result);
                return answer;

            }

        }
    }
}
