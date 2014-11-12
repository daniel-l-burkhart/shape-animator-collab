using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAnimator.Model.Shapes;

namespace ShapeAnimator.View.Shapes.Decorators
{
    /// <summary>
    /// Vertical Bar Vertically
    /// </summary>
    public class VerticallyCenteredHorizontalBarDecorator : Decorator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Decorator"/> class.
        /// </summary>
        /// <param name="shape">The shape.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public VerticallyCenteredHorizontalBarDecorator(Shape shape, int width, int height) : base(shape, width, height)
        {
        }

        /// <summary>
        ///     Paints the specified graphic.
        /// </summary>
        /// <param name="graphics">The graphics.</param>
        public override void Paint(Graphics graphics)
        {
            base.Paint(graphics);
            Brush barBrush = new SolidBrush(Color.Aqua);
            graphics.FillRectangle(barBrush, this.Y/2, this.Y, this.Width, 10);
        }
    }
}
