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
        private string nome;
        private string email;
        private Nivel nivel;
        private string password;
        private bool ativo;
        public string Nome { get { return nome; } }
        public string Email { get { return email; } set { email = value; } }
        public string Password
        { 
            get 
            { 
                // restrições
                return password; 
            } 
        }
        public Nivel Nivel { get { return nivel; } }
        public bool Ativo { get { return ativo; } set { ativo = value; } }
        
        // métodos Construtores
        public Usuario ()
        {

        }
        public Usuario (string nome, string email, Nivel nivel, string password)
        {
            this.nome = nome;
            this.email = email;
            this.nivel = nivel;
            this.password = password;
            ativo = true;
        }
        public Usuario(int id, string nome, string email, string password, Nivel nivel, bool ativo)
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
            //realiza a validação e devolve verdadeiro ou falso
            return false;
        }
    }
}
