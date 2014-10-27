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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PauseButton = new System.Windows.Forms.Button();
            this.ResumeButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.rectanglesTextBox = new System.Windows.Forms.TextBox();
            this.circlesTextBox = new System.Windows.Forms.TextBox();
            this.spottedRectanglesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SpeedSlider = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // canvasPictureBox
            // 
            this.canvasPictureBox.BackColor = System.Drawing.Color.Black;
            this.canvasPictureBox.Location = new System.Drawing.Point(15, 174);
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
            this.numberOfShapesLabel.Location = new System.Drawing.Point(18, 17);
            this.numberOfShapesLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.numberOfShapesLabel.Name = "numberOfShapesLabel";
            this.numberOfShapesLabel.Size = new System.Drawing.Size(171, 25);
            this.numberOfShapesLabel.TabIndex = 1;
            this.numberOfShapesLabel.Text = "Random Shapes";
            // 
            // numberShapesTextBox
            // 
            this.numberShapesTextBox.Location = new System.Drawing.Point(202, 12);
            this.numberShapesTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numberShapesTextBox.Name = "numberShapesTextBox";
            this.numberShapesTextBox.Size = new System.Drawing.Size(90, 31);
            this.numberShapesTextBox.TabIndex = 2;
            this.numberShapesTextBox.Text = "0";
            // 
            // animateButton
            // 
            this.animateButton.Location = new System.Drawing.Point(24, 62);
            this.animateButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.animateButton.Name = "animateButton";
            this.animateButton.Size = new System.Drawing.Size(150, 44);
            this.animateButton.TabIndex = 3;
            this.animateButton.Text = "Start";
            this.animateButton.UseVisualStyleBackColor = true;
            this.animateButton.Click += new System.EventHandler(this.animateButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(186, 62);
            this.PauseButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(150, 44);
            this.PauseButton.TabIndex = 4;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            // 
            // ResumeButton
            // 
            this.ResumeButton.Location = new System.Drawing.Point(351, 62);
            this.ResumeButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ResumeButton.Name = "ResumeButton";
            this.ResumeButton.Size = new System.Drawing.Size(150, 44);
            this.ResumeButton.TabIndex = 5;
            this.ResumeButton.Text = "Resume";
            this.ResumeButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(513, 62);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(150, 44);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // rectanglesTextBox
            // 
            this.rectanglesTextBox.Location = new System.Drawing.Point(698, 12);
            this.rectanglesTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rectanglesTextBox.Name = "rectanglesTextBox";
            this.rectanglesTextBox.Size = new System.Drawing.Size(90, 31);
            this.rectanglesTextBox.TabIndex = 7;
            this.rectanglesTextBox.Text = "0";
            // 
            // circlesTextBox
            // 
            this.circlesTextBox.Location = new System.Drawing.Point(428, 12);
            this.circlesTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.circlesTextBox.Name = "circlesTextBox";
            this.circlesTextBox.Size = new System.Drawing.Size(90, 31);
            this.circlesTextBox.TabIndex = 8;
            this.circlesTextBox.Text = "0";
            // 
            // spottedRectanglesTextBox
            // 
            this.spottedRectanglesTextBox.Location = new System.Drawing.Point(1046, 12);
            this.spottedRectanglesTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.spottedRectanglesTextBox.Name = "spottedRectanglesTextBox";
            this.spottedRectanglesTextBox.Size = new System.Drawing.Size(90, 31);
            this.spottedRectanglesTextBox.TabIndex = 9;
            this.spottedRectanglesTextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(832, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Spotted Rectangles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Rectangles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Circles";
            // 
            // SpeedSlider
            // 
            this.SpeedSlider.LargeChange = 100;
            this.SpeedSlider.Location = new System.Drawing.Point(809, 62);
            this.SpeedSlider.Maximum = 500;
            this.SpeedSlider.Name = "SpeedSlider";
            this.SpeedSlider.Size = new System.Drawing.Size(552, 90);
            this.SpeedSlider.SmallChange = 20;
            this.SpeedSlider.TabIndex = 20;
            this.SpeedSlider.TickFrequency = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(714, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Speed: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(721, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "0-500";
            // 
            // ShapeAnimatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 1112);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SpeedSlider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spottedRectanglesTextBox);
            this.Controls.Add(this.circlesTextBox);
            this.Controls.Add(this.rectanglesTextBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ResumeButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.animateButton);
            this.Controls.Add(this.numberShapesTextBox);
            this.Controls.Add(this.numberOfShapesLabel);
            this.Controls.Add(this.canvasPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ShapeAnimatorForm";
            this.Text = "Shape Animator A4 by Odom and Burkhart";
            ((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvasPictureBox;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Label numberOfShapesLabel;
        private System.Windows.Forms.TextBox numberShapesTextBox;
        private System.Windows.Forms.Button animateButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button PauseButton;
        private Button ResumeButton;
        private Button ClearButton;
        private TextBox rectanglesTextBox;
        private TextBox circlesTextBox;
        private TextBox spottedRectanglesTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        public TrackBar SpeedSlider;
    }
}

