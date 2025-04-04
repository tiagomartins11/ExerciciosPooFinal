using System;

namespace GestaoProdutos
{
    public class Produto
    {
        // Propriedades autoimplementadas
        public int Codigo { get; set; }
        public string Nome { get; set; }

        // Propriedades com validação
        private double preco;
        public double Preco
        {
            get => preco;
            set
            {
                if (value < 0)
                    throw new ArgumentException("O preço não pode ser negativo.");
                preco = value;
            }
        }

        private int estoque;
        public int Estoque
        {
            get => estoque;
            set
            {
                if (value < 0)
                    throw new ArgumentException("O estoque não pode ser negativo.");
                estoque = value;
            }
        }

        // Propriedade somente leitura
        public DateTime DataCadastro { get; }

        // Propriedades calculadas
        public double ValorEmEstoque => Preco * Estoque;
        public string Status => Estoque > 0 ? "Disponível" : "Indisponível";

        // Construtor completo
        public Produto(int codigo, string nome, double preco, int estoque)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("O nome não pode ser vazio.");

            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
            DataCadastro = DateTime.Now;
        }

        // Construtor com atributos essenciais
        public Produto(int codigo, string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("O nome não pode ser vazio.");

            Codigo = codigo;
            Nome = nome;
            DataCadastro = DateTime.Now;
        }

        // Construtor padrão
        public Produto()
        {
            DataCadastro = DateTime.Now;
        }
    }
}
