using System;
using System.Drawing;
using ShapeAnimator.Model.Shapes;

namespace ShapeAnimator.View.Shapes
{
    /// <summary>
    ///     Responsible for drawing the rectangle sprite on the screen.
    /// </summary>
    internal class RectangleSprite : ShapeSprite
    {
        private const double PerimeterFactor = 2.0;

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="RectangleSprite" /> class.
        /// </summary>
        /// <param name="shape">The shape.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <exception cref="System.ArgumentNullException">shape</exception>
        public RectangleSprite(Shape shape, int width, int height) : base(shape, width, height)
        {
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Draws a shape.
        /// </summary>
        /// <param name="graphics">The graphics.</param>
        /// <exception cref="System.ArgumentNullException">g</exception>
        public override void Paint(Graphics graphics)
        {
            if (graphics == null)
            {
                throw new ArgumentNullException("graphics");
            }
            var yellowBrush = new SolidBrush(this.RandomizedColor);
            graphics.FillRectangle(yellowBrush, this.X, this.Y, this.Width, this.Height);
        }

        /// <summary>
        ///     Areas this instance.
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return (this.Width*this.Height);
        }

        /// <summary>
        ///     Perimeters this instance.
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return ((PerimeterFactor*this.Width) + (PerimeterFactor*this.Height));
        }

        #endregion
    }
}