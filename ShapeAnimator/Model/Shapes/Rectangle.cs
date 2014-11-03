using System;
using System.Drawing;
using ShapeAnimator.Model.Manager;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model.Shapes
{
    /// <summary>
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
            this.Sprite = new RectangleSprite(this, ShapeFactory.Randomizer.Next(20, 100),
                ShapeFactory.Randomizer.Next(20, 100));
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
        ///     Areas the method.
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            double area = this.Width*this.Height;
            return Math.Round(area, 3);
        }

        /// <summary>
        ///     Perimeters the method.
        /// </summary>
        /// <returns></returns>
        public override double CalculatePerimeter()
        {
            const double perimeterFactor = 2.0;
            double perimeter = (this.Width*perimeterFactor) + (this.Height*perimeterFactor);
            return Math.Round(perimeter, 3);
        }
    }
}