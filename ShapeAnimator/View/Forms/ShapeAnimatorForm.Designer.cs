using System.Windows.Forms;
using ShapeAnimator.View.Forms;

namespace ShapeAnimator.View.Forms
{
    partial class ShapeAnimatorForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.canvasPictureBox = new System.Windows.Forms.PictureBox();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.numberOfShapesLabel = new System.Windows.Forms.Label();
            this.numberShapesTextBox = new System.Windows.Forms.TextBox();
            this.animateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // canvasPictureBox
            // 
            this.canvasPictureBox.BackColor = System.Drawing.Color.Black;
            this.canvasPictureBox.Location = new System.Drawing.Point(24, 112);
            this.canvasPictureBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.canvasPictureBox.Name = "canvasPictureBox";
            this.canvasPictureBox.Size = new System.Drawing.Size(1440, 923);
            this.canvasPictureBox.TabIndex = 0;
            this.canvasPictureBox.TabStop = false;
            this.canvasPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.shapeCanvasPictureBox_Paint);
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 200;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // numberOfShapesLabel
            // 
            this.numberOfShapesLabel.AutoSize = true;
            this.numberOfShapesLabel.Location = new System.Drawing.Point(22, 37);
            this.numberOfShapesLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.numberOfShapesLabel.Name = "numberOfShapesLabel";
            this.numberOfShapesLabel.Size = new System.Drawing.Size(190, 25);
            this.numberOfShapesLabel.TabIndex = 1;
            this.numberOfShapesLabel.Text = "Number of Shapes";
            // 
            // numberShapesTextBox
            // 
            this.numberShapesTextBox.Location = new System.Drawing.Point(226, 31);
            this.numberShapesTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numberShapesTextBox.Name = "numberShapesTextBox";
            this.numberShapesTextBox.Size = new System.Drawing.Size(90, 31);
            this.numberShapesTextBox.TabIndex = 2;
            // 
            // animateButton
            // 
            this.animateButton.Location = new System.Drawing.Point(334, 27);
            this.animateButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.animateButton.Name = "animateButton";
            this.animateButton.Size = new System.Drawing.Size(186, 44);
            this.animateButton.TabIndex = 3;
            this.animateButton.Text = "Start Animation";
            this.animateButton.UseVisualStyleBackColor = true;
            this.animateButton.Click += new System.EventHandler(this.animateButton_Click);
            // 
            // ShapeAnimatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 1056);
            this.Controls.Add(this.animateButton);
            this.Controls.Add(this.numberShapesTextBox);
            this.Controls.Add(this.numberOfShapesLabel);
            this.Controls.Add(this.canvasPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ShapeAnimatorForm";
            this.Text = "Shape Animator A4 by Michael Odom and Daniel Burkhart";
            ((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvasPictureBox;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Label numberOfShapesLabel;
        private System.Windows.Forms.TextBox numberShapesTextBox;
        private System.Windows.Forms.Button animateButton;
    }
}

