using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPedido
{
    class Program
    {

        static void Main()
        {
            //INSERIR CLIENTE
            List<Classes.Cliente> clientes = new List<Classes.Cliente>();
            Classes.Cliente cliente = new Classes.Cliente();

            cliente.IDCLIENTE = 1;
            cliente.NOMECLIENTE = "Bruno";
            clientes.Add(cliente);

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
            List<Classes.PedidoItem> pedidoitems = new List<Classes.PedidoItem>();
            Classes.PedidoItem pedidoitem = new Classes.PedidoItem();
            pedidoitem.IDPEDIDOITEM = 1;
            pedidoitem.QNTPROD1 = 1;
            pedidoitem.QNTPROD2 = 1;
            pedidoitem.QNTPROD3 = 0;

            pedidoitems.Add(pedidoitem);

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
            List<Classes.Pedido> pedidos = new List<Classes.Pedido>();
            Classes.Pedido pedido = new Classes.Pedido();
            pedido.IDPEDIDO = 1;
            pedido.IDCLIENTE = 1;
            pedido.IDPEDIDOITEM = 1;
            pedido.DATAPEDIDO = DateTime.Now;
            double total = (pedidoitem.QNTPROD1 * produto1.PRECOPRODUTO) +
                           (pedidoitem.QNTPROD2 * produto2.PRECOPRODUTO) +
                           (pedidoitem.QNTPROD3 * produto3.PRECOPRODUTO);

            pedido.TOTALPEDIDO = (total);

            pedidos.Add(pedido);

            //INSERIR O CABECALHO FINAL DO PEDIDO.
            
            Classes.CabecalhoDoPedido CabecaPedido = new Classes.CabecalhoDoPedido();
            CabecaPedido.IDCABECALHOPEDIDO = 1;
            CabecaPedido.IDPEDIDO = 1;

            //puxar dados do pedido para exibir aki

            //Cliente

            Classes.Cliente clienteEscolhido = clientes.Find(cliente => cliente.IDCLIENTE == pedido.IDCLIENTE);

            if (clienteEscolhido == null)
            {
                Console.WriteLine("Cliente, não encontrado!");
            }
            else {
                Console.WriteLine($"Nome do Cliente: {clienteEscolhido.NOMECLIENTE}");
            }

            //Produtos

            Classes.PedidoItem quantidadeProduto = pedidoitems.Find(pedidoitem => pedidoitem.IDPEDIDOITEM == pedido.IDPEDIDOITEM);

            if (quantidadeProduto.QNTPROD1 == 0 && quantidadeProduto.QNTPROD2 == 0 && quantidadeProduto.QNTPROD3 == 0)
            {
                Console.WriteLine("Produtos não encontrados!");
            }
            //prod1
            if (quantidadeProduto.QNTPROD1 == 0)
            {
                Console.WriteLine("");
            } 
            else
            {
                Console.WriteLine($"Nome do Produto: {produto1.NOMEPRODUTO} | {quantidadeProduto.QNTPROD1} Unidades.");
            }
            //prod2
            if (quantidadeProduto.QNTPROD2 == 0)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine($"Nome do Produto: {produto2.NOMEPRODUTO} | {quantidadeProduto.QNTPROD2} Unidade.");
            }
            //prod3
            if (quantidadeProduto.QNTPROD3 == 0)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine($"Nome do Produto: {produto3.NOMEPRODUTO} | {quantidadeProduto.QNTPROD3} Unidade");
            }

            //total do pedido

            if (pedido.TOTALPEDIDO == 0)
            {
                Console.WriteLine("Erro, Não tem nenhum produto adicionado ao seu pedido.");
            } else
            {
                Console.WriteLine($"Total do Pedido: R${pedido.TOTALPEDIDO}");
            }

            //data da compra

            Console.WriteLine($"Data da Compra: {pedido.DATAPEDIDO}");

        }

    }
}
