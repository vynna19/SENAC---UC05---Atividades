using System.Collections.Generic;

namespace Atividade_1
{
    public class Pedido
    {
        //ponto 1: Criar uma lista privada com o item Pedido. OK
        
        private List<ItemPedido> lista = new List<ItemPedido>();

        //ponto 2: Metodo para incluir itemPedido
        public void adicionar(ItemPedido pedido)
        { 
            lista.Add(pedido);
        }
  
        //ponto 2.1: Criar uma classe “Pedido” com uma propriedade privada do tipo lista (List<>) de “ItemPedido” e métodos para incluir item no pedido e para totalizar o pedido – este, retorna um valor Double com o total de todos os itens da lista.
        public double totaliza()
        {
            double total = 0;
                        
            for(int i = 0; i < lista.Count; i++){
                total = total + lista[i].valor_unitario;
            }

            return total;
            
        }

        //ponto 3: Inclua também um construtor em “Pedido” para instanciar uma nova lista na propriedade criada.
        
}
}