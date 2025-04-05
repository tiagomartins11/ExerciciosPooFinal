using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Pagamentos
{
    public class ProcessadorPagamento
    {
        // Método para processar o pagamento
        public void ProcessarPagamento(Pagamento pagamento)
        {
            Console.WriteLine("Processando pagamento...");
            pagamento.Processar();
            RegistrarAuditoria(pagamento);
        }
         private void RegistrarAuditoria(Pagamento pagamento)
        {
            // Implementar lógica de auditoria
            Console.WriteLine("Registrando auditoria...");
            Console.WriteLine($"Valor: {pagamento.Valor}");
            Console.WriteLine($"Data: {pagamento.Data}");
            Console.WriteLine($"Status: {pagamento.Status}");
        }

        public void ProcessarPagamento(decimal valor, DateTime data, string status)
        {
            Console.WriteLine("Iniciando processamento de pagamento com valores...");
            Console.WriteLine($"Valor: {valor}, Data: {data}, Status: {status}");
        }

    }

}
