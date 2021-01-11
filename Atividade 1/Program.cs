
//Crie um programa em que seja possível informar vários itens de um pedido.
using System;
using System.Collections.Generic;
namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string respostaItem;
            Pedido pedidos = new Pedido(); // pedido 1, pedido 2, pedido N

            //criar outro pedido
            do
            {
                ItemPedido item = new ItemPedido();
                // O usuário informa descrição, valor e quantidade.
                Console.WriteLine("Informe o item para seu pedido: ");
                item.descricao = Console.ReadLine();

                Console.WriteLine("Informe o valor do seu item: ");
                item.valor_unitario = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe a quantidade do seu item: ");
                item.quantidade = int.Parse(Console.ReadLine());

                pedidos.adicionar(item);
                // O programa pergunta se deseja inserir novo pedido.
                Console.WriteLine("Deseja solicitar outro pedido? (s/n) ");
                respostaItem = Console.ReadLine();

                if (respostaItem == "n")
                {
                    Console.WriteLine("Total do seu pedido: " + pedidos.totaliza());
                }
                // Se sim, usuário pode incluir novo pedido.               
            } while (respostaItem == "s");

        }
    }
}
