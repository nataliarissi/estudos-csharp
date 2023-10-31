using BancoInterface.Enum;

namespace BancoInterface.Entities.Shapes{
    abstract class AbstractShape : IShape{
        public Color Color { get; set; }

        public abstract double Area();
    }
}