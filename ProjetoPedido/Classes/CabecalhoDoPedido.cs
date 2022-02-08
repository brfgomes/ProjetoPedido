using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPedido.Negocios
{
    public class CriaPedido
    {
        public void InserirPedido()
        {
            //INSERIR CLIENTE
            Classes.Cliente cliente = new Classes.Cliente();

            cliente.IDCLIENTE = 1;
            cliente.NOMECLIENTE = "Bruno";

            //INSERIR PRODUTO
            List<Classes.Produto> listaprodutos = new List<Classes.Produto>();

            Classes.Produto produto1 = new Classes.Produto();
            produto1.IDPRODUTO = 1;
            produto1.NOMEPRODUTO = "Bola";
            produto1.PRECOPRODUTO = 49.90;
            produto1.QNTPRODUTO = 10;
            listaprodutos.Add(produto1);

            Classes.Produto produto2 = new Classes.Produto();
            produto2.IDPRODUTO = 2;
            produto2.NOMEPRODUTO = "Chuteira";
            produto2.PRECOPRODUTO = 149.90;
            produto2.QNTPRODUTO = 5;
            listaprodutos.Add(produto2);

            Classes.Produto produto3 = new Classes.Produto();
            produto3.IDPRODUTO = 3;
            produto3.NOMEPRODUTO = "Camiseta";
            produto3.PRECOPRODUTO = 60.00;
            produto3.QNTPRODUTO = 20;
            listaprodutos.Add(produto3);

            //INSERIR PEDIDO_ITENS
            Classes.PedidoItem pedidoitem = new Classes.PedidoItem();

            pedidoitem.IDPEDIDOITEM = 1;
            pedidoitem.QNTPROD1 = 1;
            pedidoitem.QNTPROD2 = 1;
            pedidoitem.QNTPROD3 = 0;

            //tirar do estoque os produto que serão comprados
            foreach (Classes.Produto produto in listaprodutos)
            {
                int qnt1 = produto1.QNTPRODUTO - pedidoitem.QNTPROD1;
                int qnt2 = produto2.QNTPRODUTO - pedidoitem.QNTPROD2;
                int qnt3 = produto3.QNTPRODUTO - pedidoitem.QNTPROD3;

                produto1.QNTPRODUTO = qnt1;
                produto2.QNTPRODUTO = qnt2;
                produto3.QNTPRODUTO = qnt3;
            };

            //INSERIR PEDIDO
            Classes.Pedido pedido = new Classes.Pedido();
            pedido.IDPEDIDO = 1;
            pedido.IDCLIENTE = 1;
            pedido.IDPEDIDOITEM = 1;
            pedido.DATAPEDIDO = DateTime.Now;
            double total = (pedidoitem.QNTPROD1 * produto1.PRECOPRODUTO) +
                           (pedidoitem.QNTPROD2 * produto2.PRECOPRODUTO) +
                           (pedidoitem.QNTPROD3 * produto3.PRECOPRODUTO);

            pedido.TOTALPEDIDO = (total);


            //INSERIR O CABECALHO FINAL DO PEDIDO.
            
            Classes.CabecalhoDoPedido CabecaPedido = new Classes.CabecalhoDoPedido();
            CabecaPedido.IDCABECALHOPEDIDO = 1;
            CabecaPedido.IDPEDIDO = 1;
            

            //agora no caso só bastaria EXIBIR em um frm, ou no console chamando a classe do cabecalhopedido






        }

    }
}
