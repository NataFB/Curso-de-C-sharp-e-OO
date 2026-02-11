using MétodosAbstratos.Entities.Enums;
namespace MétodosAbstratos.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        // A implementação do método Area() para a classe Circle, que calcula a área do círculo usando a fórmula: área = π * raio^2.
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
