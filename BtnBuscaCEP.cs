using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BuscaCEP.WSCEP;

namespace ComercialSys91
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultaCEP2_Click(object sender, EventArgs e)
        {
            WSCEP.WSConsultaCEP objWSConsultaCEP = new BuscaCEP.WSCEP.WSConsultaCEP();

            Endereco objEndereco = new Endereco();

            objEndereco = objWSConsultaCEP.ConsultaCEP(this.txtCep.Text);

            this.txtCidade.Text = objEndereco.Cidade;
            this.txtBairro.Text = objEndereco.Bairro;
            this.txtLogradouro.Text = objEndereco.Logradouro;
            this.txtTipo.Text = objEndereco.TipoLogradouro;
            this.txtEstado.Text = objEndereco.UF;
            this.lblTipo.Text = objEndereco.TipoCEP;
        }

    }
}
