using SistemaRH;

class Program
{
    static void Main(string[] args)
    {
        // Criando uma lista de funcionários
        List<Funcionario> funcionarios = new List<Funcionario>
            {
                new Desenvolvedor("Carlos", "12345678900", "2019-03-15", 5000, "Backend", "Pleno"),
                new Gerente("Ana", "98765432100", "2018-07-10", 8000, "TI", 2000),
                new Atendente("João", "45678912300", "2020-06-01", 2000, "Alcancada", "100")
            };

        // Processando a folha de pagamento e exibindo dados
        foreach (var funcionario in funcionarios)
        {
            funcionario.ExibirDados();
            Console.WriteLine($"Salário Calculado: {funcionario.CalcularSalario():C}\n");
        }
    }
}
