using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabNu
{
    public class Pedido
    {
        // atributos
        private int id;
        private DateTime dataCad;
        private string statusPed;
        private decimal desconto;
        private int idCli;
        private int idUser;

        //propriedades
        public int Id { get { return id; } set { id = value; } }
        public DateTime DataCad { get { return dataCad; } set { dataCad = value; } }
        public string StatusPed { get { return statusPed; } set { statusPed = value; } }
        public decimal Desconto { get { return desconto; } set { desconto = value; } }
        public int IdCli { get { return idCli; } set { idCli = value; } }
        public int IdUser { get { return idUser; } set { idUser = value; } }
    }
}
