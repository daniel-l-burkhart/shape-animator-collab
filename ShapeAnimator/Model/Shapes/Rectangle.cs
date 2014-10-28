using System.Drawing;
using ShapeAnimator.Model.Manager;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model.Shapes
{
    /// <summary>
    /// 
    /// </summary>
    public class Rectangle : Shape
    {

        /// <summary>
        ///     Creates a rectangle shape
        /// </summary>
        public Rectangle()
        {
            this.SpeedX = ShapeFactory.Randomizer.Next(-5, 5);
            this.SpeedY = ShapeFactory.Randomizer.Next(-5, 5);
            this.Sprite = new RectangleSprite(this, ShapeFactory.Randomizer.Next(20, 100), ShapeFactory.Randomizer.Next(20, 100));
        }

        /// <summary>
        ///     Constructs a shape at specified location
        ///     Precondition: location != null
        ///     Postcondition: X == location.X; Y == location.Y
        /// </summary>
        /// <param name="location">Location to create shape</param>
        public Rectangle(Point location) : base(location)
        {
        }

        /// <summary>
        /// calculates the area based off  the specified width and height.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <returns></returns>
        public override double Area(double width, double height)
        {
            return (width*height);
        }

        /// <summary>
        /// Perimeters the specified width.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <returns></returns>
        public override double Perimeter(double width, double height)
        {
            return (2.0*width + 2.0*height);
        }
    }
}