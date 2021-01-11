namespace Atividade_2.Models
{
    /****
    Classes estáticas não precisam ser instanciadas.
    No ASP.NET Core MVC, classes estáticas vivem do início 
    ao fim da execução do programa.
    Por isso, Dados deve ser usado para manipular as informações
    dos pedidos.
    Exemplos de uso:
    Dados.PedidoAtual.PropriedadeDePedido = "Algum Valor";
    Dados.PedidoAtual.MetodoDePedido();
   

    Inclua ainda uma classe chamada “Dados”, com o código a seguir
    A classe “Dados” será necessária para manipular os dados no sistema web.
    *****/
    public static class Dados
    {
        public static Pedido PedidoAtual { get; set; }
        static Dados()
        {
            PedidoAtual = new Pedido();
        }
    }
}