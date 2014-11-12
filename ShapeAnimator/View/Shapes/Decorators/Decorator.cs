using System;
using System.Drawing;
using ShapeAnimator.Model.Manager;
using ShapeAnimator.Model.Shapes;

namespace ShapeAnimator.View.Shapes.Decorators
{
    /// <summary>
    /// Decorator class for Shape Sprite
    /// </summary>
    public class Decorator : ShapeSprite
    {

        /// <summary>
        ///     enum of decorators
        /// </summary>
        public enum Decorators
        {
            /// <summary>
            ///     The Vertical Bar
            /// </summary>
            VerticalBar,

            /// <summary>
            ///     The Horizontal Bar
            /// </summary>
            HorizontalBar,

            /// <summary>
            ///     The spot
            /// </summary>
            Spot
        }

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

        /// <summary>
        /// Gets the random decorator.
        /// </summary>
        /// <param name="theShape">The shape.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public ShapeSprite GetRandomDecorator(Shape theShape, int width, int height)
        {
            Decorators randomDecorator = this.determineRandomDecorator();

            ShapeSprite decorator = null;

            switch (randomDecorator)
            {
                case Decorators.HorizontalBar:
                    decorator = new HorizontalBarDecorator(theShape, width, height);
                    break;
                case Decorators.VerticalBar:
                    decorator = new VerticalBarDecorator(theShape, width, height);
                    break;
                case Decorators.Spot:
                    decorator = new SpotDecorator(theShape, width, height);
                    break;
            }
            return decorator;
        }

        private Decorators determineRandomDecorator()
        {
            Array values = Enum.GetValues(typeof(Decorators));
            var theDecorator = (Decorators)values.GetValue(ShapeFactory.Randomizer.Next(values.Length - 1));
            return theDecorator;
        }
    }
}
