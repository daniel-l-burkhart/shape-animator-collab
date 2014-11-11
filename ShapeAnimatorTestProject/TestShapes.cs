using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeAnimator.Model.Shapes;
using Rectangle = ShapeAnimator.Model.Shapes.Rectangle;

namespace ShapeAnimatorTestProject
{
    /// <summary>
    ///     Tests the Shapes of the program
    /// </summary>
    [TestClass]
    public class TestShapes
    {
        /// <summary>
        ///     Tests the rectangle.
        /// </summary>
        [TestMethod]
        public void TestRectangle()
        {
            var thePoint = new Point(10, 5);
            Shape theShape = new Rectangle(thePoint);
            Assert.AreEqual(10, theShape.X);
            Assert.AreEqual(5, theShape.Y);
        }

        /// <summary>
        ///     Tests the circles.
        /// </summary>
        [TestMethod]
        public void TestCircles()
        {
            var point = new Point(200, 300);
            Shape theShape = new Circle(point);
            Assert.AreEqual(200, theShape.X);
            Assert.AreEqual(300, theShape.Y);
        }
    }
}