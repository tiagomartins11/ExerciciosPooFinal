// Classe principal para testar a funcionalidade
using SistemaBancario;

class Program
{
    static void Main(string[] args)
    {
        // Criando uma conta bancária
        ContaBancaria conta = new ContaBancaria("12345", "Tiago Martins");

        // Realizando depósitos e saques
        conta.Depositar(750.00m);
        conta.Sacar(200.0m);
        conta.Sacar(1000.0m);  // Tenta sacar mais do que o saldo disponível
        conta.Depositar(350.00m);

        // Ver o extrato da conta
        conta.VerExtrato();
    }
}