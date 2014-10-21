using System.Drawing;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model.Shapes
{
    /// <summary>
    /// 
    /// </summary>
    public class SpottedRectangle : Rectangle
    {

        #region Constants

        private const int ShapeHeight = 100;
        private const int ShapeWidth = 100;

        #endregion

        #region Constructors

        /// <summary>
        ///     Creates a spotted rectangle shape
        /// </summary>
        public SpottedRectangle()
        {
            this.Sprite = new SpottedRectangleSprite(this, ShapeWidth, ShapeHeight);
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