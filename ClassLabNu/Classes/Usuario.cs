using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ClassLabNu
{
    // Documentação de classes de projeto. - XML Docs
    public class Usuario
    {
        // atributos
        public int id { get; set; }
        public int nivel { get; set; }
        public bool ativo { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        // métodos Construtores
        public Usuario(int nivel, string nome, string email, string password)
        {
            this.nivel = nivel;
            this.nome = nome;
            this.email = email;
            this.password = password;
        }
        public Usuario()
        {

        }
        public Usuario(string nome, string email, int nivel, string password)
        {
            this.nome = nome;
            this.email = email;
            this.nivel = nivel;
            this.password = password;
            ativo = true;
        }
        public Usuario(int id, string nome, string email, string password, int nivel, bool ativo)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.password = password;
            this.nivel = nivel;
            this.ativo = ativo;
        }

        // métodos da classe
        public void Inserir()
            {
                // Abre conexão com banco
                var cmd = Banco.Abrir();

                //Comandos SQL
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_usuarios_inserir";

                // Parametros
                cmd.Parameters.AddWithValue(" _nome", nome);
                cmd.Parameters.AddWithValue(" _senha", password);
                cmd.Parameters.AddWithValue(" _email ", email);
                cmd.Parameters.AddWithValue("_idnv", nivel);
                id = Convert.ToInt32(cmd.ExecuteScalar());

                // Fechar conexão
                //cmd.ExecuteNonQuery ();
                cmd.Connection.Close();
            
        }
        public static bool EfetuarLogin(string email, string senha)
        {
            bool resultado = false;
            //realiza a validação e devolve verdadeiro ou falso
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from usuarios where email = '" + email + "' and senha md5('" + senha + "')";
            var dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{
            //    resultado = true;
            //}
            //return resultado;
            resultado = dr.Read() ? true : false;
            return resultado;
        }
        public static List<Usuario> ListarUsuarios(int i = 0, int l = 0)
        {
            // Nova lista
            List<Usuario> lista = new List<Usuario>();

            // Abrir conexão
            var cmd = Banco.Abrir();

            // Comando
            cmd.CommandType = CommandType.Text;
            if (1 > 0)
                cmd.CommandText = $"select * from usuarios limit {i} , {1}";
            else
                cmd.CommandText = "select * from usuarios";

            // Var para consulta
            var dr = cmd.ExecuteReader();

            //Consulta
            while (dr.Read())
            {
                lista.Add(new Usuario(
                    Convert.ToInt32(dr.GetValue(0)),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetInt32(4),
                    dr.GetBoolean(5)
                    ));
            }
            // Fecha conexão
            cmd.Connection.Close();

            // Retornando lista
            return lista;
        }
        public bool Alterar()
        {
            //Abrir conexao
            var cmd = Banco.Abrir();

            //Comando Sql
            cmd.CommandText = $"update usuarios set nome = '{nome}', senha = '{password}', email = '{email}', ativo = {ativo}, nivel = '{nivel}' where iduser = {id}";
            int ret = cmd.ExecuteNonQuery();

            // retornando valor

            if (ret == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ConsultarPorId(int _id)
        {
            // Abre conexao com o banco
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where iduser = '{_id}'";

            // Var para leitura
            var dr = cmd.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                id = dr.GetInt32(0);
                nome = dr.GetString(1);
                email = dr.GetString(2);
                password = dr.GetString(3);
                nivel = dr.GetInt32(4);
                ativo = dr.GetBoolean(5);
            }
        }
        public void ConsultarPorNome (string _nome)
        {
            //Abre conexão com o banco
            var cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType= CommandType.Text;
            cmd.CommandText = $"select * from usuarios where nome = '{_nome}'";

            // Var para leitura
            var dr = cmd.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                id = dr.GetInt32(0);
                nome = dr.GetString(1);
                email = dr.GetString(2);
                password = dr.GetString(3);
                nivel = dr.GetInt32(4);
                ativo = dr.GetBoolean(5);
            }
        }
    }
}