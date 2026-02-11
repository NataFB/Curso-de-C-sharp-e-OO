using MétodosAbstratos.Entities.Enums;

namespace MétodosAbstratos.Entities
{
    // Classe abstrata: não pode ser instanciada, ou seja, não é possível criar objetos diretamente dessa classe. Ela serve como um modelo para outras classes que herdam dela.
    abstract class Shape
    {
        public Color Color { get; set; }

        // Obriga as classes filhas a receberem a cor no construtor, garantindo que todas as formas tenham uma cor definida.
        public Shape(Color color)
        {
            Color = color;
        }

        // Método abstrato: não tem implementação, é apenas a assinatura do método. As classes filhas são obrigadas a implementar esse método.
        // Os métodos abstratos são usados para definir um contrato que as classes filhas devem seguir, garantindo que todas as formas tenham um método para calcular a área, por exemplo.
        // A implementação do método Area() será diferente para cada tipo de forma (círculo, retângulo, etc.), mas todas as formas terão esse método, garantindo uma estrutura consistente.
        // Sempre que a classe tiver um método abstrato, a classe também deve ser declarada como abstrata.
        public abstract double Area();
        
    }
}
