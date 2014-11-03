using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using ShapeAnimator.Model.Manager;
using ShapeAnimator.Model.Shapes;
using ShapeAnimator.Properties;

namespace ShapeAnimator.View.Forms
{
    /// <summary>
    ///     Manages the form that will display shapes.
    /// </summary>
    public partial class ShapeAnimatorForm
    {
        #region Instance variables

        private readonly ShapeManager canvasManager;

        #endregion

        #region Constructor

        /// <summary>
        ///     Initializes a new instance of the <see cref="ShapeAnimatorForm" /> class.
        ///     Precondition: None
        /// </summary>
        public ShapeAnimatorForm()
        {
            this.InitializeComponent();
            this.canvasManager = new ShapeManager(this.canvasPictureBox);
            this.PauseButton.Enabled = false;
            this.ResumeButton.Enabled = false;
            this.ClearButton.Enabled = false;
            this.dataGridView1 = new DataGridView {DataSource = this.canvasManager.ShapeListProperty};
        }

        #endregion

        #region Event generated methods

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            this.animationTimer.Interval = this.SpeedSlider.Maximum - this.SpeedSlider.Value + 1;
        }

        private void shapeCanvasPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            this.canvasManager.Update(g);
        }

        private void animateButton_Click(object sender, EventArgs e)
        {
            this.animationTimer.Stop();
            int randomShapes = this.GetNumberOfShapes(this.numberShapesTextBox);
            int circles = this.GetNumberOfShapes(this.CirclesTextBox);
            int rectangles = this.GetNumberOfShapes(this.RectanglesTextBox);
            int spottedRectangles = this.GetNumberOfShapes(this.SpottedRectanglesTextBox);

            this.canvasManager.PlaceShapesOnCanvas(randomShapes, circles, rectangles, spottedRectangles);

            this.animationTimer.Start();

            this.PauseButton.Enabled = true;
            this.ResumeButton.Enabled = false;
            this.ClearButton.Enabled = true;
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            this.animationTimer.Stop();
            this.PauseButton.Enabled = false;
            this.ResumeButton.Enabled = true;
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            this.animationTimer.Start();
            this.PauseButton.Enabled = true;
            this.ResumeButton.Enabled = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.animationTimer.Start();
            this.canvasManager.ClearCanvas();
            this.PauseButton.Enabled = false;
            this.ResumeButton.Enabled = false;
        }

        /// <summary>
        ///     Numbers the shapes.
        /// </summary>
        /// <param name="textBox">The text box.</param>
        /// <returns></returns>
        public int GetNumberOfShapes(TextBox textBox)
        {
            {
                int number = 0;
                try
                {
                    number = Convert.ToInt32(textBox.Text);
                    if (number < 0)
                    {
                        MessageBox.Show(Resources.Cannot_Be_Negative);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(Resources.Must_Be_Integer);
                }
                return number;
            }
        }

        #endregion

        /// <summary>
        ///     Writes to data grid.
        /// </summary>
        /// <param name="shapeType">Type of the shape.</param>
        /// <param name="colorValue">The color value.</param>
        /// <param name="shapeArea">The shape area.</param>
        /// <param name="shapePerimeter">The shape perimeter.</param>
        /// <param name="collisionCount">The collision count.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void WriteToDataGrid(string shapeType, string colorValue, double shapeArea, double shapePerimeter,
            int collisionCount)
        {
            this.addDataToColumn("ShapeType", shapeType);
            this.addDataToColumn("Color", colorValue);
            this.addDataToColumn("PerimeterProperty", shapePerimeter.ToString("##.000"));
            this.addDataToColumn("AreaColumn", shapeArea.ToString("##.000"));
            this.addDataToColumn("CollisionCount", collisionCount.ToString(CultureInfo.InvariantCulture));
        }

        private void addDataToColumn(string columnName, string data)
        {
            DataGridViewColumn currentColumn = this.dataGridView1.Columns[columnName];
            if (currentColumn == null)
            {
                return;
            }
            DataGridViewRow dataGridViewRow = this.dataGridView1.CurrentRow;
            if (dataGridViewRow != null)
            {
                this.dataGridView1[currentColumn.Index, dataGridViewRow.Index].Value = data;
            }
        }

        private void area_Click(object sender, EventArgs e)
        {
            this.canvasManager.SortListByArea();
        }

        private void perimeter_Click(object sender, EventArgs e)
        {
            this.canvasManager.SortListByPerimeter();
        }

        private void collisionThenShape_Click(object sender, EventArgs e)
        {
            this.canvasManager.SortListByCollisionThenShape();
        }

        private void shapeThenColor_Click(object sender, EventArgs e)
        {
            this.canvasManager.SortListByShapeThenColor();
        }

        /// <summary>
        ///     Sends the list to form.
        /// </summary>
        /// <param name="shapes">The shapes.</param>
        public void SendListToForm(List<Shape> shapes)
        {
            this.dataGridView1.DataSource = shapes;
        }
    }
}