using System.Drawing;
using ShapeAnimator.Model.Manager;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model.Shapes
{
    /// <summary>
    /// 
    /// </summary>
    public class Rectangle : Shape
    {
        #region Constants

        private const int ShapeHeight = 100;
        private const int ShapeWidth = 100;

        #endregion

        #region Constructors

        /// <summary>
        ///     Creates a rectangle shape
        /// </summary>
        public Rectangle()
        {
            this.Direction = DirectionRandomizer.GetRandomDirection();
            this.SpriteSpeed = ShapeFactory.Randomizer.Next(1, 5);
            this.Sprite = new RectangleSprite(this, ShapeWidth, ShapeHeight);
            this.IsRectangle = true;
        }

        /// <summary>
        ///     Constructs a shape at specified location
        ///     Precondition: location != null
        ///     Postcondition: X == location.X; Y == location.Y
        /// </summary>
        /// <param name="location">Location to create shape</param>
        public Rectangle(Point location) : base(location)
        {
        }

        #endregion
    }
}