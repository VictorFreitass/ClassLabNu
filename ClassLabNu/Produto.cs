using System.Collections.Generic;

namespace ClassLabNu
{
    public class Produto
    {
        // atributos
        private int id;
        private string descricao;
        private int unidade;
        private string codbar;
        private double valor;
        private double desconto;
        private bool descontinuado;

        // criando propriedades
        public int Id { get { return id; } }
        public string Descricao { get { return descricao; } private set { descricao = value; } }
        public int Unidade { get { return unidade; } private set { unidade = value; } }
        public string Codbar { get { return codbar; } private set { codbar = value; } }
        public double Valor { get { return valor; } private set { valor = value; } }
        public double Desconto { get { return desconto; } private set { desconto = value; } }
        public bool Descontinuado { get { return descontinuado; } private set { descontinuado = value; } }

        // métodos construtores
        public Produto()
        {

        }
        public Produto(string descricao, int unidade, string codbar, double valor, double desconto, bool descontinuado)
        {
            Descricao = descricao;
            Unidade = unidade;
            Codbar = codbar;
            Valor = valor;
            Desconto = desconto;
            Descontinuado = descontinuado;
        }
        
        // métodos da classe
        public void Inserir ()
        {

        }
        public static Produto ConsultarPorId(int _id)
        {
            Produto produto = new Produto();
            // conecta banco realiza consulta por Id do produto
            return produto;
        }
        public static Produto ConsultarPorCodBar(string _codbar)
        {
            Produto produto = new Produto();
            // conecta banco e realiza consulta por código de barras do produto
            return produto;       
        }
        public List<Produto> BuscarPorDescricao(string _descricao)
        {
            List<Produto> produtos = new List<Produto>();
            // conecta banco e realiza consulta por parte da descricao do produto
            return produtos; 
        } 
        public List<Produto> ListarTodos()
        {
            List<Produto> produtos = new List<Produto>();
            // conecta banco e realiza consulta retornando todos produtos
            return produtos;
        }
        public bool Alterar ()
        {
            return true;
        }
    }
}