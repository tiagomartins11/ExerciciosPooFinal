using System;

namespace Sistema_de_Pagamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando instâncias de diferentes tipos de pagamento
            Pagamento pagamentoCartao = new PagamentoCartao(100.50m, DateTime.Now, "Aprovado", "Visa", "1234 5678 9876 5432", 12);
            Pagamento pagamentoBoleto = new PagamentoBoleto(50.75m, DateTime.Now, "Pago", "1234567890", DateTime.Now.AddDays(5));
            Pagamento pagamentoPix = new PagamentoPix(200.00m, DateTime.Now, "Aprovado", "chave@pix.com", "QRCode123");

            // Criando o processador de pagamento
            ProcessadorPagamento processador = new ProcessadorPagamento();

            // Processando diferentes tipos de pagamento
            processador.ProcessarPagamento(pagamentoCartao);
            Console.WriteLine(pagamentoCartao.GerarRecibo());

            Console.WriteLine("\n---");

            processador.ProcessarPagamento(pagamentoBoleto);
            Console.WriteLine(pagamentoBoleto.GerarRecibo());

            Console.WriteLine("\n---");

            processador.ProcessarPagamento(pagamentoPix);
            Console.WriteLine(pagamentoPix.GerarRecibo());

            Console.WriteLine("\n---");

            // Sobrecarga do método ProcessarPagamento
            processador.ProcessarPagamento(150.00m, DateTime.Now, "Pendente");
        }
    }
}
