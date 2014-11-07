using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
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

        private enum ControlsEnum
        {
            Initialize,
            Start,
            Pause,
            Resume,
            CLear
        }

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
            this.enableOrDisableControls(ControlsEnum.Initialize);
        }

        #endregion

        #region Event generated methods

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            this.Refresh();

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

        

        private void shapeCanvasPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            this.canvasManager.Update(g);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //this.dataGridView1.Rows.Clear();

            this.animationTimer.Stop();

            int randomShapes = this.GetNumberOfShapes(this.randomShapesTextBox);
            int circles = this.GetNumberOfShapes(this.CirclesTextBox);
            int rectangles = this.GetNumberOfShapes(this.RectanglesTextBox);
            int spottedRectangles = this.GetNumberOfShapes(this.SpottedRectanglesTextBox);

            this.canvasManager.PlaceShapesOnCanvas(randomShapes, circles, rectangles, spottedRectangles);
            this.canvasManager.SortListByArea();
            this.SpeedSlider.Value = 250;
            this.animationTimer.Start();
            this.enableOrDisableControls(ControlsEnum.Start);
        }

        private void speedSliderValueChanged(object sender, EventArgs e)
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

        private void pauseButton_Click(object sender, EventArgs e)
        {
            this.animationTimer.Stop();
            this.enableOrDisableControls(ControlsEnum.Pause);
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            this.animationTimer.Start();
            this.enableOrDisableControls(ControlsEnum.Resume);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.animationTimer.Start();
            this.canvasManager.ClearCanvas();

            this.CirclesTextBox.Text = "0";
            this.RectanglesTextBox.Text = "0";
            this.SpottedRectanglesTextBox.Text = "0";
            this.randomShapesTextBox.Text = "0";
            this.enableOrDisableControls(ControlsEnum.CLear);

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

        private void enableOrDisableControls(ControlsEnum currentControl)
        {
            switch (currentControl)
            {
                case ControlsEnum.Initialize:
                    this.PauseButton.Enabled = false;
                    this.ResumeButton.Enabled = false;
                    this.ClearButton.Enabled = false;
                    break;
                case ControlsEnum.Start:
                    this.randomShapesTextBox.Enabled = false;
                    this.CirclesTextBox.Enabled = false;
                    this.SpottedRectanglesTextBox.Enabled = false;
                    this.RectanglesTextBox.Enabled = false;
                    this.PauseButton.Enabled = true;
                    this.ResumeButton.Enabled = false;
                    this.ClearButton.Enabled = true;
                    break;
                case ControlsEnum.Pause:
                    this.PauseButton.Enabled = false;
                    this.ResumeButton.Enabled = true;
                    break;
                case ControlsEnum.Resume:
                    this.PauseButton.Enabled = true;
                    this.ResumeButton.Enabled = false;
                    break;
                case ControlsEnum.CLear:
                    this.PauseButton.Enabled = false;
                    this.ResumeButton.Enabled = false;

                    this.randomShapesTextBox.Enabled = true;
                    this.CirclesTextBox.Enabled = true;
                    this.SpottedRectanglesTextBox.Enabled = true;
                    this.RectanglesTextBox.Enabled = true;
                    break;
            }
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

            return number;
        }

        /// <summary>
        ///     Writes to data grid.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void WriteToDataGrid()
        {
            
            var thisShape = from currentShape in this.canvasManager.Shapes select currentShape;

            this.dataGridView1.DataSource =
                thisShape.Select(
                    currentShape =>
                        new
                        {
                            Type = currentShape.GetType().Name,
                            Color = colorValue(currentShape.ShapeColor),  
                            Area = currentShape.Area.ToString("####.000"),
                            Perimeter = currentShape.Perimeter.ToString("####.000"),
                            Collisions = currentShape.CollisionCount
                        }).ToList();
            this.setPerimeterAndAreaToAllignAtDecimal();
            this.dataGridView1.AutoGenerateColumns = true;
            this.DoubleBuffered = true;
            
        }

        private void setPerimeterAndAreaToAllignAtDecimal()
        {
            var dataGridViewColumn = this.dataGridView1.Columns["Area"];
            if (dataGridViewColumn != null)
            {
                dataGridViewColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            var gridViewColumn = this.dataGridView1.Columns["Perimeter"];
            if (gridViewColumn != null)
            {
                gridViewColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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


      
    }
}