using System;
using ShapeAnimator.Model.Shapes;
using ShapeAnimator.View.Shapes.Decorators;

namespace ShapeAnimator.Model.Manager
{
    /// <summary>
    ///     A factory that creates shape objects
    /// </summary>
    public static class ShapeFactory
    {
        #region Enum

        /// <summary>
        ///     enum of shapes
        /// </summary>
        public enum Shapes
        {
            /// <summary>
            ///     The circle
            /// </summary>
            Circle,

            /// <summary>
            ///     The rectangle
            /// </summary>
            Rectangle,

            /// <summary>
            ///     The random
            /// </summary>
            Random
        }

        #endregion

        #region Randomizer Data

        /// <summary>
        ///     The Randomizer
        /// </summary>
        public static readonly Random Randomizer = new Random(Guid.NewGuid().GetHashCode());

        #endregion

        #region Methods

        /// <summary>
        ///     Creates a shape.
        /// </summary>
        /// <returns></returns>
        public static Shape CreateAShape(Shapes aShape)
        {
            Shapes shape = aShape;

            Shape theShape = getShapes(shape);

            return theShape;
        }

        private static Shape getShapes(Shapes shape)
        {
            
            Shape theShape = null;

            switch (shape)
            {
                case Shapes.Circle:
                    theShape = new Circle();
                    break;
                case Shapes.Rectangle:
                    theShape = new Rectangle();
                    break;
                case Shapes.Random:
                    theShape = getRandomShape();
                    break;
            }
            return theShape;
        }

        private static Shape getRandomShape()
        {
            Array values = Enum.GetValues(typeof (Shapes));
            var theShape = (Shapes) values.GetValue(Randomizer.Next(values.Length - 1));
            Shape newShape = getShapes(theShape);
            return newShape;
        }

        #endregion
    }
}