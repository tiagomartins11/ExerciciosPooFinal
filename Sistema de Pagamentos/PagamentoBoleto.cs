using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Pagamentos
{
    public class PagamentoBoleto : Pagamento
    {
        private string _codigoBarras;
        private DateTime _dataVencimento;

        public string CodigoBarras
        {
            get { return _codigoBarras; }
            set { _codigoBarras = value; }
        }

        public DateTime DataVencimento
        {
            get { return _dataVencimento; }
            set { _dataVencimento = value; }
        }

        public PagamentoBoleto(decimal valor, DateTime data, string status, string codigoBarras, DateTime dataVencimento)
            : base(valor, data, status)
        {
            _codigoBarras = codigoBarras;
            _dataVencimento = dataVencimento;
        }

        public override void ProcessarPagamento()
        {
            Console.WriteLine("Processando pagamento via boleto...");
            Console.WriteLine($"Valor: {Valor}");
            Console.WriteLine($"Data: {Data}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Código de Barras: {CodigoBarras}");
            Console.WriteLine($"Data de Vencimento: {DataVencimento}");
        }

        public override string GerarRecibo()
        {
            return $"Recibo de pagamento via boleto: \nValor: {Valor}\nData: {Data}\nStatus: {Status}\nCódigo de Barras: {CodigoBarras}\nData de Vencimento: {DataVencimento}";

        }
    }
}
