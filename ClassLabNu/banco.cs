using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClassLabNu
{
    public static class Banco
    {
        public static MySqlCommand Abrir()
        {
            MySqlCommand cmd = new MySqlCommand();
            string strcon = @"";
            MySqlConnection cn = new MySqlConnection(strcon);
            cn.Open();
            cmd.Connection = cn;
            return cmd;
        }
    }
}
