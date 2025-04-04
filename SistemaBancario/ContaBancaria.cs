namespace SistemaBancario
{
    public class ContaBancaria
    {
        private decimal _saldo;
        private string _numeroConta;
        private string _titular;
        private List<Transacao> _transacoes;

        //metodo contrutor que pega as informaçoes da classe ContaBancaria que tem atributos privados
        public ContaBancaria(string numeroConta, string titular)
        {
            _titular = titular;
            _numeroConta = numeroConta;
            _saldo = 0.0m;  // o 'm' é porque o atributo é do tipo decimal
            _transacoes = new List<Transacao>();
        }

        //Não faz sentido
        //public string NumeroConta
        //{
        //    get { return _numeroConta; }
        //}

        //public string Titular
        //{
        //    get { return _titular; }
        //}

        //public decimal Saldo
        //{
        //    get { return _saldo; }
        //}

        //metodo para depositar dinheiro na conta
        public void Depositar(decimal valor)
        {

            if (valor <= 0) // Não é possível depositar valores negativos ou nulos
            {

                Console.WriteLine("Não é possível depositar valores negativos ou nulos");

            }
            else
            {

                _saldo = _saldo + valor;
                Console.WriteLine("Deposito realizado com sucesso");
                _transacoes.Add(new Transacao(TipoTransacao.Deposito, valor, "Depósito realizado"));

            }
        }

        public void Sacar(decimal valor)
        {

            if (valor <= 0) // Não é possível sacar valores negativos ou nulos 
            {

                Console.WriteLine("Não é possível sacar valores negativos ou nulos");
            }
            else
            {
                if (_saldo < valor)
                {
                    Console.WriteLine("Sem saldo para sacar");
                    _transacoes.Add(new Transacao(TipoTransacao.Saque, valor, "Saque não realizado por motivo de saldo insuficiente"));

                }
                else
                {
                    _saldo = _saldo - valor;
                    Console.WriteLine("Saque realizado no valor de: " + valor);
                    _transacoes.Add(new Transacao(TipoTransacao.Saque, valor, "Saque realizado"));
                }
            }
        }

        public void VerExtrato()
        {
            if (_transacoes.Count == 0)
            {
                Console.WriteLine("Nenhuma transação realizada até o momento.");
            }
            else
            {
                Console.WriteLine("Histórico de Transações:");
                foreach (var transacao in _transacoes)
                {
                    Console.WriteLine(transacao);
                }
            }
        }
    }

}


