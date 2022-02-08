using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoPedido.Classes;
using ProjetoPedido.Negocios;

namespace ProjetoPedido.Classes
{
    public class CabecalhoDoPedido
    {

        private int IdCabecalhoPedido, IdPedido;

        public int IDCABECALHOPEDIDO
        {
            get { return IdCabecalhoPedido;}
            set { IdCabecalhoPedido = value; } 
        }

        public int IDPEDIDO
        {
            get { return IdPedido; }
            set { IdPedido = value; }
        }
    }
}
