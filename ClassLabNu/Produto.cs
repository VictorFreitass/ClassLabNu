using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLabNu
{
    public class Produto
    {
        // atributos
        private int id;
        private string descricao;
        private string unidade;
        private string codbar;
        private double valor;
        private double desconto;
        private bool descontinuado;

        // criando propriedades
        public int Id { get { return id; } set { id = value; } }
        public string Descricao { get { return descricao; } private set { descricao = value; } }
        public string Unidade { get { return unidade; } private set { unidade = value; } }
        public string Codbar { get { return codbar; } private set { codbar = value; } }
        public double Valor { get { return valor; } private set { valor = value; } }
        public double Desconto { get { return desconto; } private set { desconto = value; } }
        public bool Descontinuado { get { return descontinuado; } private set { descontinuado = value; } }

        // métodos construtores
        public Produto()
        {

        }
        public Produto(int id, string descricao, string unidade, string codbar, double valor, double desconto, bool descontinuado)
        {
            Id = id;
            Descricao = descricao;
            Unidade = unidade;
            Codbar = codbar;
            Valor = valor;
            Desconto = desconto;
            Descontinuado = descontinuado;
        }

        public Produto( string descricao, string unidade, string codbar, double valor, double desconto)
        {
            Descricao = descricao;
            Unidade = unidade;
            Codbar = codbar;
            Valor = valor;
            Desconto = desconto;
        }

        // métodos da classe
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produtos_inserir";
            cmd.Parameters.AddWithValue("_descricao", Descricao);
            cmd.Parameters.AddWithValue("_unidade", Unidade);
            cmd.Parameters.AddWithValue("_codbar", Codbar);
            cmd.Parameters.AddWithValue("_valor", Valor);
            cmd.Parameters.AddWithValue("_desconto", Desconto);
            cmd.Parameters.AddWithValue("_descontinuado", Descontinuado);
            id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
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
        public bool Alterar()
        {
            return true;
        }
        public static List<Produto> Listar()
        {
            List<Produto> produtos  = new List<Produto>();
            var cmd = Banco.Abrir();
            // cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from produtos order by nome;";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produtos.Add(new Produto(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDouble(4),
                    dr.GetDouble(5),
                    dr.GetBoolean(6)  
                    ));
            }
            return produtos;
        }
    }
}