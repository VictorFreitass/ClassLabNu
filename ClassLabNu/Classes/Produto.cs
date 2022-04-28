using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


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
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from produtos where idProd =" + _id;        
            MySqlDataReader dr = cmd.ExecuteReader ();
            while (dr.Read ())
            {
                produto.Id = Convert.ToInt32(dr["id"]);
                produto.Descricao = dr.GetString(1);
                produto.Unidade = dr.GetString(2);
                produto.Codbar = dr.GetString(3);
                produto.Valor = dr.GetDouble(4);
                produto.Desconto = dr.GetDouble(5);
                produto.Descontinuado = dr.GetBoolean(6);
            }
            return produto;
        }
        public static Produto ConsultarPorCodBar(string _codbar)
        {
            Produto produto = new Produto();
            // conecta banco e realiza consulta por Id do Produto
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from produtos where codbar =" + _codbar;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) // dr data reader
            {
                produto.Id = Convert.ToInt32(dr["idProd"]);
                produto.Descricao = dr.GetString(1);
                produto.Unidade = dr.GetString(2);
                produto.Codbar = dr.GetString(3);
                produto.Valor = dr.GetDouble(4);
                produto.Desconto = dr.GetDouble(5);
                produto.Descontinuado = dr.GetBoolean(6);
            }
            return produto;
        }
        public List<Produto> BuscarPorDescricao(string _descricao)
        {
            List<Produto> l = new List<Produto>();
            // conecta banco e realiza consulta por Id do Produto
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from produtos where descricao =" + _descricao;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) // dr data reader
            {
                l.Add(new Produto(
                Id = Convert.ToInt32(dr["idProd"]),
                Descricao = dr.GetString(1),
                Unidade = dr.GetString(2),
                Codbar = dr.GetString(3),
                Valor = dr.GetDouble(4),
                Desconto = dr.GetDouble(5),
                Descontinuado = dr.GetBoolean(6)

                ));
               
            }
            return l;
        }
        public static List<Produto> ListarTodos(string descriParte = null)
        {
            List<Produto> produtos = new List<Produto>();
            // conecta banco e realiza consulta retornando todos produtos
            MySqlCommand cmd = Banco.Abrir();
            if (descriParte == null)
            { //lista produtos ativos ordenado alfabeticamente
                cmd.CommandText = "select * from produtos where descontinuado = 0 order by 2";
            }
            else
            { // lista produtos ativos, por parte da descricao e ordenado alfabeticamente
                cmd.CommandText = "select * from produtos where descontinuado = 0 and descricao like '%"+descriParte+"%' order by 2";
            }
            MySqlDataReader dr = cmd.ExecuteReader();
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
            cmd.Connection.Close();
            return produtos;
        }
        public bool Alterar(int _id, string descricao, double unidade, string codbar, double valor, double desconto)
        {
            bool resultado = false;
            try
            {
                MySqlCommand cmd = Banco.Abrir();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                // Recebe o nome da procedure
                cmd.CommandText = "sp_produto_alterar";
                // Recebe os parâmetros da procedure do MySQL
                cmd.Parameters.Add("_id", MySqlDbType.Int32).Value = _id; // usa de forma mais técnica e é necessário saber exatamente o tipo de valor do parametro
                cmd.Parameters.Add("_descricao", MySqlDbType.VarChar).Value = Descricao;
                cmd.Parameters.Add("_unidade", MySqlDbType.VarChar).Value = Unidade;
                cmd.Parameters.Add("_codbar", MySqlDbType.VarChar).Value = Codbar;
                cmd.Parameters.Add("_valor", MySqlDbType.Decimal).Value = Valor;
                cmd.Parameters.Add("_desconto", MySqlDbType.Decimal).Value = Desconto;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

            }
            return resultado;
        }
        public static List<Produto> Listar()
        {
            List<Produto> produtos  = new List<Produto>();
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from produtos order by nome;";
            MySqlDataReader dr = cmd.ExecuteReader();
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