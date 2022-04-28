using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLabNu
{
    public class Nivel
    {
        // atributos - campos
        private int id;
        private string nome;
        private string sigla;
        public readonly bool ativo;

        // criando propriedades

        public int Id { get { return id; } set {id = value; }}
        public string Nome { get { return nome; } private set { nome = value; } }
        public string Sigla { get { return sigla; }}

        

        // métodos construtores
        public Nivel()
        {
        }

        public Nivel(string nome, string sigla)
        {
            this.nome = nome;
            this.sigla = sigla;
            ativo = true;
        }

        public Nivel(int id, string nome, string sigla, bool ativo)
        {
            this.id = id;
            this.nome = nome;
            this.sigla = sigla;
            this.ativo = ativo;
        }
        // métodos da classe
        public void InserirNovo()
        {
            // inserir um novo nível
        }
        /// <summary>
        /// Altera a sigla do nível indicado. Apenas administradores.
        /// </summary>
        /// <param name="id">identificação do nivel</param>
        /// <param name="sigla">valor literal da nova sigla</param>
        /// <returns>Retorna valor para teste logico, confirmando a alteração</returns>
        public bool Alterar(int id, string sigla)
        {
            return true;
        }

        public static Nivel Consultar (int _id)
        {
            Nivel nivel = new Nivel();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from nivel where idNv =" + _id;
            var dr = cmd.ExecuteReader ();
            while (dr.Read()) //data reader
            {
                nivel.Id = Convert.ToInt32(dr["idNv"]);
                nivel.Nome = dr.GetString(1);
            }
            return nivel;
        }
    }
}
