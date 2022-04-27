using ComercialSys;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialSys91
{
    public class ViaCep
    {
       [JsonProperty (PropertyName = "cep")]
        public static string cep { get; set; }

        [JsonProperty(PropertyName = "complemento")]
        public static string complemento { get; set; }

        [JsonProperty(PropertyName = "logradouro")]
        public static string logradouro { get; set; }

        [JsonProperty(PropertyName = "uf")]
        public static string uf { get; set; }

        [JsonProperty(PropertyName = "siafi")]
        public static string siafi { get; set; }

        [JsonProperty(PropertyName = "localidade")]
        public static string localidade { get; set; }

        [JsonProperty(PropertyName = "bairro")]
        public static string bairro { get; set; }

        [JsonProperty(PropertyName = "ibge")]
        public static string ibge { get; set; }

        public static string estado { get; set; }

    }
}
