using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace SalonWpf.Model
{

        public class Users
        {
        [JsonProperty("idrole")]
        public int IdRole { get; set; }
        [JsonProperty("userName")]
        public string UserName { get; set; }
        [JsonProperty("userLastName")]
        public string UserLastName { get; set; }
        [JsonProperty("userOtherName")]
        public string UserOtherName { get; set; }
        [JsonProperty("userLogin")]
        public string UserLogin { get; set; }
        [JsonProperty("userPassword")]
        public string UserPassword { get; set; }

        }

    
}
