using System.Windows.Forms;
using ShapeAnimator.ShapeDatabaseDataSetTableAdapters;
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
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shapeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerimeterProperty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collisionCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shapeDatabaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shapeDatabaseDataSet = new ShapeAnimator.ShapeDatabaseDataSet();
            this.shapeDatabaseTableAdapter = new ShapeAnimator.ShapeDatabaseDataSetTableAdapters.ShapeDatabaseTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShapeTypeThenColor = new System.Windows.Forms.Button();
            this.Perimeter = new System.Windows.Forms.Button();
            this.CollisionsAndShapeType = new System.Windows.Forms.Button();
            this.Area = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeDatabaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeDatabaseDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvasPictureBox
            // 
            this.canvasPictureBox.BackColor = System.Drawing.Color.Black;
            this.canvasPictureBox.Location = new System.Drawing.Point(8, 90);
            this.canvasPictureBox.Name = "canvasPictureBox";
            this.canvasPictureBox.Size = new System.Drawing.Size(720, 480);
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
            this.numberOfShapesLabel.Location = new System.Drawing.Point(9, 9);
            this.numberOfShapesLabel.Name = "numberOfShapesLabel";
            this.numberOfShapesLabel.Size = new System.Drawing.Size(86, 13);
            this.numberOfShapesLabel.TabIndex = 1;
            this.numberOfShapesLabel.Text = "Random Shapes";
            // 
            // numberShapesTextBox
            // 
            this.numberShapesTextBox.Location = new System.Drawing.Point(101, 6);
            this.numberShapesTextBox.Name = "numberShapesTextBox";
            this.numberShapesTextBox.Size = new System.Drawing.Size(47, 20);
            this.numberShapesTextBox.TabIndex = 2;
            this.numberShapesTextBox.Text = "0";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 32);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.animateButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(93, 32);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(75, 23);
            this.PauseButton.TabIndex = 4;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // ResumeButton
            // 
            this.ResumeButton.Location = new System.Drawing.Point(176, 32);
            this.ResumeButton.Name = "ResumeButton";
            this.ResumeButton.Size = new System.Drawing.Size(75, 23);
            this.ResumeButton.TabIndex = 5;
            this.ResumeButton.Text = "Resume";
            this.ResumeButton.UseVisualStyleBackColor = true;
            this.ResumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(256, 32);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // RectanglesTextBox
            // 
            this.RectanglesTextBox.Location = new System.Drawing.Point(349, 6);
            this.RectanglesTextBox.Name = "RectanglesTextBox";
            this.RectanglesTextBox.Size = new System.Drawing.Size(47, 20);
            this.RectanglesTextBox.TabIndex = 7;
            this.RectanglesTextBox.Text = "0";
            // 
            // CirclesTextBox
            // 
            this.CirclesTextBox.Location = new System.Drawing.Point(214, 6);
            this.CirclesTextBox.Name = "CirclesTextBox";
            this.CirclesTextBox.Size = new System.Drawing.Size(47, 20);
            this.CirclesTextBox.TabIndex = 8;
            this.CirclesTextBox.Text = "0";
            // 
            // SpottedRectanglesTextBox
            // 
            this.SpottedRectanglesTextBox.Location = new System.Drawing.Point(523, 6);
            this.SpottedRectanglesTextBox.Name = "SpottedRectanglesTextBox";
            this.SpottedRectanglesTextBox.Size = new System.Drawing.Size(47, 20);
            this.SpottedRectanglesTextBox.TabIndex = 9;
            this.SpottedRectanglesTextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Spotted Rectangles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Rectangles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Circles";
            // 
            // SpeedSlider
            // 
            this.SpeedSlider.LargeChange = 50;
            this.SpeedSlider.Location = new System.Drawing.Point(404, 32);
            this.SpeedSlider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SpeedSlider.Maximum = 500;
            this.SpeedSlider.Name = "SpeedSlider";
            this.SpeedSlider.Size = new System.Drawing.Size(276, 45);
            this.SpeedSlider.SmallChange = 20;
            this.SpeedSlider.TabIndex = 20;
            this.SpeedSlider.TickFrequency = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Speed: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "0-500";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.shapeTypeDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.PerimeterProperty,
            this.collisionCountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.shapeDatabaseBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(190, 576);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(546, 124);
            this.dataGridView1.TabIndex = 23;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // shapeTypeDataGridViewTextBoxColumn
            // 
            this.shapeTypeDataGridViewTextBoxColumn.DataPropertyName = "Shape Type";
            this.shapeTypeDataGridViewTextBoxColumn.HeaderText = "Shape Type";
            this.shapeTypeDataGridViewTextBoxColumn.Name = "shapeTypeDataGridViewTextBoxColumn";
            this.shapeTypeDataGridViewTextBoxColumn.Width = 90;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.Width = 56;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.Width = 54;
            // 
            // PerimeterProperty
            // 
            this.PerimeterProperty.DataPropertyName = "PerimeterProperty";
            this.PerimeterProperty.HeaderText = "Perimeter";
            this.PerimeterProperty.Name = "PerimeterProperty";
            this.PerimeterProperty.Width = 76;
            // 
            // collisionCountDataGridViewTextBoxColumn
            // 
            this.collisionCountDataGridViewTextBoxColumn.DataPropertyName = "Collision Count";
            this.collisionCountDataGridViewTextBoxColumn.HeaderText = "Collision Count";
            this.collisionCountDataGridViewTextBoxColumn.Name = "collisionCountDataGridViewTextBoxColumn";
            this.collisionCountDataGridViewTextBoxColumn.Width = 101;
            // 
            // shapeDatabaseBindingSource
            // 
            this.shapeDatabaseBindingSource.DataMember = "ShapeDatabase";
            this.shapeDatabaseBindingSource.DataSource = this.shapeDatabaseDataSet;
            // 
            // shapeDatabaseDataSet
            // 
            this.shapeDatabaseDataSet.DataSetName = "ShapeDatabaseDataSet";
            this.shapeDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shapeDatabaseTableAdapter
            // 
            this.shapeDatabaseTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShapeTypeThenColor);
            this.groupBox1.Controls.Add(this.Perimeter);
            this.groupBox1.Controls.Add(this.CollisionsAndShapeType);
            this.groupBox1.Controls.Add(this.Area);
            this.groupBox1.Location = new System.Drawing.Point(8, 576);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(177, 123);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort By:";
            // 
            // ShapeTypeThenColor
            // 
            this.ShapeTypeThenColor.Location = new System.Drawing.Point(10, 85);
            this.ShapeTypeThenColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShapeTypeThenColor.Name = "ShapeTypeThenColor";
            this.ShapeTypeThenColor.Size = new System.Drawing.Size(145, 34);
            this.ShapeTypeThenColor.TabIndex = 3;
            this.ShapeTypeThenColor.Text = "Shape Type And Color";
            this.ShapeTypeThenColor.UseVisualStyleBackColor = true;
            this.ShapeTypeThenColor.Click += new System.EventHandler(this.shapeThenColor_Click);
            // 
            // Perimeter
            // 
            this.Perimeter.Location = new System.Drawing.Point(93, 25);
            this.Perimeter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Perimeter.Name = "Perimeter";
            this.Perimeter.Size = new System.Drawing.Size(62, 20);
            this.Perimeter.TabIndex = 2;
            this.Perimeter.Text = "Perimeter";
            this.Perimeter.UseVisualStyleBackColor = true;
            this.Perimeter.Click += new System.EventHandler(this.perimeter_Click);
            // 
            // CollisionsAndShapeType
            // 
            this.CollisionsAndShapeType.Location = new System.Drawing.Point(10, 55);
            this.CollisionsAndShapeType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CollisionsAndShapeType.Name = "CollisionsAndShapeType";
            this.CollisionsAndShapeType.Size = new System.Drawing.Size(145, 22);
            this.CollisionsAndShapeType.TabIndex = 1;
            this.CollisionsAndShapeType.Text = "Collisions And Shape Type";
            this.CollisionsAndShapeType.UseVisualStyleBackColor = true;
            this.CollisionsAndShapeType.Click += new System.EventHandler(this.collisionThenShape_Click);
            // 
            // Area
            // 
            this.Area.Location = new System.Drawing.Point(10, 25);
            this.Area.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(52, 20);
            this.Area.TabIndex = 0;
            this.Area.Text = "Area";
            this.Area.UseVisualStyleBackColor = true;
            this.Area.Click += new System.EventHandler(this.area_Click);
            // 
            // ShapeAnimatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 710);
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
            this.Name = "ShapeAnimatorForm";
            this.Text = "Shape Animator A4 by Odom and Burkhart";
            this.Load += new System.EventHandler(this.ShapeAnimatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeDatabaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeDatabaseDataSet)).EndInit();
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
        private ShapeDatabaseDataSet shapeDatabaseDataSet;
        private BindingSource shapeDatabaseBindingSource;
        private ShapeDatabaseDataSetTableAdapters.ShapeDatabaseTableAdapter shapeDatabaseTableAdapter;
        private DataGridViewTextBoxColumn perimeterDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shapeTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn PerimeterProperty;
        private DataGridViewTextBoxColumn collisionCountDataGridViewTextBoxColumn;
        private GroupBox groupBox1;
        private Button ShapeTypeThenColor;
        private Button Perimeter;
        private Button CollisionsAndShapeType;
        private Button Area;
    }
}

