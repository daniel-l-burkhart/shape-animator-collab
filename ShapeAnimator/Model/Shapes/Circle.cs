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
        #region Constants

        private const int ShapeHeight = 100;
        private const int ShapeWidth = 100;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Circle" /> class.
        /// </summary>
        public Circle()
        {
            this.Direction = DirectionRandomizer.GetRandomDirection();
            this.SpriteSpeed = ShapeFactory.Randomizer.Next(1, 5);
            this.Sprite = new CircleSprite(this, ShapeWidth, ShapeHeight);
            this.IsCircle = true;
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