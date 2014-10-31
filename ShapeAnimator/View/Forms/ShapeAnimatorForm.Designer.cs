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
            this.rectanglesTextBox = new System.Windows.Forms.TextBox();
            this.circlesTextBox = new System.Windows.Forms.TextBox();
            this.spottedRectanglesTextBox = new System.Windows.Forms.TextBox();
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
            this.perimeterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collisionCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shapeDatabaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shapeDatabaseDataSet = new ShapeAnimator.ShapeDatabaseDataSet();
            this.shapeDatabaseTableAdapter = new ShapeAnimator.ShapeDatabaseDataSetTableAdapters.ShapeDatabaseTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeDatabaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // canvasPictureBox
            // 
            this.canvasPictureBox.BackColor = System.Drawing.Color.Black;
            this.canvasPictureBox.Location = new System.Drawing.Point(16, 173);
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
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(24, 62);
            this.startButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.PauseButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.ResumeButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.ClearButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(150, 44);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.clearButton_Click);
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
            this.SpeedSlider.LargeChange = 50;
            this.SpeedSlider.Location = new System.Drawing.Point(808, 62);
            this.SpeedSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.shapeTypeDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.perimeterDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.collisionCountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.shapeDatabaseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(372, 1108);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1084, 238);
            this.dataGridView1.TabIndex = 23;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // shapeTypeDataGridViewTextBoxColumn
            // 
            this.shapeTypeDataGridViewTextBoxColumn.DataPropertyName = "Shape Type";
            this.shapeTypeDataGridViewTextBoxColumn.HeaderText = "Shape Type";
            this.shapeTypeDataGridViewTextBoxColumn.Name = "shapeTypeDataGridViewTextBoxColumn";
            this.shapeTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perimeterDataGridViewTextBoxColumn
            // 
            this.perimeterDataGridViewTextBoxColumn.DataPropertyName = "PerimeterProperty";
            this.perimeterDataGridViewTextBoxColumn.HeaderText = "PerimeterProperty";
            this.perimeterDataGridViewTextBoxColumn.Name = "perimeterDataGridViewTextBoxColumn";
            this.perimeterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // collisionCountDataGridViewTextBoxColumn
            // 
            this.collisionCountDataGridViewTextBoxColumn.DataPropertyName = "Collision Count";
            this.collisionCountDataGridViewTextBoxColumn.HeaderText = "Collision Count";
            this.collisionCountDataGridViewTextBoxColumn.Name = "collisionCountDataGridViewTextBoxColumn";
            this.collisionCountDataGridViewTextBoxColumn.ReadOnly = true;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PerimeterProperty",
            "Area",
            "Type Then Color",
            "Collision Count Then Shape Type"});
            this.comboBox1.Location = new System.Drawing.Point(16, 1173);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(332, 33);
            this.comboBox1.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 1142);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Sort By:";
            // 
            // ShapeAnimatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 1369);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
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
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.numberShapesTextBox);
            this.Controls.Add(this.numberOfShapesLabel);
            this.Controls.Add(this.canvasPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ShapeAnimatorForm";
            this.Text = "Shape Animator A4 by Odom and Burkhart";
            this.Load += new System.EventHandler(this.ShapeAnimatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeDatabaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeDatabaseDataSet)).EndInit();
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
        private TextBox rectanglesTextBox;
        private TextBox circlesTextBox;
        private TextBox spottedRectanglesTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        public TrackBar SpeedSlider;
        private DataGridView dataGridView1;
        private ShapeDatabaseDataSet shapeDatabaseDataSet;
        private BindingSource shapeDatabaseBindingSource;
        private ShapeDatabaseDataSetTableAdapters.ShapeDatabaseTableAdapter shapeDatabaseTableAdapter;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shapeTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn perimeterDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn collisionCountDataGridViewTextBoxColumn;
        private ComboBox comboBox1;
        private Label label6;
    }
}

