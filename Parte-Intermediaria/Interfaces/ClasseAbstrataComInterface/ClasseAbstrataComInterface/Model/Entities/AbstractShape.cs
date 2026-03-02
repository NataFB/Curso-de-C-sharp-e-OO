using ClasseAbstrataComInterface.Model.Enums;

namespace ClasseAbstrataComInterface.Model.Entities
{
    abstract class AbstractShape : IShape
    {

        public Color Color { get; set; }

        public abstract double Area();
    }
}
