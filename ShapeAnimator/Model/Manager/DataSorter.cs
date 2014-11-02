using System;
using System.Drawing;
using ShapeAnimator.View.Forms;

namespace ShapeAnimator.Model.Manager
{
    /// <summary>
    /// DataSorter class used to organize the data to send to the form.
    /// </summary>
    public class DataSorter
    {
#region Instance Variable
        private ShapeAnimatorForm form;
#endregion
        /// <summary>
        ///     Sends the data to form.
        /// </summary>
        /// <param name="shapeType">Type of the shape.</param>
        /// <param name="shapeColor">Color of the shape.</param>
        /// <param name="shapeArea">The shape area.</param>
        /// <param name="shapePerimeter">The shape perimeter.</param>
        /// <param name="collisionCount">The collision count.</param>
        public void SendDataToForm(string shapeType, Color shapeColor, double shapeArea, double shapePerimeter,
            int collisionCount)
        {
            int redComponent = shapeColor.R;
            int greenComponent = shapeColor.G;
            int blueComponent = shapeColor.B;
            string ColorValue = "(" + redComponent.ToString()+ "," + greenComponent.ToString()+ "," + blueComponent.ToString()+")";
            form.WriteToDataGrid(shapeType, ColorValue, shapeArea, shapePerimeter, collisionCount);
        }
    }
}