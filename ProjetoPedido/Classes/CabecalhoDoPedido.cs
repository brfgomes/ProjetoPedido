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

        private int IdCabecalhoPedido, IdCliente, IdProduto, IdPedido, IdPedidoItem;
        private DateTime DataCompra;

        public int IDCABECALHOPEDIDO
        {
                get { return IdCabecalhoPedido;}
                set { IdCabecalhoPedido = value; }
        }

        public int IDCLIENTE
        {
            get { return IdCliente; }
            set { IdCliente = value; }
        }

        public int IDPRODUTO
        {
            get { return IdProduto; }
            set { IdProduto = value; }
        }

        public int IDPEDIDO
        {
            get { return IdPedido; }
            set { IdPedido = value; }
        }

        public int IDPEDIDOITEM
        {
            get { return IdPedidoItem; }
            set { IdPedidoItem = value; }
        }
    }
}