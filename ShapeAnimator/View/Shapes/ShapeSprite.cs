﻿using System;
using System.Drawing;
using ShapeAnimator.Model.Manager;
using ShapeAnimator.Model.Shapes;

namespace ShapeAnimator.View.Shapes
{
    /// <summary>
    ///     Base class for drawing the shape on the screen
    /// </summary>
    public abstract class ShapeSprite
    {
        #region InstanceVariables

        private readonly int height;

        private readonly Color randomizedColor;

        private readonly Shape theShape;

        private readonly int width;
        private DataSorter sorter;

        #endregion

        #region Properties

        /// <summary>
        ///     Gets the x.
        /// </summary>
        /// <value>
        ///     The x.
        /// </value>
        public int X
        {
            get { return this.theShape.X; }
        }

        /// <summary>
        ///     Gets the y.
        /// </summary>
        /// <value>
        ///     The y.
        /// </value>
        public int Y
        {
            get { return this.theShape.Y; }
        }

        /// <summary>
        ///     Gets the color of the randomized.
        /// </summary>
        /// <value>
        ///     The color of the randomized.
        /// </value>
        protected Color RandomizedColor
        {
            get { return this.randomizedColor; }
        }

        /// <summary>
        ///     Gets the height.
        /// </summary>
        /// <value>
        ///     The height.
        /// </value>
        public int Height
        {
            get { return this.height; }
        }

        /// <summary>
        ///     Gets the width.
        /// </summary>
        /// <value>
        ///     The width.
        /// </value>
        public int Width
        {
            get { return this.width; }
        }

        /// <summary>
        ///     Gets the area property.
        /// </summary>
        /// <value>
        ///     The area property.
        /// </value>
        public double AreaProperty
        {
            get { return this.Area(); }
        }

        /// <summary>
        ///     Gets the perimeter property.
        /// </summary>
        /// <value>
        ///     The perimeter property.
        /// </value>
        public double PerimeterProperty
        {
            get { return this.Perimeter(); }
        }

        #endregion

        #region Constructors

        /// <summary>
        ///     Prevents a default instance of the <see cref="ShapeSprite" /> class from being created.
        /// </summary>
        private ShapeSprite()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        ///     precondition: shape != null
        /// </summary>
        /// <param name="theShape">The shape.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <exception cref="System.ArgumentException">Shape cannot be null</exception>
        protected ShapeSprite(Shape theShape, int width, int height) : this()
        {
            if (theShape == null)
            {
                throw new ArgumentException("Shape cannot be null");
            }

            this.theShape = theShape;
            this.width = width;
            this.height = height;
            this.randomizedColor = this.randomColor();
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Randomizes the color.
        /// </summary>
        /// <returns></returns>
        private Color randomColor()
        {
            Color randomColor = Color.FromArgb(ShapeFactory.Randomizer.Next(255), ShapeFactory.Randomizer.Next(255),
                ShapeFactory.Randomizer.Next(255));

            return randomColor;
        }

        /// <summary>
        ///     Paints the specified graphic.
        /// </summary>
        /// <param name="graphics">The graphics.</param>
        public abstract void Paint(Graphics graphics);

        /// <summary>
        ///     Areas this instance.
        /// </summary>
        /// <returns></returns>
        public abstract double Area();

        /// <summary>
        ///     Perimeters this instance.
        /// </summary>
        /// <returns></returns>
        public abstract double Perimeter();

        /// <summary>
        ///     Datas the gather.
        /// </summary>
        /// <param name="collisionCount">The collision count.</param>
        public void DataGather(int collisionCount)
        {
            this.sorter.SendDataToForm(this.GetType().ToString(), this.randomColor(), this.Area(), this.Perimeter(),
                collisionCount);
        }

        #endregion
    }
}