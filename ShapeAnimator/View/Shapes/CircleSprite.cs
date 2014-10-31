using System;
using System.Drawing;
using ShapeAnimator.Model.Shapes;

namespace ShapeAnimator.View.Shapes
{
    /// <summary>
    ///     Responsible for drawing the circle sprite on the screen.
    /// </summary>
    public class CircleSprite : ShapeSprite

    {
        #region Methods

        private const double DiameterToRadiusFactor = 2.0;

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="RectangleSprite" /> class.
        ///     Precondition: shape != null
        /// </summary>
        /// <param name="shape">The shape.</param>
        /// <param name="height">The height.</param>
        /// <param name="width">The width.</param>
        public CircleSprite(Shape shape, int width, int height) : base(shape, width, height)
        {
        }

        #endregion

        /// <summary>
        ///     Draws a shape
        ///     Preconditon: graphics != null
        /// </summary>
        /// <param name="graphics">The graphics object to draw the shape one</param>
        public override void Paint(Graphics graphics)
        {
            if (graphics == null)
            {
                throw new ArgumentNullException("graphics");
            }

            var yellowBrush = new SolidBrush(this.RandomizedColor);
            graphics.FillEllipse(yellowBrush, this.X, this.Y, this.Width, this.Height);
        }

        /// <summary>
        ///     Areas this instance.
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return Math.PI*(this.Width/DiameterToRadiusFactor)*(this.Height/DiameterToRadiusFactor);
        }

        /// <summary>
        ///     Perimeters this instance.
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return (Math.PI*this.Width);
        }

        /// <summary>
        ///     Gathers the sorting data for the Form.
        /// </summary>
        public override void SortingData()
        {
        }
    }

    #endregion
}