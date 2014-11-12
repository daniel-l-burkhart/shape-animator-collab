using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ShapeAnimator.Model.Manager.ComparerClasses;
using ShapeAnimator.Model.Shapes;
using ShapeAnimator.Properties;
using Rectangle = System.Drawing.Rectangle;

namespace ShapeAnimator.Model.Manager
{
    /// <summary>
    ///     Manages the collection of shapes on the canvas.
    /// </summary>
    public class ShapeManager
    {
        #region Instance variables

        private readonly PictureBox canvas;
        private readonly List<Shape> shapes;
        private bool isPaused;

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets a value indicating whether this instance is paused.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is paused; otherwise, <c>false</c>.
        /// </value>
        public bool IsPaused
        {
            get { return this.isPaused; }
            set { this.isPaused = value; }
        }

        /// <summary>
        ///     Gets the shape list property.
        /// </summary>
        /// <value>
        ///     The shape list property.
        /// </value>
        public List<Shape> Shapes
        {
            get { return this.shapes; }
        }

        #endregion

        #region Constructors

        /// <summary>
        ///     Prevents a default instance of the <see cref="ShapeManager" /> class from being created.
        /// </summary>
        private ShapeManager()
        {
            this.shapes = null;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ShapeManager" /> class.
        ///     Precondition: pictureBox != null
        /// </summary>
        /// <param name="pictureBox">The picture box that will be drawing on</param>
        public ShapeManager(PictureBox pictureBox) : this()
        {
            if (pictureBox == null)
            {
                throw new ArgumentNullException("pictureBox", Resources.PictureBoxNullMessage);
            }
            this.shapes = new List<Shape>();
            this.canvas = pictureBox;
            this.isPaused = false;
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Places the shape on the canvas.
        ///     Precondition: None
        /// </summary>
        public void PlaceShapesOnCanvas(int numberOfRandomShapes, int numberOfCircles, int numberOfRectangles,
            int numberOfSpottedRectangles)
        {
            this.shapes.Clear();

            this.placeShapesOnCanvasHelper(numberOfRandomShapes, ShapeFactory.Shapes.Random);

            this.placeShapesOnCanvasHelper(numberOfCircles, ShapeFactory.Shapes.Circle);

            this.placeShapesOnCanvasHelper(numberOfRectangles, ShapeFactory.Shapes.Rectangle);

            this.placeShapesOnCanvasHelper(numberOfSpottedRectangles, ShapeFactory.Shapes.SpottedRectangle);
        }

        private void placeShapesOnCanvasHelper(int numberOfShapes, ShapeFactory.Shapes shape)
        {
            for (int i = 0; i < numberOfShapes; i++)
            {
                Shape aShape = ShapeFactory.CreateAShape(shape);
                this.placeShapesInCanvasBoundary(aShape);
                this.shapes.Add(aShape);
            }
        }

        private void placeShapesInCanvasBoundary(Shape aShape)
        {
            aShape.X = ShapeFactory.Randomizer.Next(this.canvas.Width - aShape.Width);
            aShape.Y = ShapeFactory.Randomizer.Next(this.canvas.Height - aShape.Height);

            var aRectangle = new Rectangle(aShape.X, aShape.Y, aShape.Width, aShape.Height);

            foreach (Shape theShape in this.shapes)
            {
                var comparatorRectangle = new Rectangle(theShape.X, theShape.Y, theShape.Width, theShape.Height);

                if (aRectangle.IntersectsWith(comparatorRectangle))
                {
                    this.placeShapesInCanvasBoundary(aShape);
                }
            }
        }

        /// <summary>
        ///     Directs the shapes movement when encountering boundaries
        /// </summary>
        public void CheckForChangeInDirection()
        {
            foreach (Shape shape in this.shapes)
            {
                if (this.checkHorizontalRightBounds(shape))
                {
                    checkRightBoundary(shape);
                }

                else if (this.checkVerticalBottomBounds(shape))
                {
                    checkBottomBoundary(shape);
                }

                else if (this.checkHorizontalLeftBounds(shape))
                {
                    checkLeftBoundary(shape);
                }

                else if (this.checkVerticalTopBounds(shape))
                {
                    checkTopBoundary(shape);
                }
            }
        }

        /// <summary>
        ///     Shapeses the bounce off each other.
        /// </summary>
        public void ShapesBounceOffEachOther(Shape firstShape)
        {
            var firstRectangle = new Rectangle(firstShape.X, firstShape.Y, firstShape.Width + 2, firstShape.Height + 2);

            foreach (Shape secondShape in this.shapes)
            {
                var secondRectangle = new Rectangle(secondShape.X, secondShape.Y, secondShape.Width + 2,
                    secondShape.Height + 2);
                if (firstRectangle == secondRectangle)
                {
                    break;
                }
                if (firstRectangle.IntersectsWith(secondRectangle) && secondRectangle.IntersectsWith(firstRectangle))
                {
                    this.changeDirections(firstShape);
                    this.changeDirections(secondShape);
                }
            }
        }

        private void changeDirections(Shape currentShape)
        {
            currentShape.SpeedX *= -1;
            currentShape.SpeedY *= -1;

            currentShape.CollisionCount++;
        }

        private static void checkTopBoundary(Shape shape)
        {
            shape.SpeedY = Math.Abs(shape.SpeedY)*(int) DirectionRandomizer.Directions.RightOrDown;
            shape.CollisionCount++;
        }

        private static void checkLeftBoundary(Shape shape)
        {
            shape.SpeedX = Math.Abs(shape.SpeedX)*(int) DirectionRandomizer.Directions.RightOrDown;
            shape.CollisionCount++;
        }

        private static void checkBottomBoundary(Shape shape)
        {
            shape.SpeedY = Math.Abs(shape.SpeedY)*(int) DirectionRandomizer.Directions.LeftOrUp;
            shape.CollisionCount++;
        }

        private static void checkRightBoundary(Shape shape)
        {
            shape.SpeedX = Math.Abs(shape.SpeedX)*(int) DirectionRandomizer.Directions.LeftOrUp;
            shape.CollisionCount++;
        }

        private bool checkHorizontalRightBounds(Shape shape)
        {
            return shape.X + shape.Width + shape.SpeedX > this.canvas.Width && shape.SpeedX >= 1;
        }

        private bool checkVerticalBottomBounds(Shape shape)
        {
            return shape.Y + shape.Height + shape.SpeedY > this.canvas.Height && shape.SpeedY >= 1;
        }

        private bool checkHorizontalLeftBounds(Shape shape)
        {
            return shape.X + shape.SpeedX < 0;
        }

        private bool checkVerticalTopBounds(Shape shape)
        {
            return shape.Y + shape.SpeedY < 0;
        }

        /// <summary>
        ///     Clears the canvas.
        /// </summary>
        public void ClearCanvas()
        {
            this.shapes.Clear();
        }

        /// <summary>
        ///     Moves the shape around and the calls the Shape::Paint method to draw the shape.
        ///     Precondition: g != null
        /// </summary>
        /// <param name="g">The graphics object to draw on</param>
        public void Update(Graphics g)
        {
            if (g == null)
            {
                throw new ArgumentNullException("g");
            }

            if (this.shapes != null)
            {
                foreach (Shape shape in this.shapes)
                {
                    this.ShapesBounceOffEachOther(shape);
                    this.CheckForChangeInDirection();

                    if (this.isPaused == false)
                    {
                        shape.Move();
                    }
                    shape.Paint(g);
                }
            }
        }

        #endregion

        #region Comparer Methods

        /// <summary>
        ///     Sorts the list by area.
        /// </summary>
        public void SortListByArea()
        {
            var areaComparer = new AreaComparer();
            this.shapes.Sort(areaComparer);
        }

        /// <summary>
        ///     Sorts the list by perimeter.
        /// </summary>
        public void SortListByPerimeter()
        {
            var perimeter = new PerimeterComparer();
            this.shapes.Sort(perimeter);
        }

        /// <summary>
        ///     Sorts the list by collision then shape.
        /// </summary>
        public void SortListByCollisionThenShape()
        {
            var comparisonVar = new CollisionCountThenShapeType();
            this.shapes.Sort(comparisonVar);
        }

        /// <summary>
        ///     Sorts the color of the list by shape then.
        /// </summary>
        public void SortListByShapeThenColor()
        {
            var colorShapeComparer = new TypeThenColorComparer();
            this.shapes.Sort(colorShapeComparer);
        }

        #endregion
    }
}