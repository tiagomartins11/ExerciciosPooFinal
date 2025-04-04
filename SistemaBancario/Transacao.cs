namespace SistemaBancario
{
    // Enum para os tipos de transações
    public enum TipoTransacao
    {
        Deposito,
        Saque,
        Transferencia
    }

    // Classe Transacao para registrar movimentações
    public class Transacao
    {
        public DateTime DataHora { get; set; }   // Data e hora da transação
        public TipoTransacao Tipo { get; set; }   // Tipo da transação
        public decimal Valor { get; set; }        // Valor da transação
        public string Descricao { get; set; }     // Descrição da transação

        // Construtor da classe Transacao
        public Transacao(TipoTransacao tipo, decimal valor, string descricao)
        {
            DataHora = DateTime.Now; // Define a data e hora da transação
            Tipo = tipo;             // Define o tipo de transação
            Valor = valor;           // Define o valor da transação
            Descricao = descricao;   // Define a descrição da transação
        }

        // Método ToString para exibir a transação de forma legível
        public override string ToString()
        {
            return $"{DataHora} - {Tipo} de {Valor:C} - {Descricao}";
        }
    }
}