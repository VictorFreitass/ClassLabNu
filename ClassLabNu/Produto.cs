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
        private decimal valor;
        private decimal desconto;

        // criando propriedades
        public int Id { get { return id; } }
        public string Descricao { get { return descricao; } private set { descricao = value; } }
        public int Unidade { get { return unidade; } private set { unidade = value; } }
        public string Codbar { get { return codbar; } private set { codbar = value; } }
        public decimal Valor { get { return valor; } private set { valor = value; } }
        public decimal Desconto { get { return desconto; } private set { desconto = value; } }

        // métodos construtores
        public Produto()
        {

        }
        public Produto(string descricao, int unidade, string codbar, decimal valor, decimal desconto)
        {
            Descricao = descricao;
            Unidade = unidade;
            Codbar = codbar;
            Valor = valor;
            Desconto = desconto;
        }
        
        // métodos da classe
        public void Inserir (Produto produto)
        {

        }
        public bool Alterar(Produto produto)
        {
            return true;
        }
        public static Produto ConsultarPorId(int _id)
        {
            Produto produto = new Produto();
            return produto;
        }
            
        public static Produto ConsultarPorCodBar(int _id)
        {
            Produto produto = new Produto();
            return produto;       
        }
        public static List<Produto> Listar()
        {
            List<Produto> clientes = new List<Produto>();
            return clientes;
        }
    }
}