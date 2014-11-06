using System;
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
        private int dataGridViewRowIndex;
        private int shapeNumber;

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
        }

        #endregion

        #region Event generated methods

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            this.checkTimerViaSpeedSlider();

            if (this.radioButton3.Checked)
            {
                this.WriteToDataGrid();
                this.canvasManager.SortListByCollisionThenShape();
            }
            else
            {
                this.WriteToDataGrid();
            }
        }

        private void checkTimerViaSpeedSlider()
        {
            this.animationTimer.Interval = this.SpeedSlider.Maximum - this.SpeedSlider.Value + 1;
            if (this.SpeedSlider.Value == this.SpeedSlider.Minimum)
            {
                this.animationTimer.Stop();
            }
            else
            {
                this.animationTimer.Start();
            }
        }

        private void shapeCanvasPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            this.canvasManager.Update(g);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();

            this.animationTimer.Stop();

            int randomShapes = this.GetNumberOfShapes(this.randomShapesTextBox);
            int circles = this.GetNumberOfShapes(this.CirclesTextBox);
            int rectangles = this.GetNumberOfShapes(this.RectanglesTextBox);
            int spottedRectangles = this.GetNumberOfShapes(this.SpottedRectanglesTextBox);

            if (this.shapeNumber > 1)
            {
                this.dataGridView1.Rows.Add(this.shapeNumber - 1);
            }

            this.canvasManager.PlaceShapesOnCanvas(randomShapes, circles, rectangles, spottedRectangles);
            this.canvasManager.SortListByArea();
            this.SpeedSlider.Value = 250;
            this.animationTimer.Start();

            this.randomShapesTextBox.Enabled = false;
            this.CirclesTextBox.Enabled = false;
            this.SpottedRectanglesTextBox.Enabled = false;
            this.RectanglesTextBox.Enabled = false;
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

            this.CirclesTextBox.Text = "0";
            this.RectanglesTextBox.Text = "0";
            this.SpottedRectanglesTextBox.Text = "0";
            this.randomShapesTextBox.Text = "0";

            this.PauseButton.Enabled = false;
            this.ResumeButton.Enabled = false;

            this.randomShapesTextBox.Enabled = true;
            this.CirclesTextBox.Enabled = true;
            this.SpottedRectanglesTextBox.Enabled = true;
            this.RectanglesTextBox.Enabled = true;

            this.dataGridView1.Rows.Clear();
            
        }


        private void areaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.canvasManager.SortListByArea();
        }

        private void perimeterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.canvasManager.SortListByPerimeter();
        }

        private void collisionThenShapeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.canvasManager.SortListByCollisionThenShape();
        }

        private void shapeThenColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.canvasManager.SortListByShapeThenColor();
        }

        #endregion

        /// <summary>
        ///     Numbers of shapes.
        /// </summary>
        /// <param name="textBox">The text box.</param>
        /// <returns></returns>
        public int GetNumberOfShapes(TextBox textBox)
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
            this.shapeNumber += number;
            return number;
        }

        /// <summary>
        ///     Writes to data grid.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void WriteToDataGrid()
        {
            this.DoubleBuffered = true;
            DataGridViewRow currentRow = this.dataGridView1.CurrentRow;
            if (currentRow != null)
            {
                this.dataGridViewRowIndex = currentRow.Index;
            }
            foreach (Shape shape in this.canvasManager.Shapes)
            {
                this.addDataToColumn("ShapeType", shape.GetType().Name);
                this.addDataToColumn("Color", colorValue(shape.ShapeColor));
                this.addDataToColumn("PerimeterProperty", shape.Perimeter.ToString("##.000"));
                this.addDataToColumn("AreaColumn", shape.Area.ToString("##.000"));
                this.addDataToColumn("CollisionCount", shape.CollisionCount.ToString(CultureInfo.InvariantCulture));
                this.dataGridViewRowIndex++;
            }
        }

        private static string colorValue(Color shapeColor)
        {
            int redComponent = shapeColor.R;
            int greenComponent = shapeColor.G;
            int blueComponent = shapeColor.B;
            string colorValue = "(" + redComponent + "," + greenComponent + "," + blueComponent + ")";
            return colorValue;
        }

        private void addDataToColumn(string columnName, string data)
        {
            DataGridViewColumn currentColumn = this.dataGridView1.Columns[columnName];
            if (currentColumn == null)
            {
                return;
            }
            this.dataGridView1[currentColumn.Index, this.dataGridViewRowIndex].Value = data;
        }

      
    }
}