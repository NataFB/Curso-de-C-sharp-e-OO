using MétodosAbstratos.Entities.Enums;

namespace MétodosAbstratos.Entities
{
    // A classe Rectangle obriga a implementação do método Area() da classe Shape, pois é uma classe concreta (não abstrata).
    class Rectangle : Shape
    {

        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(Color color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }

        // A implementação do método Area() para a classe Rectangle, que calcula a área do retângulo usando a fórmula: área = largura * altura.
        public override double Area()
        {
            return Width * Height;
        }
    }
}
