using System.Drawing;
using ShapeAnimator.Model.Manager;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model.Shapes
{
    /// <summary>
    /// </summary>
    public class SpottedRectangle : Rectangle
    {
        #region Constructors

        /// <summary>
        ///     Creates a spotted rectangle shape
        /// </summary>
        public SpottedRectangle()
        {
            this.Sprite = new SpottedRectangleSprite(this, ShapeFactory.Randomizer.Next(20, 100),
                ShapeFactory.Randomizer.Next(20, 100));
        }

        /// <summary>
        ///     Constructs a shape at specified location
        ///     Precondition: location != null
        ///     Postcondition: X == location.X; Y == location.Y
        /// </summary>
        /// <param name="location">Location to create shape</param>
        public SpottedRectangle(Point location) : base(location)
        {
        }

        #endregion
    }
}