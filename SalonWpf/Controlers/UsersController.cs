using Newtonsoft.Json;
using SalonWpf.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SalonWpf.Controlers
{
    public static class UsersController
    {
        /// <summary>
        /// Авторизация
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns>
        /// Статус ответа
        /// </returns>
     
        public static bool Auth(string login,string password)
        {
            using (HttpClient client = new HttpClient())
            {
                string query = $"{Manager.RootUrl}Users/{login}/{password}";
                Console.WriteLine(query);
                HttpResponseMessage response = client.GetAsync(query).Result;
                return response.IsSuccessStatusCode;
            }
        }


        /// <summary>
        /// Регистриция
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool AddUser (Users user)
        {
            string jsonStr = JsonConvert.SerializeObject(user);
            var buffer = System.Text.Encoding.UTF8.GetBytes(jsonStr);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.PostAsync($"{Manager.RootUrl}Users", byteContent).Result;
                return response.IsSuccessStatusCode;
            }
        }
    }


}
