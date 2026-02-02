// this serve para referenciar o proprio objeto da classe. Usos comuns:
// 1. Diferenciar atributos e parametros quando eles possuem o mesmo nome
// 2. Chamar outro construtor da mesma classe
//Passar o proprio objeto como argumento na chamada de um método ou construtor

using System.Globalization;
namespace UtilizandoThis 
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            Quantidade = 0;
        }
        public Produto(string Nome, double preco) : this() // chama o construtor ja existente, nesse caso o construtor padrão
        {
            this.Nome = Nome; // o this diferencia o atributo do parametro
            Preco = preco;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco) // chama o construtor ja existente com dois parametros
        {
            Quantidade = quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}