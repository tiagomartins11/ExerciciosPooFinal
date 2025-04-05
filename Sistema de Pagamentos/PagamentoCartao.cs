using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Pagamentos
{
    public class PagamentoCartao : Pagamento
    {
        private string _bandeira;
        private string _numeroCartao;
        private decimal _parcelas;

        public string Bandeira
        {
            get { return _bandeira; }
            set { _bandeira = value; }
        }
        public string NumeroCartao
        {
            get { return _numeroCartao; }
            set { _numeroCartao = value; }
        }
        public decimal Parcelas
        {
            get { return _parcelas; }
            set { _parcelas = value; }
        }
        public PagamentoCartao(decimal valor, DateTime data, string status, string bandeira, string numeroCartao, decimal parcelas)
            : base(valor, data, status)
        {
            _bandeira = bandeira;
            _numeroCartao = numeroCartao;
            _parcelas = parcelas;
        }

        public override void ProcessarPagamento()
        {
            Console.WriteLine("Processando pagamento com cartão...");
            Console.WriteLine($"Valor: {Valor}");
            Console.WriteLine($"Data: {Data}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Bandeira: {Bandeira}");
            Console.WriteLine($"Número do Cartão: {NumeroCartao}");
            Console.WriteLine($"Parcelas: {Parcelas}");
        }

        public override string GerarRecibo()
        {
            return $"Recibo de pagamento com cartão: \nValor: {Valor}\nData: {Data}\nStatus: {Status}\nBandeira: {Bandeira}\nNúmero do Cartão: {NumeroCartao}\nParcelas: {Parcelas}";
        }
    }
}
