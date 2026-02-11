using MétodosAbstratos.Entities;
using MétodosAbstratos.Entities.Enums;
using System.Globalization;

namespace MétodosAbstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lista para armazenar as formas criadas pelo usuário. A lista é do tipo Shape, o que permite armazenar objetos de diferentes
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            // Leitura dos dados das formas
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char shapeType = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine(), true); // true para ignorar maiúsculas/minúsculas  

                // Criação da forma com base no tipo e adição à lista
                if (shapeType == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Rectangle(color, width, height));
                }
                else if (shapeType == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(color, radius));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            // Cálculo e exibição das áreas
            // Por ser uma lista de Shape, o método Area() chamado em cada objeto será o método específico da classe (Rectangle ou Circle), graças ao polimorfismo.
            // Por isso o uso do método abstrato Area() na classe Shape, que é implementado de forma diferente em cada subclasse (Rectangle e Circle).
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}