using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ShapeAnimator.Model.Shapes;
using ShapeAnimator.Properties;

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
                aShape.SendDataToSorter();
                this.shapes.Add(aShape);
            }
        }

        private void placeShapesInCanvasBoundary(Shape aShape)
        {
            aShape.X = ShapeFactory.Randomizer.Next(this.canvas.Width - aShape.Width);
            aShape.Y = ShapeFactory.Randomizer.Next(this.canvas.Height - aShape.Height);
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
                    shape.SpeedX = Math.Abs(shape.SpeedX)*(int) DirectionRandomizer.Directions.LeftOrUp;
                    shape.CollisionCount++;
                }

                else if (this.checkVerticalBottomBounds(shape))
                {
                    shape.SpeedY = Math.Abs(shape.SpeedY)*(int) DirectionRandomizer.Directions.LeftOrUp;
                    shape.CollisionCount++;
                }

                else if (this.checkHorizontalLeftBounds(shape))
                {
                    shape.SpeedX = Math.Abs(shape.SpeedX)*(int) DirectionRandomizer.Directions.RightOrDown;
                    shape.CollisionCount++;
                }

                else if (this.checkVerticalTopBounds(shape))
                {
                    shape.SpeedY = Math.Abs(shape.SpeedY)*(int) DirectionRandomizer.Directions.RightOrDown;
                    shape.CollisionCount++;
                }
            }
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
                    this.CheckForChangeInDirection();
                    shape.Move();
                    shape.Paint(g);
                    shape.UpdateCollisionCount(shape.CollisionCount);
                }
            }
        }
    }

    #endregion
}