using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabNu
{
    public class Pedido
    {
        /*
        // idped data status_ped desconto idcli_ped iduser_ped

        // atributos
        private int id;
        private DateTime dataCad;
        private string statusPed;
        private decimal desconto;
        private int idCli;
        private int idUser;

        // propriedades
        public int Id { get { return id; } set { id = value; } }
        public DateTime DataCad { get { return dataCad; } set { dataCad = value; } }
        public string StatusPed { get { return statusPed; } set { statusPed = value; } }
        public decimal Desconto { get { return desconto; } set { desconto = value; } }
        public int IdCli { get { return idCli; } set { idCli = value; } }
        public int IdUser { get { return idUser; } set { idUser = value; } }


        // métodos construtores
        public Pedido()
        {

        }
        public Pedido(int id, DateTime dataCad, string statusPed, decimal desconto, int idCli, int idUser)
        {
            Id = id;
            DataCad = dataCad;
            StatusPed = statusPed;
            Desconto = desconto;
            IdCli = idCli;
            IdUser = idUser;
        }

        // métodos da classe
        public void Inserir(Pedido pedido)
        {

        }
        public bool Alterar(Pedido pedido)
        {
            return true;
        }
        public static Pedido ConsultarStatusPed(Pedido pedido)
        {
            Pedido Pedido = new Pedido();
            return Pedido;
        }
        public static Pedido ConsultarIdCli(Pedido pedido)
        {
            Pedido Pedido = new Pedido();
            return Pedido;
        }
        public static Pedido ConsultarIdUser(Pedido pedido)
        {
            Pedido Pedido = new Pedido();
            return Pedido;
        }
        public static List<Pedido> Listar()
        {
            List<Pedido> clientes = new List<Pedido>();
            return clientes;
        }
        */

        //Propriedades
        public int Id { get; set; }
        public DateTime DataPed { get; set;}
        public string Status { get; set; }
        public double Desconto { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set; }
        public List<ItemPedido> Itens { get; set; }

        // construtores
        public Pedido () { }
        public Pedido(DateTime dataPed, string status, double desconto, Cliente cliente, Usuario usuario, List<ItemPedido> itens)
        {
            DataPed = dataPed;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Itens = itens;
        }
        public Pedido(int id, DateTime dataPed, string status, double desconto, Cliente cliente, Usuario usuario, List<ItemPedido> itens)
        {
            Id = id;
            DataPed = dataPed;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Itens = itens;
        }
        // Métodos da classe - Operações/Ações/Funções
        public void Inserir () { }
        public bool Alterar(Pedido pedido) 
        {
            return false;
        }
        public static Pedido ConsultarPorId(int _id)
        {
            Pedido pedido = new Pedido();
            // conecta banco realiza consulta por Id do pedido
            return pedido;
        }
        public static List<Pedido> ConsultarPorClienteId(int _id)
        {
            List<Pedido> pedidos = new List<Pedido>();
            // conecta banco e realiza consulta por parte do id cliente
            return pedidos;
        }
    }
}
