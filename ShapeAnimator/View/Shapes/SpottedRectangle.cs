using System.Drawing;
using ShapeAnimator.Model;

namespace ShapeAnimator.View.Shapes
{
    class SpottedRectangle : RectangleSprite
    {
        #region Instance Variables
        private readonly Shape theShape;

        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="RectangleSprite" /> class.
        /// </summary>
        /// <param name="shape">The shape.</param>
        public SpottedRectangle(Shape shape)
            : base(shape)
        {
            this.theShape = shape;
        } 
        #endregion

        #region Methods
        /// <summary>
        /// Paints the specified graphic
        /// </summary>
        /// <param name="graphics">The graphics.</param>
        public override void Paint(Graphics graphics)
        {
            base.Paint(graphics);
            var yellowBrush = new SolidBrush(Color.Red);
            graphics.FillEllipse(yellowBrush, this.theShape.X, this.theShape.Y, 25, 25);
        } 
        #endregion
    }
}
