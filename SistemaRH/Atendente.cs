using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRH
{
    public class Atendente : Funcionario
    {
        private string _metaAtendimento;
        private string _comisao;
        public string MetaAtendimento
        {
            get { return _metaAtendimento; }
            set { _metaAtendimento = value; }
        }
        public string Comissao
        {
            get { return _comisao; }
            set { _comisao = value; }
        }


        public Atendente(string nome, string cpf, String dataAdmissao, decimal salarioBase, string metaAtendimento, string comisao)
            : base(nome, cpf, dataAdmissao, salarioBase)
        {
            _metaAtendimento = metaAtendimento;
            _comisao = comisao;
        }

        public override decimal CalcularSalario()
        {
            decimal salario = base.CalcularSalario();

            
           if (_metaAtendimento == "Alcançada")
            {
                salario += 0.1m * SalarioBase; // Aumento de 10% se a meta for alcançada
            }
            else if (_metaAtendimento == "Não Alcançada")
            {
                salario -= 0.05m * SalarioBase; // Redução de 5% se a meta não for alcançada
            }

            return salario;
        }

        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Meta de Atendimento: {MetaAtendimento}");
            Console.WriteLine($"Comissão: {Comissao:C}");
        }
    }
}
