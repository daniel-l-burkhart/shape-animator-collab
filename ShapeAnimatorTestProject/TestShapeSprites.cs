using System;
using System.Drawing;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeAnimator.Model.Shapes;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimatorTestProject
{
    /// <summary>
    /// Summary description for TestShapeSprites
    /// </summary>
    [TestClass]
    public class TestShapeSprites
    {
        private Circle cirlce;
        private ShapeSprite circleSprite;
       
        public TestShapeSprites()
        {
            this.cirlce = new Circle();
            this.circleSprite = new CircleSprite(this.cirlce, 100, 100);   
        }

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
