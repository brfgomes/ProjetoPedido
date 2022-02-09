using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPedido.Classes
{
    public class Pedido
    {
        private int IdPedido = 0;
        private int IdCliente = 0;
        private int IdPedidoItem = 0;
        private double TotalPedido = 0;
        public DateTime DataPedido; 

        public int IDPEDIDO
        {

            get { return IdPedido; }
            set { IdPedido = value; }

        }

        public int IDCLIENTE
        {

            get { return IdCliente; }
            set { IdCliente = value; }

        }

        public int IDPEDIDOITEM
        {

            get { return IdPedidoItem; }
            set { IdPedidoItem = value; }

        }

        public double TOTALPEDIDO
        {

            get { return TotalPedido; }
            set { TotalPedido = value; }

        }

        public DateTime DATAPEDIDO
        {
            get { return DataPedido; }
            set { DataPedido = value; }
        }




    }

}
