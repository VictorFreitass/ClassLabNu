using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLabNu
{
    // Documentação de classes de projeto. - XML Docs
    public class Usuario
    {
        // atributos
        public int id { get; set;}
        public int nivel{ get; set; }
        public bool ativo{ get; set; }
        public string nome{ get; set; }
        public string email { get; set; }
        public string password { get; set; }
  
        // métodos Construtores
        public Usuario ()
        {

        }
        public Usuario (string nome, string email, int nivel, string password)
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
        public void Inserir(string nome, string senha, string email)
        {
            var cmd = Banco.Abrir ();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuarios_inserir";
            cmd.Parameters.AddWithValue ( " _nome", nome);
            cmd.Parameters.AddWithValue ( " _senha", senha);
            cmd.Parameters.AddWithValue ( " _email ", email);

            id = Convert.ToInt32 (cmd.ExecuteScalar());
            cmd.ExecuteNonQuery ();
        }
        public static bool EfetuarLogin(string email, string senha)
        {
            bool resultado = false;
            //realiza a validação e devolve verdadeiro ou falso
            var cmd =Banco.Abrir ();
            cmd.CommandText = "select * from usuarios where email = '"+email+"' and senha md5('"+senha+"')";
            var dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{
            //    resultado = true;
            //}
            //return resultado;
            resultado = dr.Read() ? true : false;
            return resultado;
        }
    }
}
