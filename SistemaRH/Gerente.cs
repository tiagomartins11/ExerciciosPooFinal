using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRH
{
    public class Gerente : Funcionario
    {
        private string _equipe;
        private decimal _bonusResultado;
        public string Departamento
        {
            get { return _equipe; }
            set { _equipe = value; }
        }
        public decimal Bonus
        {
            get { return _bonusResultado; }
            set { _bonusResultado = value; }
        }
        public Gerente(string nome, string cpf, String dataAdmissao, decimal salarioBase, string departamento, decimal bonus)
            : base(nome, cpf, dataAdmissao, salarioBase)
        {
            _equipe = departamento;
            _bonusResultado = bonus;
        }
        public override decimal CalcularSalario()
        {
            decimal salario = base.CalcularSalario();
            salario += Bonus; // Adicionando bônus ao salário base
            return salario;
        }
        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Equipe: {_equipe}");
            Console.WriteLine($"Bônus: {_bonusResultado:C}");
        }
    }
    
    
}
