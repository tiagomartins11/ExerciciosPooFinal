using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Pagamentos
{
    abstract public class Pagamento
    {
        private decimal _valor;
        private DateTime _data;
        private string _status;


        public decimal Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }


        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }


        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
    

    public Pagamento(decimal valor, DateTime data, string status)
        {
            _valor = valor;
            _data = data;
            _status = status;
        }
        public abstract void ProcessarPagamento();


        public abstract string GerarRecibo();

        internal void Processar()
        {
            
        }
    }
}