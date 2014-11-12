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
    /// Puts a spot in the middle of the shape.
    /// </summary>
    public class SpotDecorator : Decorator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Decorator"/> class.
        /// </summary>
        /// <param name="shape">The shape.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public SpotDecorator(Shape shape, int width, int height) : base(shape, width, height)
        {
        }

        /// <summary>
        ///     Paints the specified graphic.
        /// </summary>
        /// <param name="graphics">The graphics.</param>
        public override void Paint(Graphics graphics)
        {
            base.Paint(graphics);
            Brush spotBrush = new SolidBrush(Color.Tomato);
            graphics.FillEllipse(spotBrush, this.X/2, this.Y/2, 15, 15);
        }
    }
}
