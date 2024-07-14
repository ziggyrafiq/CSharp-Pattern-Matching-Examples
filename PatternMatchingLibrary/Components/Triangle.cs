
using PatternMatchingLibrary.Components.Base;

namespace PatternMatchingLibrary.Components
{
    public class Triangle: Shape, IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public string ShapeType => "Triangle";
        public override double Area()
        {
            return Base * Height;
        }
        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }
    }
}
