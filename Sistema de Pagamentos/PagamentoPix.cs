using System;
using System.Collections.Generic;
using System.Data;

namespace Sistema_de_Pagamentos
{
    public class PagamentoPix : Pagamento
    {
        private string _chavePix;
        private string _qrCode;
        public string ChavePix
        {
            get { return _chavePix; }
            set { _chavePix = value; }
        }
        
        
        
        public string QrCode
        {
            get { return _qrCode; }
            set { _qrCode = value; }
        }
        
        public PagamentoPix(decimal valor, DateTime data, string status, string chavePix, string qrCode)
            : base(valor, data, status)
        {
            _chavePix = chavePix;
            _qrCode = qrCode;
        }
        public override void ProcessarPagamento()
        {
            Console.WriteLine("Processando pagamento via Pix...");
            Console.WriteLine($"Valor: {Valor}");
            Console.WriteLine($"Data: {Data}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Chave: {_chavePix}");
            Console.WriteLine($"QR Code: {_qrCode}");
        }
        public override string GerarRecibo()
        {
            return $"Recibo de pagamento via Pix: \nValor: {Valor}\nData: {Data}\nStatus: {Status}\nChave: {_chavePix}\nQR Code: {_chavePix}";
        }
    }
}
