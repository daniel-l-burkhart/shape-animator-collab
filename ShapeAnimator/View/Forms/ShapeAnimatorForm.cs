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
        public int NumberShapes
        {
            get
            {
                try
                {
                    return Convert.ToInt32(this.numberShapesTextBox.Text);
                }
                catch (Exception)
                {
                    return 0;
                }
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
            int n;
            bool isNumeric = int.TryParse(this.numberShapesTextBox.Text, out n);
            if (isNumeric)
            {
                this.animationTimer.Stop();

                this.canvasManager.PlaceShapesOnCanvas(n);

                this.animationTimer.Start();
            }
            else
            {
                MessageBox.Show(@"Must be of type int");
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
         
        }



        #endregion

        private void ShapeAnimatorForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}