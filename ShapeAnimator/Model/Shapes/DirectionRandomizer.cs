using System;
using ShapeAnimator.Model.Manager;

namespace ShapeAnimator.Model.Shapes
{
    /// <summary>
    ///     Direction Randomizer that randomizes the starting direction of the shapes
    /// </summary>
    public class DirectionRandomizer
    {
        /// <summary>
        ///     enum of Direction
        ///     Right and Down are 1
        ///     Left and Up are -1
        /// </summary>
        public enum Directions
        {
            /// <summary>
            ///     The right or down direction
            /// </summary>
            RightOrDown = 1,

            /// <summary>
            ///     The left or up direction
            /// </summary>
            LeftOrUp = -1
        }

        /// <summary>
        ///     Gets a random starting direction for the shapes
        /// </summary>
        /// <returns></returns>
        public static int GetRandomDirection()
        {
            Array values = Enum.GetValues(typeof (Directions));
            var theDirection = (int) (Directions) values.GetValue(ShapeFactory.Randomizer.Next(values.Length));

            return theDirection;
        }
    }
}