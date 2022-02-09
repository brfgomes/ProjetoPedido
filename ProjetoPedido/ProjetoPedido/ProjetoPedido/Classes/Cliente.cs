using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPedido.Classes
{
    public class Cliente

    {
        ~Cliente()
        {}

        private int IdCliente;
        private string NomeCliente = null;

        public int IDCLIENTE
        {
            get { return IdCliente; }
            set { IdCliente = value;}
        }

        public string NOMECLIENTE
        {
            get { return NomeCliente; }
            set { NomeCliente = value; }
        }
    }
}
