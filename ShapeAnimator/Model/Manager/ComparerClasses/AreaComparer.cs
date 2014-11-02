﻿using System.Collections.Generic;
using ShapeAnimator.Model.Shapes;

namespace ShapeAnimator.Model.Manager.ComparerClasses
{
    /// <summary>
    ///     Compares by Area.
    /// </summary>
    public class AreaComparer : IComparer<Shape>
    {
        /// <summary>
        ///     Compares two objects and returns a value indicating whether one is less than, equal to, or greater than the other.
        /// </summary>
        /// <returns>
        ///     A signed integer that indicates the relative values of <paramref name="x" /> and <paramref name="y" />, as shown in
        ///     the following table.Value Meaning Less than zero<paramref name="x" /> is less than <paramref name="y" />.Zero
        ///     <paramref name="x" /> equals <paramref name="y" />.Greater than zero<paramref name="x" /> is greater than
        ///     <paramref name="y" />.
        /// </returns>
        /// <param name="x">The first object to compare.</param>
        /// <param name="y">The second object to compare.</param>
        public int Compare(Shape x, Shape y)
        {
            return x.Area.CompareTo(y.Area);
        }
    }
}