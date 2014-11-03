using System.Collections;
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
            this.startButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PauseButton = new System.Windows.Forms.Button();
            this.ResumeButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.RectanglesTextBox = new System.Windows.Forms.TextBox();
            this.CirclesTextBox = new System.Windows.Forms.TextBox();
            this.SpottedRectanglesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SpeedSlider = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShapeTypeThenColor = new System.Windows.Forms.Button();
            this.Perimeter = new System.Windows.Forms.Button();
            this.CollisionsAndShapeType = new System.Windows.Forms.Button();
            this.Area = new System.Windows.Forms.Button();
            this.ShapeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerimeterProperty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollisionCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvasPictureBox
            // 
            this.canvasPictureBox.BackColor = System.Drawing.Color.Black;
            this.canvasPictureBox.Location = new System.Drawing.Point(16, 173);
            this.canvasPictureBox.Margin = new System.Windows.Forms.Padding(6);
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
            this.numberShapesTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.numberShapesTextBox.Name = "numberShapesTextBox";
            this.numberShapesTextBox.Size = new System.Drawing.Size(90, 31);
            this.numberShapesTextBox.TabIndex = 2;
            this.numberShapesTextBox.Text = "0";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(24, 62);
            this.startButton.Margin = new System.Windows.Forms.Padding(6);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(150, 44);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.animateButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(186, 62);
            this.PauseButton.Margin = new System.Windows.Forms.Padding(6);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(150, 44);
            this.PauseButton.TabIndex = 4;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // ResumeButton
            // 
            this.ResumeButton.Location = new System.Drawing.Point(352, 62);
            this.ResumeButton.Margin = new System.Windows.Forms.Padding(6);
            this.ResumeButton.Name = "ResumeButton";
            this.ResumeButton.Size = new System.Drawing.Size(150, 44);
            this.ResumeButton.TabIndex = 5;
            this.ResumeButton.Text = "Resume";
            this.ResumeButton.UseVisualStyleBackColor = true;
            this.ResumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(512, 62);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(6);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(150, 44);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // RectanglesTextBox
            // 
            this.RectanglesTextBox.Location = new System.Drawing.Point(698, 12);
            this.RectanglesTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.RectanglesTextBox.Name = "RectanglesTextBox";
            this.RectanglesTextBox.Size = new System.Drawing.Size(90, 31);
            this.RectanglesTextBox.TabIndex = 7;
            this.RectanglesTextBox.Text = "0";
            // 
            // CirclesTextBox
            // 
            this.CirclesTextBox.Location = new System.Drawing.Point(428, 12);
            this.CirclesTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.CirclesTextBox.Name = "CirclesTextBox";
            this.CirclesTextBox.Size = new System.Drawing.Size(90, 31);
            this.CirclesTextBox.TabIndex = 8;
            this.CirclesTextBox.Text = "0";
            // 
            // SpottedRectanglesTextBox
            // 
            this.SpottedRectanglesTextBox.Location = new System.Drawing.Point(1046, 12);
            this.SpottedRectanglesTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.SpottedRectanglesTextBox.Name = "SpottedRectanglesTextBox";
            this.SpottedRectanglesTextBox.Size = new System.Drawing.Size(90, 31);
            this.SpottedRectanglesTextBox.TabIndex = 9;
            this.SpottedRectanglesTextBox.Text = "0";
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
            this.SpeedSlider.LargeChange = 50;
            this.SpeedSlider.Location = new System.Drawing.Point(808, 62);
            this.SpeedSlider.Margin = new System.Windows.Forms.Padding(4);
            this.SpeedSlider.Maximum = 500;
            this.SpeedSlider.Name = "SpeedSlider";
            this.SpeedSlider.Size = new System.Drawing.Size(552, 90);
            this.SpeedSlider.SmallChange = 20;
            this.SpeedSlider.TabIndex = 20;
            this.SpeedSlider.TickFrequency = 50;
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
            this.label5.Location = new System.Drawing.Point(720, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "0-500";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShapeType,
            this.Color,
            this.PerimeterProperty,
            this.AreaColumn,
            this.CollisionCount});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(380, 1108);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(1092, 238);
            this.dataGridView1.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShapeTypeThenColor);
            this.groupBox1.Controls.Add(this.Perimeter);
            this.groupBox1.Controls.Add(this.CollisionsAndShapeType);
            this.groupBox1.Controls.Add(this.Area);
            this.groupBox1.Location = new System.Drawing.Point(16, 1108);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(354, 237);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort By:";
            // 
            // ShapeTypeThenColor
            // 
            this.ShapeTypeThenColor.Location = new System.Drawing.Point(20, 163);
            this.ShapeTypeThenColor.Margin = new System.Windows.Forms.Padding(4);
            this.ShapeTypeThenColor.Name = "ShapeTypeThenColor";
            this.ShapeTypeThenColor.Size = new System.Drawing.Size(290, 65);
            this.ShapeTypeThenColor.TabIndex = 3;
            this.ShapeTypeThenColor.Text = "Shape Type And Color";
            this.ShapeTypeThenColor.UseVisualStyleBackColor = true;
            this.ShapeTypeThenColor.Click += new System.EventHandler(this.shapeThenColor_Click);
            // 
            // Perimeter
            // 
            this.Perimeter.Location = new System.Drawing.Point(186, 48);
            this.Perimeter.Margin = new System.Windows.Forms.Padding(4);
            this.Perimeter.Name = "Perimeter";
            this.Perimeter.Size = new System.Drawing.Size(124, 38);
            this.Perimeter.TabIndex = 2;
            this.Perimeter.Text = "Perimeter";
            this.Perimeter.UseVisualStyleBackColor = true;
            this.Perimeter.Click += new System.EventHandler(this.perimeter_Click);
            // 
            // CollisionsAndShapeType
            // 
            this.CollisionsAndShapeType.Location = new System.Drawing.Point(20, 106);
            this.CollisionsAndShapeType.Margin = new System.Windows.Forms.Padding(4);
            this.CollisionsAndShapeType.Name = "CollisionsAndShapeType";
            this.CollisionsAndShapeType.Size = new System.Drawing.Size(290, 42);
            this.CollisionsAndShapeType.TabIndex = 1;
            this.CollisionsAndShapeType.Text = "Collisions And Shape Type";
            this.CollisionsAndShapeType.UseVisualStyleBackColor = true;
            this.CollisionsAndShapeType.Click += new System.EventHandler(this.collisionThenShape_Click);
            // 
            // Area
            // 
            this.Area.Location = new System.Drawing.Point(20, 48);
            this.Area.Margin = new System.Windows.Forms.Padding(4);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(104, 38);
            this.Area.TabIndex = 0;
            this.Area.Text = "Area";
            this.Area.UseVisualStyleBackColor = true;
            this.Area.Click += new System.EventHandler(this.area_Click);
            // 
            // ShapeType
            // 
            this.ShapeType.HeaderText = "Shape Type";
            this.ShapeType.Name = "ShapeType";
            this.ShapeType.Width = 153;
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.Width = 88;
            // 
            // PerimeterProperty
            // 
            this.PerimeterProperty.DataPropertyName = "PerimeterProperty";
            this.PerimeterProperty.HeaderText = "Perimeter";
            this.PerimeterProperty.Name = "PerimeterProperty";
            this.PerimeterProperty.Width = 129;
            // 
            // AreaColumn
            // 
            this.AreaColumn.HeaderText = "Area";
            this.AreaColumn.Name = "AreaColumn";
            this.AreaColumn.Width = 82;
            // 
            // CollisionCount
            // 
            this.CollisionCount.HeaderText = "Collision Count";
            this.CollisionCount.Name = "CollisionCount";
            this.CollisionCount.Width = 166;
            // 
            // ShapeAnimatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 1365);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SpeedSlider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpottedRectanglesTextBox);
            this.Controls.Add(this.CirclesTextBox);
            this.Controls.Add(this.RectanglesTextBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ResumeButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.numberShapesTextBox);
            this.Controls.Add(this.numberOfShapesLabel);
            this.Controls.Add(this.canvasPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ShapeAnimatorForm";
            this.Text = "Shape Animator A4 by Odom and Burkhart";

            ((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvasPictureBox;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Label numberOfShapesLabel;
        private System.Windows.Forms.TextBox numberShapesTextBox;
        private System.Windows.Forms.Button startButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button PauseButton;
        private Button ResumeButton;
        private Button ClearButton;
        private TextBox RectanglesTextBox;
        private TextBox CirclesTextBox;
        private TextBox SpottedRectanglesTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TrackBar SpeedSlider;
        private DataGridView dataGridView1;

        private GroupBox groupBox1;
        private Button ShapeTypeThenColor;
        private Button Perimeter;
        private Button CollisionsAndShapeType;
        private Button Area;
        private DataGridViewTextBoxColumn ShapeType;
        private DataGridViewTextBoxColumn Color;
        private DataGridViewTextBoxColumn PerimeterProperty;
        private DataGridViewTextBoxColumn AreaColumn;
        private DataGridViewTextBoxColumn CollisionCount;
    }
}

