# P2-Atividade-Prova
Atividade Prova P2

COMO EXECUTAR O PROJETO NO VS CODE

Requsitos
*ter instalado a extensão C#

No Terminal Rode: "dotnet run"

Comandos Git

git clone 
git status //uso continuo
git add "para adicionar"
git add -u //para arquivos que ja existem
git commit -m "comentario"
git push origin main //Mandar pro git


COMI BRONHA E SÓ FUI PERCEBER DEPOIS, FOI MAL, ENTÃO VOU COLOCAR AQUI AS EXPLICAÇÕES DOS METÓDOS SOLIDS UTILIZADOS EM CADA PARTE DO PROJETO.

Criação do Cadastro de Produtos

1- Na criação da Classe Produto foi utilizado o Princípio da Responsabilidade Única (SRP - Single Responsibility Principle), já que sua única responsabilidade é representar um produto com seus atributos e sua validação. Já na interface foi o Princípio da Segregação de Interface (Interface Segregation Principle – ISP).

Criação do Cadastro de Clientes

2- Na criação da Classe Cliente foi utilizado o Princípio da Responsabilidade Única (SRP – Single Responsibility Principle), ja que a Classe Cliente tem uma única responsabilidade que é representar um cliente com seus dados e validar suas informações. Já na interface foi o Princípio da Segregação de Interface (ISP – Interface Segregation Principle) que define apenas as propriedades e métodos essenciais que um cliente deve implementar.

Criação de Pedidos

3 - Na Criação da Classe Pedido o principal foi Princípio Principal Aplicado: DIP – Princípio da Inversão de Dependência (Dependency Inversion Principle), já que a Classe Pedido depende das interfaces ICliente e IProduto, e não diretamente das classes concretas como Cliente ou Produto. Já na interface foi aplicado o Princípio da Segregação de Interface (ISP – Interface Segregation Principle), a interface define somente os membros essenciais para representar e operar um pedido.

Criação Relatório de Pedidos

4- Na Criação da Classe ItemPedido foi utilizado Princípio da Inversão de Dependência (Dependency Inversion Principle), a classe ItemPedido depende da interface IProduto, e não de uma classe concreta como Produto.

Criação Aplicação de Descontos

5- Foi criada a Classe DescontoPorCategoria, foi utilizado Princípio Aberto/Fechado
(Open/Closed Principle), A classe implementa a interface IDescontoStrategy, o que permite que novas estratégias de desconto sejam adicionadas sem precisar alterar a lógica existente.

6- Já na Classe DescontoPorQuantidade, foi utilizado OCP – Princípio Aberto/Fechado (Open/Closed Principle), essa classe é uma implementação da interface IDescontoStrategy.

*PedidoFactory

7- Foi criada a Classe PedidoFactory para com validação de cliente e geração de ID. Foi utilizado Princípio da Inversão de Dependência
(Dependency Inversion Principle), retorna um objeto do tipo IPedido e recebe como parâmetro um ICliente.








