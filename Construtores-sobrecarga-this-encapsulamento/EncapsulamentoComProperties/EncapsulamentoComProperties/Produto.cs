using System.Globalization;
namespace EncapsulamentoComProperties
{
    class Produto
    {
        // AutoProperties x Properties com campo de apoio
        // AutoProperties são mais simples, mas não permitem lógica de validação no set, nem lógica adicional no get
        // Properties com campo de apoio permitem lógica de validação no set, e lógica adicional no get

        private string _nome; // Não tem como fazer auto Properties por conta da lógica de validação no set
        public double Preco { get; private set; } // auto propriedade com acesso restrito para set
        public int Quantidade { get; private set; } // auto propriedade com acesso restrito para set
        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
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
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
