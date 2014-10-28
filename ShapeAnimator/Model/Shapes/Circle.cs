using System;
using System.Drawing;
using ShapeAnimator.Model.Manager;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model.Shapes
{
    /// <summary>
    ///     Creates a circle shape
    /// </summary>
    public class Circle : Shape
    {

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Circle" /> class.
        /// </summary>
        public Circle()
        {
            this.SpeedX = ShapeFactory.Randomizer.Next(-5, 5);
            this.SpeedY = ShapeFactory.Randomizer.Next(-5, 5);
            this.Sprite = new CircleSprite(this, ShapeFactory.Randomizer.Next(20, 100), ShapeFactory.Randomizer.Next(20, 100));
        }

        /// <summary>
        ///     Constructs a shape at specified location
        ///     Precondition: location != null
        ///     Postcondition: X == location.X; Y == location.Y
        /// </summary>
        /// <param name="location">Location to create shape</param>
        public Circle(Point location) : base(location)
        {
        }

        #endregion

        /// <summary>
        /// calculates the area based off  the specified width and height.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <returns></returns>
        public override double Area(double width, double height)
        {
            double radius = (width/2.0);
            return (Math.PI*radius*radius);
        }

        /// <summary>
        /// Perimeters the specified width.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <returns></returns>
        public override double Perimeter(double width, double height)
        {
            return (Math.PI*width);
        }
    }
}