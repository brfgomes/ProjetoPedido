using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPedido.Classes
{
    public class Pedido
    {


        ~Pedido()
        { }

        private int IdPedido;
        private int IdCliente;
        private int IdPedidoItem;
        private double TotalPedido;

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

        


    }

}
