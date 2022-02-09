using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPedido.Classes
{
    public class PedidoItem
    {

        ~PedidoItem()
        { }

        private int IdPedidoItem;
        private int IdProduto;
        private int QntProd1;
        private int QntProd2;
        private int QntProd3;

        public int IDPEDIDOITEM
        {
            get { return IdPedidoItem; }
            set { IdPedidoItem = value; }
        }

        public int IDPRODUTO
        {
            get { return IdProduto; }
            set { IdProduto = value; }
        }

        public int QNTPROD1
        {
            get { return QntProd1; }
            set { QntProd1 = value;}
        }

        public int QNTPROD2
        {
            get { return QntProd2; }
            set { QntProd2 = value; }
        }

        public int QNTPROD3
        {
            get { return QntProd3; }
            set { QntProd3 = value; }
        }
    }
}
