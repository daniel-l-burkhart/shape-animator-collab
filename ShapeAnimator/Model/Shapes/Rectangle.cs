using System.Drawing;
using ShapeAnimator.Model.Manager;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model.Shapes
{
    /// <summary>
    /// </summary>
    public class Rectangle : Shape
    {
        #region Constructors

        private const int RectangleMaxWidthAndHeight = 100;
        private const int RectanlgeMinWidthAndHeight = 20;

        /// <summary>
        ///     Creates a rectangle shape
        /// </summary>
        public Rectangle()
        {
            this.Sprite = new RectangleSprite(this,
                ShapeFactory.Randomizer.Next(RectanlgeMinWidthAndHeight, RectangleMaxWidthAndHeight),
                ShapeFactory.Randomizer.Next(RectanlgeMinWidthAndHeight, RectangleMaxWidthAndHeight));
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

        #endregion

        #region Methods

        /// <summary>
        ///     Areas the method.
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            double area = this.Width*this.Height;
            return area;
        }

        /// <summary>
        ///     Perimeters the method.
        /// </summary>
        /// <returns></returns>
        public override double CalculatePerimeter()
        {
            double perimeter = (this.Width*2.0) + (this.Height*2.0);
            return perimeter;
        }

        #endregion
    }
}