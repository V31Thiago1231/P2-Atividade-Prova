using System;
using System.Collections.Generic;

namespace LojaVirtual
{
class Program
{
        static void Main(string[] args)
        {
            // Criando produtos
            var produto1 = new Produto(1, "Notebook", 3500.00m, "Eletrônicos");
            var produto2 = new Produto(2, "Mouse", 50.00m, "Periféricos");

            Console.WriteLine(produto1.Id);
            Console.WriteLine(produto1.Nome);
            Console.WriteLine(produto1.Preco);
            Console.WriteLine(produto1.Categoria);

            Console.WriteLine(produto2.Id);
            Console.WriteLine(produto2.Nome);
            Console.WriteLine(produto2.Preco);
            Console.WriteLine(produto2.Categoria);

            // Criando cliente
            var cliente = new Cliente(1, "thiago venancio", "thiago@email.com", "123.456.789-00");

             // Criando pedido usando a factory
            var pedidoFactory = new PedidoFactory();
            var pedido = pedidoFactory.CriarPedido(cliente);

            // Adicionando itens ao pedido
            pedido.AdicionarItem(produto1, 1);
            pedido.AdicionarItem(produto2, 2);

            // Aplicando descontos
            var descontoCategoria = new DescontoPorCategoriaStrategy("Eletrônicos", 10);
            var descontoQuantidade = new DescontoPorQuantidadeStrategy(2, 5);

            var descontoTotal = descontoCategoria.CalcularDesconto(pedido) +
                               descontoQuantidade.CalcularDesconto(pedido);

            // Exibindo informações do pedido
            Console.WriteLine($"Pedido #{pedido.Id}");
            Console.WriteLine($"Cliente: {pedido.Cliente.Nome}");
            Console.WriteLine($"Data: {pedido.Data}");
            Console.WriteLine("\nItens do Pedido:");
            
            foreach (var item in pedido.Itens)
            {
                Console.WriteLine($"{item.Produto.Nome} - Quantidade: {item.Quantidade} - Subtotal: R${item.Subtotal:F2}");
            }

            Console.WriteLine($"\nSubtotal: R${pedido.ValorTotal:F2}");
            Console.WriteLine($"Desconto: R${descontoTotal:F2}");
            Console.WriteLine($"Total: R${(pedido.ValorTotal - descontoTotal):F2}");
    }

}
}



   

    
