using System.Drawing;
using ShapeAnimator.Model.Shapes;

namespace ShapeAnimator.View.Shapes
{
    internal class SpottedRectangleSprite : RectangleSprite
    {

        #region Constants

        private const int HeightOfSpot = 25;
        private const int WidthOfSpot = 25;

        #endregion

        #region Constructors


        /// <summary>
        ///     Initializes a new instance of the <see cref="RectangleSprite" /> class.
        /// </summary>
        /// <param name="shape">The shape.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public SpottedRectangleSprite(Shape shape, int width, int height) : base(shape, width, height)
        {
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Draws a shape
        /// </summary>
        /// <param name="graphics">The graphics.</param>
        public override void Paint(Graphics graphics)
        {
            base.Paint(graphics);
            var yellowBrush = new SolidBrush(Color.Red);
            graphics.FillEllipse(yellowBrush, this.X, this.Y, WidthOfSpot, HeightOfSpot);
        }

        #endregion
    }
}