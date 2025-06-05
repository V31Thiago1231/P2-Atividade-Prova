using System;
using System.Collections.Generic;

namespace LojaVirtual
{
class Program
{
        static void Main(string[] args)
        {
            // Criando produtos
            var produto1 = new Produto
            {
                Id = 1,
                Nome = "Notebook",
                Preco = 3500.00m,
                Categoria = "Eletrônicos"
            };

            var produto2 = new Produto
            {
                Id = 2,
                Nome = "Mouse",
                Preco = 50.00m,
                Categoria = "Acessórios"
            };
            var produto3 = new Produto
            {
                Id = 3,
                Nome = "Fone",
                Preco = 70.00m,
                Categoria = "Acessórios"
            };

            // Criando cliente
            var cliente = new Cliente
            {
                Id = 1,
                Nome = "João Silva",
                Email = "joao@email.com",
                CPF = "12345678900"
            };
    }

}
}



   

    
