using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRH
{
    public class Desenvolvedor : Funcionario
    {
        private string _especialidade;
        private string _nivel;


        public string Especialidade
        {
            get { return _especialidade; }
            set { _especialidade = value; }
        }

        public string Nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }

        public Desenvolvedor(string nome, string cpf, String dataAdmissao, decimal salarioBase, string especialidade, string nivel)
            : base(nome, cpf, dataAdmissao, salarioBase)
        {
            _especialidade = especialidade;
            _nivel = nivel;
        }


        public override decimal CalcularSalario()
        {
            decimal _salario = base.CalcularSalario();
            if (_nivel == "Sênior")
            {
                return base.CalcularSalario() * _salario; // Aumento de 20% para desenvolvedores seniores
            }
            else if (_nivel == "Pleno")
            {
                return base.CalcularSalario() * _salario; // Aumento de 10% para desenvolvedores plenos
            }
            else if (_nivel == "Júnior")
            {
                return base.CalcularSalario() * _salario; // Aumento de 5% para desenvolvedores juniores
            }

            return _salario;
        }

        public override void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {Cpf}");
            Console.WriteLine($"Data de Admissão: {DataAdmissao}");
            Console.WriteLine($"Salário Base: {SalarioBase:C}");
            Console.WriteLine($"Especialidade: {Especialidade}");
            Console.WriteLine($"Nível: {Nivel}");
            Console.WriteLine($"Salário Calculado: {CalcularSalario():C}");
        }

    }
}
