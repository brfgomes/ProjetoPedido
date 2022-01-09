using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPedido.Classes
{
    public class Produto
    {

        ~Produto()
        { }

        private int IdProduto;
        private string NomeProduto = null;
        private double PrecoProduto;
        private int QntProduto;

        public int IDPRODUTO
        {
            get { return IdProduto; }
            set { IdProduto = value; }
        }

        public string NOMEPRODUTO
        {
            get { return NomeProduto; }
            set { NomeProduto = value; }
        }

        public double PRECOPRODUTO
        {
            get { return PrecoProduto; }
            set { PrecoProduto = value; }
        }

        public int QNTPRODUTO
        {
            get { return QntProduto; }
            set { QntProduto = value; }
        }

    }
}
