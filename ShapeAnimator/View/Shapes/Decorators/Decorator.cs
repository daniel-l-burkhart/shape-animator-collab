using System;
using System.Drawing;
using ShapeAnimator.Model.Shapes;

namespace ShapeAnimator.View.Shapes.Decorators
{
    /// <summary>
    /// Decorator class for Shape Sprite
    /// </summary>
    public class Decorator : ShapeSprite
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Decorator"/> class.
        /// </summary>
        /// <param name="shape">The shape.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public Decorator(Shape shape, int width, int height) : base(shape, width, height)
        {
            
        }



        /// <summary>
        ///     Paints the specified graphic.
        /// </summary>
        /// <param name="graphics">The graphics.</param>
        public override void Paint(Graphics graphics)
        {
           
        }

        public ShapeSprite getRandomDecorator()
        {
            throw new NotImplementedException();
        }
    }
}
