using System;
using System.Collections.Generic;
using System.Data;

namespace ClassLabNu
{
    public class Nivel
    {
        // atributos - campos
        private int id;
        private string nome;
        private string sigla;
        //public readonly bool ativo;

        // criando propriedades

        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } private set { nome = value; } }
        public string Sigla { get { return sigla; } }

        // métodos construtores
        public Nivel()
        {
        }

        public Nivel(string nome, string sigla)
        {
            this.nome = nome;
            this.sigla = sigla;
        }

        public Nivel(int id, string nome, string sigla)
        {
            this.id = id;
            this.nome = nome;
            this.sigla = sigla;
        }
        public Nivel(string nome, string sigla, int id)
        {
            this.Nome = nome;
            this.sigla = sigla;
            this.Id = id;
        }

        // métodos da classe
        public void Inserir()
        {
            //Abre conexão com banco
            var cmd = Banco.Abrir();

            //Comandos SQL
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "nivel_inserir";

            //Parametros
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_sigla", Sigla);
            id = Convert.ToInt32(cmd.ExecuteScalar());
            
            // Fecha conexão
            cmd.Connection.Close();
        }
        /// <summary>
        /// Altera a sigla do nível indicado. Apenas administradores.
        /// </summary>
        /// <param name="id">identificação do nivel</param>
        /// <param name="sigla">valor literal da nova sigla</param>
        /// <returns>Retorna valor para teste logico, confirmando a alteração</returns>
        public bool Alterar()
        {
            //Abrir conexão
            var cmd = Banco.Abrir();

            //Comando SQL
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = $"nivel_alterar";

            //Parametros
            cmd.Parameters.AddWithValue("_id", Id);
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_sigla", Sigla);
            
            //Variavel para receber retorno
            int retorna = cmd.ExecuteNonQuery();

            cmd.Connection.Close();

            //Retornando valor 
            if (retorna == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Nivel Consultar(int _id)
        {
            Nivel nivel = new Nivel();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from nivel where idNv =" + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read()) //data reader
            {
                nivel.Id = Convert.ToInt32(dr["idNv"]);
                nivel.Nome = dr.GetString(1);
            }
            return nivel;
            
        }
        public static List<Nivel> ListarNivel()
        {
            //Nova lista
            List<Nivel> lista = new List<Nivel>();

            //Abrir conexão
            var cmd = Banco.Abrir();

            //Comando
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from nivel";

            //Var para consulta
            var dr = cmd.ExecuteReader();

            //Consulta
            while (dr.Read())
            {
                lista.Add(new Nivel(
                dr.GetInt32(0),
                dr.GetString(1),
                dr.GetString(2)
                ));
            }
            //retornando lista
            return lista;
        }
    }
}
