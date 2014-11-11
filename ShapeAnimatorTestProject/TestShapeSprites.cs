using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeAnimator.Model.Shapes;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimatorTestProject
{
    /// <summary>
    ///     Summary description for TestShapeSprites
    /// </summary>
    [TestClass]
    public class TestShapeSprites
    {
        /// <summary>
        ///     The circle sprite
        /// </summary>
        private readonly ShapeSprite circleSprite;

        /// <summary>
        ///     Initializes a new instance of the <see cref="TestShapeSprites" /> class.
        /// </summary>
        public TestShapeSprites()
        {
            var cirlce = new Circle();
            this.circleSprite = new CircleSprite(cirlce, 100, 100);
        }

        /// <summary>
        ///     Tests the color of shape sprites.
        /// </summary>
        [TestMethod]
        public void TestColorOfShapeSprites()
        {
            Color testColor = Color.White;

            this.circleSprite.SpriteColor = testColor;

            Assert.AreEqual(255, this.circleSprite.SpriteColor.R);
            Assert.AreEqual(255, this.circleSprite.SpriteColor.G);
            Assert.AreEqual(255, this.circleSprite.SpriteColor.B);
        }
    }
}