using System;
using System.Drawing;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model.Shapes
{
    /// <summary>
    ///     Holds information about a shape
    /// </summary>
    public abstract class Shape
    {
        #region Variables

        private Point location;
        private int speedX;
        private int speedY;
        private ShapeSprite sprite;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the speed x.
        /// </summary>
        /// <value>
        /// The speed x.
        /// </value>
        public int SpeedX
        {
            set { this.speedX = value; }
            get { return this.speedX; }
        }

        /// <summary>
        /// Gets or sets the speed y.
        /// </summary>
        /// <value>
        /// The speed y.
        /// </value>
        public int SpeedY
        {
            set { this.speedY = value; }
            get { return this.speedY; }
        }

        /// <summary>
        ///     Gets or sets the x.
        /// </summary>
        /// <value>
        ///     The x.
        /// </value>
        public int X
        {
            set { this.location.X = value; }
            get { return this.location.X; }
        }

        /// <summary>
        ///     Gets or sets the y.
        /// </summary>
        /// <value>
        ///     The y.
        /// </value>
        public int Y
        {
            set { this.location.Y = value; }
            get { return this.location.Y; }
        }

        /// <summary>
        ///     The sprite
        /// </summary>
        protected ShapeSprite Sprite
        {
            set { this.sprite = value; }
        }

        /// <summary>
        ///     Gets the height.
        /// </summary>
        /// <value>
        ///     The height.
        /// </value>
        public int Height
        {
            get { return this.sprite.Height; }
        }

        /// <summary>
        ///     Gets the width.
        /// </summary>
        /// <value>
        ///     The width.
        /// </value>
        public int Width
        {
            get { return this.sprite.Width; }
        }

        #endregion

        #region Constructors

        /// <summary>
        ///     Default constructor
        /// </summary>
        protected Shape()
        {
        }

        /// <summary>
        ///     Constructs a shape at specified location
        ///     Precondition: location != null
        ///     Postcondition: X == location.X; Y == location.Y
        /// </summary>
        /// <param name="location">Location to create shape</param>
        protected Shape(Point location) : this()
        {
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }

            this.location = location;
        }

        /// <summary>
        ///     Constructs a shape specified x,y location
        ///     Precondition: None
        ///     Postcondition: X == x; Y == y
        /// </summary>
        /// <param name="x">The x coordinate</param>
        /// <param name="y">The y coordinate</param>
        protected Shape(int x, int y) : this()
        {
            this.location = new Point(x, y);
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Moves this shape.
        /// </summary>
        public void Move()
        {
            this.location.X += this.speedX;
            this.location.Y += this.speedY;
        }

        /// <summary>
        ///     Draws a shape
        ///     Precondition: g != NULL
        /// </summary>
        /// <param name="g">The graphics object to draw the shape one</param>
        public void Paint(Graphics g)
        {
            if (g == null)
            {
                throw new ArgumentNullException("g");
            }

            this.sprite.Paint(g);
        }

        /// <summary>
        /// calculates the area based off  the specified width and height.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <returns></returns>
        public abstract double Area(double width, double height);

        /// <summary>
        /// Perimeters the specified width.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <returns></returns>
        public abstract double Perimeter(double width, double height);

        #endregion
    }
}