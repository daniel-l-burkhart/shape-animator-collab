using System;
using ShapeAnimator.Model.Shapes;

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
            ///     The spotted rectangle
            /// </summary>
            SpottedRectangle,

            /// <summary>
            ///     The rectangle
            /// </summary>
            Rectangle
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
        public static Shape CreateAShape()
        {
            Shapes shape = getRandomShape();

            Shape theShape = null;

            switch (shape)
            {
                case Shapes.Circle:
                    theShape = new Circle();
                    break;
                case Shapes.Rectangle:
                    theShape = new Rectangle();
                    break;
                case Shapes.SpottedRectangle:
                    theShape = new SpottedRectangle();
                    break;
            }

            return theShape;
        }

        private static Shapes getRandomShape()
        {
            Array values = Enum.GetValues(typeof (Shapes));
            var theShape = (Shapes) values.GetValue(Randomizer.Next(values.Length));

            return theShape;
        }

        #endregion
    }
}