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

        private const int CircleMaxDiameter = 100;
        private const int CircleMinDiameter = 20;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Circle" /> class.
        /// </summary>
        public Circle()
        {
            int circleDiameter = ShapeFactory.Randomizer.Next(CircleMinDiameter, CircleMaxDiameter);
            this.Sprite = new CircleSprite(this, circleDiameter, circleDiameter);
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

        #region Methods

        /// <summary>
        ///     Calculates the area.
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            double radius = this.Width/2.0;
            double area = (Math.PI*radius*radius);
            return area;
        }

        /// <summary>
        ///     Calculates the perimeter.
        /// </summary>
        /// <returns></returns>
        public override double CalculatePerimeter()
        {
            double perimeter = Math.PI*this.Width;
            return perimeter;
        }

        #endregion
    }
}