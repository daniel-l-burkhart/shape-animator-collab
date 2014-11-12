using System.Drawing;
using ShapeAnimator.Model.Shapes;

namespace ShapeAnimator.View.Shapes.Decorators
{
    /// <summary>
    /// Horizontally Centered Vertical Bar
    /// </summary>
    public class HorizontallyCenteredVerticalBarDecorator : Decorator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Decorator"/> class.
        /// </summary>
        /// <param name="shape">The shape.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public HorizontallyCenteredVerticalBarDecorator(Shape shape, int width, int height) : base(shape, width, height)
        {
        }

        /// <summary>
        ///     Paints the specified graphic.
        /// </summary>
        /// <param name="graphics">The graphics.</param>
        public override void Paint(Graphics graphics)
        {
            base.Paint(graphics);
            Brush barBrush = new SolidBrush(Color.DarkTurquoise);
            graphics.FillRectangle(barBrush, this.X/2, this.Y, 10, this.Height);
        }
    }
}
