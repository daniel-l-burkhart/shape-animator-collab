using System;
using System.Drawing;
using System.Windows.Forms;
using ShapeAnimator.Model.Manager;

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

        #region Properties

        /// <summary>
        ///     Converts the text in the numberShapesTextBox to an integer. If the text
        ///     is not convertable to an integer value it returns 0.
        /// </summary>
        public int NumberRandomShapes
        {
            get
            {
                int number = 0;
                try
                {
                    number = Convert.ToInt32(this.numberShapesTextBox.Text);
                    if (number < 0)
                    {
                        MessageBox.Show("Number cannot be negative");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Must be an integer");
                }
                return number;

            }
        }

        /// <summary>
        /// Gets the number circles.
        /// </summary>
        /// <value>
        /// The number circles.
        /// </value>
        public int NumberCircles
        {
            get
            {
                int number = 0;
                try
                {
                    number = Convert.ToInt32(this.circlesTextBox.Text);
                    if (number < 0)
                    {
                        MessageBox.Show("Number cannot be negative");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Must be an integer");
                }
                return number;

            }
        }

        /// <summary>
        /// Gets the number rectangles.
        /// </summary>
        /// <value>
        /// The number rectangles.
        /// </value>
        public int NumberRectangles
        {
            get
            {
                int number = 0;
                try
                {
                    number = Convert.ToInt32(this.rectanglesTextBox.Text);
                    if (number < 0)
                    {
                        MessageBox.Show("Number cannot be negative");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Must be an integer");
                }
                return number;

            }
        }

        /// <summary>
        /// Gets the number spotted rectangles.
        /// </summary>
        /// <value>
        /// The number spotted rectangles.
        /// </value>
        public int NumberSpottedRectangles
        {
            get
            {
                int number = 0;
                try
                {
                    number = Convert.ToInt32(this.spottedRectanglesTextBox.Text);
                    if (number < 0)
                    {
                        MessageBox.Show("Number cannot be negative");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Must be an integer");
                }
                return number;

            }
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
            this.PauseButton.Enabled = false;
            this.ResumeButton.Enabled = false;
        }

        #endregion

        #region Event generated methods

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void shapeCanvasPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            this.canvasManager.Update(g);
        }

        private void animateButton_Click(object sender, EventArgs e)
        {
                this.animationTimer.Stop();
                
                this.canvasManager.PlaceShapesOnCanvas(this.NumberRandomShapes, this.NumberCircles, this.NumberRectangles, this.NumberSpottedRectangles);

                this.animationTimer.Start();

                this.PauseButton.Enabled = true;
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
            this.canvasManager.ResumeCanvasAnimation();
            this.PauseButton.Enabled = true;
            this.ResumeButton.Enabled = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.canvasManager.ClearCanvas();
            this.PauseButton.Enabled = false;
            this.ResumeButton.Enabled = false;
        }



        #endregion

        private void ShapeAnimatorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shapeDatabaseDataSet.ShapeDatabase' table. You can move, or remove it, as needed.
            this.shapeDatabaseTableAdapter.Fill(this.shapeDatabaseDataSet.ShapeDatabase);

        }


    }
}