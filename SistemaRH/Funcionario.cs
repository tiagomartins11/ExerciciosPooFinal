using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRH
{
    public class Funcionario
    {
        private string _nome;
        private string _cpf;
        private string _dataAdmisao;
        private decimal _salarioBase;


        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        public String DataAdmissao
        {
            get { return _dataAdmisao; }
            set { _dataAdmisao = value; }
        }
        public decimal SalarioBase
        {
            get { return _salarioBase; }
            set { _salarioBase = value; }
        }

        public Funcionario(string nome, string cpf, String dataAdmisao, decimal salarioBase)
        {
            _nome = nome;
            _cpf = cpf;
            _dataAdmisao = dataAdmisao;
            _salarioBase = salarioBase;
        }

        public virtual decimal CalcularSalario()
        {
            // Implementar lógica de cálculo de salário base
            // Exemplo: return _salarioBase * 1.1m; // Aumento de 10%
            return _salarioBase;
        }
        
        
        public virtual void ExibirDados()
        {
           
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {Cpf}");
            Console.WriteLine($"Data de Admissão: {DataAdmissao}");
            Console.WriteLine($"Salário Base: {SalarioBase:C}");
        }
    

    }
}
