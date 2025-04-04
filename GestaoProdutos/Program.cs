using System;

namespace GestaoProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Produto produto1 = new Produto(1, "Notebook", 1500.00, 10);
                Console.WriteLine($"Produto 1 - Nome: {produto1.Nome}, Preço: {produto1.Preco}, Estoque: {produto1.Estoque}, Valor em Estoque: {produto1.ValorEmEstoque}, Status: {produto1.Status}");

                Produto produto2 = new Produto(2, "Mouse");
                produto2.Preco = 50.00;
                produto2.Estoque = 100;
                Console.WriteLine($"Produto 2 - Nome: {produto2.Nome}, Preço: {produto2.Preco}, Estoque: {produto2.Estoque}, Valor em Estoque: {produto2.ValorEmEstoque}, Status: {produto2.Status}");

                // Teste de validação
                Produto produto3 = new Produto(3, "Teclado", -100.00, 20); // Deve lançar exceção
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
