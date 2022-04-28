
using ComercialSys91;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;

namespace ComercialSys
{
    public static class Cep
    {
        public static ViaCep RetornaCep { get; set; }

        public static ViaCep ConsultaCep(string _cep)
        {

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            // String para a URL
            string strURL = string.Format($"https://viacep.com.br/ws/{_cep}/json/");


            // HTTP client
            using (HttpClient client = new HttpClient())
            {
                // Result
                var rsp = client.GetAsync(strURL).Result;

                // Verificando Status
                if (rsp.IsSuccessStatusCode)
                {
                    var result = rsp.Content.ReadAsStringAsync().Result;

                    // Desirialize do objeto
                    ViaCep RetornaCep = JsonConvert.DeserializeObject<ViaCep>(result);
                }
            }
            return RetornaCep;

        }
    }
}
