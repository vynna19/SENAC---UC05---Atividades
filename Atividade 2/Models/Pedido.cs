
using System.Collections.Generic;

//Inclua no projeto, na pasta Models, as classes ItemPedido e Pedido usadas no projeto anterior. Cuidado com os namespaces.

namespace Atividade_2.Models
{
    public class Pedido
    {
        //ponto 1: Criar uma lista privada com o item Pedido. OK
        private static List<ItemPedido> lista = new List<ItemPedido>();

        //ponto 2: Metodo para incluir itemPedido
        public void adicionar(ItemPedido pedido)
        {
            lista.Add(pedido);
        }

        //ponto 2.1: Criar uma classe “Pedido” com uma propriedade privada do tipo lista (List<>) de “ItemPedido” e métodos para incluir item no pedido e para totalizar o pedido – este, retorna um valor Double com o total de todos os itens da lista.
        public static double totaliza()
        {
            double total = 0;

            for (int i = 0; i < lista.Count; i++)
            {
                total = total + lista[i].Valor;
            }
            return total;
        }

        public  List<ItemPedido> Listar()
        {
            return lista;
        }
    }
}