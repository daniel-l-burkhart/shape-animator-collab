using System.Drawing;
using ShapeAnimator.Model.Manager;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model.Shapes
{
    /// <summary>
    ///     Creates a circle shape
    /// </summary>
    public class Circle : Shape
    {
        #region Constants

        private const int ShapeHeight = 100;
        private const int ShapeWidth = 100;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Circle" /> class.
        /// </summary>
        public Circle()
        {
            this.Direction = DirectionRandomizer.GetRandomDirection();
            this.SpriteSpeed = ShapeFactory.Randomizer.Next(1, 5);
            this.Sprite = new CircleSprite(this, ShapeWidth, ShapeHeight);
            this.IsCircle = true;
        }

        /// <summary>
        ///     Constructs a shape at specified location
        ///     Precondition: location != null
        ///     Postcondition: X == location.X; Y == location.Y
        /// </summary>
        /// <param name="location">Location to create shape</param>
        public Circle(Point location) : base(location)
        {
        }

        #endregion
    }
}