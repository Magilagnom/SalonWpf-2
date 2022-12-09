using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SalonWpf.Model
{

        public class Genders
        {
            [JsonProperty("code")]
            public string Code { get; set; }
            [JsonProperty("name")]
            public string Name { get; set; }
            [JsonProperty("client")]
            public Client[] Client { get; set; }
        }

        public class Client
        {
            [JsonProperty("id")]
            public int Id { get; set; }
            [JsonProperty("firstName")]

            public string FirstName { get; set; }
            [JsonProperty("lastName")]
            public string LastName { get; set; }
            [JsonProperty("patronymic")]
            public string Patronymic { get; set; }
            [JsonProperty("birthday")]
            public DateTime Birthday { get; set; }
            [JsonProperty("registrationDate")]
            public DateTime RegistrationDate { get; set; }
            [JsonProperty("email")]
            public string Email { get; set; }
            [JsonProperty("phone")]
            public string Phone { get; set; }
            [JsonProperty("genderCode")]
            public string GenderCode { get; set; }
            [JsonProperty("photoPath")]
            public object PhotoPath { get; set; }
            [JsonProperty("clientServices")]
            public object[] ClientServices { get; set; }
            [JsonProperty("tagOfClient")]
            public object[] TagOfClient { get; set; }
        }

    }
