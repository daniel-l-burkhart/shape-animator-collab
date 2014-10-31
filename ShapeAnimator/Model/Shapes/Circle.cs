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
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Circle" /> class.
        /// </summary>
        public Circle()
        {
            this.SpeedX = ShapeFactory.Randomizer.Next(-5, 5);
            this.SpeedY = ShapeFactory.Randomizer.Next(-5, 5);
            this.Sprite = new CircleSprite(this, ShapeFactory.Randomizer.Next(20, 100),
                ShapeFactory.Randomizer.Next(20, 100));
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