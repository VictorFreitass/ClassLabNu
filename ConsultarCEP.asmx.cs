using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Objetos;
using System.Xml.Linq;

namespace ComercialSys91
{
    /// <summary>
    /// Summary description for WSConsultaCEP
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WSConsultaCEP : System.Web.Services.WebService
    {

        [WebMethod]
        public Endereco ConsultaCEP(string p_strCEP)
        {
            string url = "http://republicavirtual.com.br/web_cep.php?cep={0}&formato=xml";
            p_strCEP = p_strCEP.Replace("-", "").Trim();
            p_strCEP = p_strCEP.Replace(".", "");

            Endereco objEndereco = new Endereco();

            try
            {
                p_strCEP = string.Format(url, p_strCEP);
                XElement objXElement = new XElement("root");
                objXElement.Add(XElement.Load(p_strCEP));

                var dadosCEP = (from d in objXElement.Elements("webservicecep")
                                select new
                                {
                                    Resultado = d.Element("resultado").Value.ToString(),
                                    ResultadoTxt = d.Element("resultado_txt").Value.ToString(),
                                    UF = d.Element("uf").Value.ToString(),
                                    Cidade = d.Element("cidade").Value.ToString(),
                                    Bairro = d.Element("bairro").Value.ToString(),
                                    TipoLogradouro = d.Element("tipo_logradouro").Value.ToString(),
                                    Logradouro = d.Element("logradouro").Value.ToString()
                                }).Single();

                objEndereco.UF = dadosCEP.UF;
                objEndereco.Cidade = dadosCEP.Cidade;
                objEndereco.Bairro = dadosCEP.Bairro;
                objEndereco.TipoLogradouro = dadosCEP.TipoLogradouro;
                objEndereco.Logradouro = dadosCEP.Logradouro;

                switch (dadosCEP.Resultado)
                {
                    default:
                    case "0":
                        objEndereco.TipoCEP = "CEP não encontrado!";
                        break;
                    case "1":
                        objEndereco.TipoCEP = "CEP completo encontrado!";
                        break;
                    case "2":
                        objEndereco.TipoCEP = "CEP único encontrado!";
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar CEP informado. ERROR: " + ex.Message);
            }
            return objEndereco;
        }

    }
}
