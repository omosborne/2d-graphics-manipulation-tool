
namespace GrafPack
{
    partial class GrafPack
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
            this.toolbar = new System.Windows.Forms.Panel();
            this.buttonMouseScale = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonCreateSquare = new System.Windows.Forms.Button();
            this.buttonCreateCircle = new System.Windows.Forms.Button();
            this.buttonCreateTriangle = new System.Windows.Forms.Button();
            this.shapeOptions = new System.Windows.Forms.Panel();
            this.numericTranslateY = new System.Windows.Forms.NumericUpDown();
            this.numericTranslateX = new System.Windows.Forms.NumericUpDown();
            this.buttonTranslate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonFlipVert = new System.Windows.Forms.Button();
            this.buttonFlipHorz = new System.Windows.Forms.Button();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.buttonScale = new System.Windows.Forms.Button();
            this.labelCanvas = new System.Windows.Forms.Label();
            this.labelPen = new System.Windows.Forms.Label();
            this.labelCanvasColour = new System.Windows.Forms.Label();
            this.labelPenColour = new System.Windows.Forms.Label();
            this.divider = new System.Windows.Forms.Label();
            this.numericAngle = new System.Windows.Forms.NumericUpDown();
            this.numericScale = new System.Windows.Forms.NumericUpDown();
            this.labelShapeOptions = new System.Windows.Forms.Label();
            this.comboShapes = new System.Windows.Forms.ComboBox();
            this.canvas = new System.Windows.Forms.Panel();
            this.colorDialogPen = new System.Windows.Forms.ColorDialog();
            this.colorDialogCanvas = new System.Windows.Forms.ColorDialog();
            this.toolbar.SuspendLayout();
            this.shapeOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTranslateY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTranslateX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericScale)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolbar.Controls.Add(this.buttonMouseScale);
            this.toolbar.Controls.Add(this.buttonMove);
            this.toolbar.Controls.Add(this.buttonSelect);
            this.toolbar.Controls.Add(this.buttonCreateSquare);
            this.toolbar.Controls.Add(this.buttonCreateCircle);
            this.toolbar.Controls.Add(this.buttonCreateTriangle);
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(50, 450);
            this.toolbar.TabIndex = 0;
            // 
            // buttonMouseScale
            // 
            this.buttonMouseScale.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonMouseScale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMouseScale.Enabled = false;
            this.buttonMouseScale.Location = new System.Drawing.Point(0, 112);
            this.buttonMouseScale.Name = "buttonMouseScale";
            this.buttonMouseScale.Size = new System.Drawing.Size(50, 50);
            this.buttonMouseScale.TabIndex = 6;
            this.buttonMouseScale.Text = "Scale";
            this.buttonMouseScale.UseVisualStyleBackColor = false;
            this.buttonMouseScale.Click += new System.EventHandler(this.buttonMouseScale_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonMove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMove.Enabled = false;
            this.buttonMove.Location = new System.Drawing.Point(0, 56);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(50, 50);
            this.buttonMove.TabIndex = 5;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = false;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSelect.Location = new System.Drawing.Point(0, 0);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(50, 50);
            this.buttonSelect.TabIndex = 4;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = false;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonCreateSquare
            // 
            this.buttonCreateSquare.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonCreateSquare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateSquare.Location = new System.Drawing.Point(0, 168);
            this.buttonCreateSquare.Name = "buttonCreateSquare";
            this.buttonCreateSquare.Size = new System.Drawing.Size(50, 50);
            this.buttonCreateSquare.TabIndex = 3;
            this.buttonCreateSquare.Text = "□";
            this.buttonCreateSquare.UseVisualStyleBackColor = false;
            this.buttonCreateSquare.Click += new System.EventHandler(this.buttonCreateSquare_Click);
            // 
            // buttonCreateCircle
            // 
            this.buttonCreateCircle.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonCreateCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateCircle.Location = new System.Drawing.Point(0, 280);
            this.buttonCreateCircle.Name = "buttonCreateCircle";
            this.buttonCreateCircle.Size = new System.Drawing.Size(50, 50);
            this.buttonCreateCircle.TabIndex = 2;
            this.buttonCreateCircle.Text = "○";
            this.buttonCreateCircle.UseVisualStyleBackColor = false;
            this.buttonCreateCircle.Click += new System.EventHandler(this.buttonCreateCircle_Click);
            // 
            // buttonCreateTriangle
            // 
            this.buttonCreateTriangle.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonCreateTriangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateTriangle.Location = new System.Drawing.Point(0, 224);
            this.buttonCreateTriangle.Name = "buttonCreateTriangle";
            this.buttonCreateTriangle.Size = new System.Drawing.Size(50, 50);
            this.buttonCreateTriangle.TabIndex = 1;
            this.buttonCreateTriangle.Text = "△";
            this.buttonCreateTriangle.UseVisualStyleBackColor = false;
            this.buttonCreateTriangle.Click += new System.EventHandler(this.buttonCreateTriangle_Click);
            // 
            // shapeOptions
            // 
            this.shapeOptions.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.shapeOptions.Controls.Add(this.numericTranslateY);
            this.shapeOptions.Controls.Add(this.numericTranslateX);
            this.shapeOptions.Controls.Add(this.buttonTranslate);
            this.shapeOptions.Controls.Add(this.buttonDelete);
            this.shapeOptions.Controls.Add(this.buttonFlipVert);
            this.shapeOptions.Controls.Add(this.buttonFlipHorz);
            this.shapeOptions.Controls.Add(this.buttonRotate);
            this.shapeOptions.Controls.Add(this.buttonScale);
            this.shapeOptions.Controls.Add(this.labelCanvas);
            this.shapeOptions.Controls.Add(this.labelPen);
            this.shapeOptions.Controls.Add(this.labelCanvasColour);
            this.shapeOptions.Controls.Add(this.labelPenColour);
            this.shapeOptions.Controls.Add(this.divider);
            this.shapeOptions.Controls.Add(this.numericAngle);
            this.shapeOptions.Controls.Add(this.numericScale);
            this.shapeOptions.Controls.Add(this.labelShapeOptions);
            this.shapeOptions.Controls.Add(this.comboShapes);
            this.shapeOptions.Location = new System.Drawing.Point(650, 0);
            this.shapeOptions.Name = "shapeOptions";
            this.shapeOptions.Size = new System.Drawing.Size(150, 450);
            this.shapeOptions.TabIndex = 4;
            // 
            // numericTranslateY
            // 
            this.numericTranslateY.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.numericTranslateY.Location = new System.Drawing.Point(77, 191);
            this.numericTranslateY.Margin = new System.Windows.Forms.Padding(0);
            this.numericTranslateY.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericTranslateY.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.numericTranslateY.Name = "numericTranslateY";
            this.numericTranslateY.Size = new System.Drawing.Size(64, 20);
            this.numericTranslateY.TabIndex = 20;
            this.numericTranslateY.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numericTranslateX
            // 
            this.numericTranslateX.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.numericTranslateX.Location = new System.Drawing.Point(9, 191);
            this.numericTranslateX.Margin = new System.Windows.Forms.Padding(0);
            this.numericTranslateX.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericTranslateX.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.numericTranslateX.Name = "numericTranslateX";
            this.numericTranslateX.Size = new System.Drawing.Size(64, 20);
            this.numericTranslateX.TabIndex = 19;
            this.numericTranslateX.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTranslate.Enabled = false;
            this.buttonTranslate.Location = new System.Drawing.Point(6, 168);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(135, 20);
            this.buttonTranslate.TabIndex = 18;
            this.buttonTranslate.Text = "Translate";
            this.buttonTranslate.UseVisualStyleBackColor = true;
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(6, 418);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(138, 20);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonFlipVert
            // 
            this.buttonFlipVert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFlipVert.Enabled = false;
            this.buttonFlipVert.Location = new System.Drawing.Point(6, 318);
            this.buttonFlipVert.Name = "buttonFlipVert";
            this.buttonFlipVert.Size = new System.Drawing.Size(138, 20);
            this.buttonFlipVert.TabIndex = 16;
            this.buttonFlipVert.Text = "Flip Vertically";
            this.buttonFlipVert.UseVisualStyleBackColor = true;
            this.buttonFlipVert.Click += new System.EventHandler(this.buttonFlipVert_Click);
            // 
            // buttonFlipHorz
            // 
            this.buttonFlipHorz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFlipHorz.Enabled = false;
            this.buttonFlipHorz.Location = new System.Drawing.Point(6, 292);
            this.buttonFlipHorz.Name = "buttonFlipHorz";
            this.buttonFlipHorz.Size = new System.Drawing.Size(138, 20);
            this.buttonFlipHorz.TabIndex = 15;
            this.buttonFlipHorz.Text = "Flip Horizontally";
            this.buttonFlipHorz.UseVisualStyleBackColor = true;
            this.buttonFlipHorz.Click += new System.EventHandler(this.buttonFlipHorz_Click);
            // 
            // buttonRotate
            // 
            this.buttonRotate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRotate.Enabled = false;
            this.buttonRotate.Location = new System.Drawing.Point(6, 254);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(71, 20);
            this.buttonRotate.TabIndex = 14;
            this.buttonRotate.Text = "Rotate";
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // buttonScale
            // 
            this.buttonScale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonScale.Enabled = false;
            this.buttonScale.Location = new System.Drawing.Point(6, 224);
            this.buttonScale.Name = "buttonScale";
            this.buttonScale.Size = new System.Drawing.Size(71, 20);
            this.buttonScale.TabIndex = 13;
            this.buttonScale.Text = "Scale";
            this.buttonScale.UseVisualStyleBackColor = true;
            this.buttonScale.Click += new System.EventHandler(this.buttonScale_Click);
            // 
            // labelCanvas
            // 
            this.labelCanvas.AutoSize = true;
            this.labelCanvas.ForeColor = System.Drawing.Color.White;
            this.labelCanvas.Location = new System.Drawing.Point(77, 19);
            this.labelCanvas.Name = "labelCanvas";
            this.labelCanvas.Size = new System.Drawing.Size(46, 13);
            this.labelCanvas.TabIndex = 12;
            this.labelCanvas.Text = "Canvas:";
            // 
            // labelPen
            // 
            this.labelPen.AutoSize = true;
            this.labelPen.ForeColor = System.Drawing.Color.White;
            this.labelPen.Location = new System.Drawing.Point(17, 19);
            this.labelPen.Name = "labelPen";
            this.labelPen.Size = new System.Drawing.Size(29, 13);
            this.labelPen.TabIndex = 11;
            this.labelPen.Text = "Pen:";
            // 
            // labelCanvasColour
            // 
            this.labelCanvasColour.BackColor = System.Drawing.Color.White;
            this.labelCanvasColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCanvasColour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCanvasColour.Location = new System.Drawing.Point(80, 41);
            this.labelCanvasColour.Name = "labelCanvasColour";
            this.labelCanvasColour.Size = new System.Drawing.Size(50, 50);
            this.labelCanvasColour.TabIndex = 10;
            this.labelCanvasColour.Click += new System.EventHandler(this.labelCanvasColour_Click);
            // 
            // labelPenColour
            // 
            this.labelPenColour.BackColor = System.Drawing.Color.Black;
            this.labelPenColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPenColour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPenColour.Location = new System.Drawing.Point(20, 41);
            this.labelPenColour.Name = "labelPenColour";
            this.labelPenColour.Size = new System.Drawing.Size(50, 50);
            this.labelPenColour.TabIndex = 9;
            this.labelPenColour.Click += new System.EventHandler(this.labelPenColour_Click);
            // 
            // divider
            // 
            this.divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider.Location = new System.Drawing.Point(6, 104);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(139, 2);
            this.divider.TabIndex = 8;
            // 
            // numericAngle
            // 
            this.numericAngle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.numericAngle.Location = new System.Drawing.Point(80, 254);
            this.numericAngle.Margin = new System.Windows.Forms.Padding(0);
            this.numericAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericAngle.Name = "numericAngle";
            this.numericAngle.Size = new System.Drawing.Size(64, 20);
            this.numericAngle.TabIndex = 7;
            this.numericAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // numericScale
            // 
            this.numericScale.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.numericScale.DecimalPlaces = 1;
            this.numericScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericScale.Location = new System.Drawing.Point(80, 224);
            this.numericScale.Margin = new System.Windows.Forms.Padding(0);
            this.numericScale.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericScale.Name = "numericScale";
            this.numericScale.Size = new System.Drawing.Size(64, 20);
            this.numericScale.TabIndex = 4;
            this.numericScale.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // labelShapeOptions
            // 
            this.labelShapeOptions.AutoSize = true;
            this.labelShapeOptions.ForeColor = System.Drawing.Color.White;
            this.labelShapeOptions.Location = new System.Drawing.Point(3, 112);
            this.labelShapeOptions.Name = "labelShapeOptions";
            this.labelShapeOptions.Size = new System.Drawing.Size(77, 13);
            this.labelShapeOptions.TabIndex = 1;
            this.labelShapeOptions.Text = "Shape Options";
            // 
            // comboShapes
            // 
            this.comboShapes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.comboShapes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboShapes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboShapes.ForeColor = System.Drawing.Color.White;
            this.comboShapes.FormattingEnabled = true;
            this.comboShapes.Location = new System.Drawing.Point(6, 132);
            this.comboShapes.Margin = new System.Windows.Forms.Padding(0);
            this.comboShapes.Name = "comboShapes";
            this.comboShapes.Size = new System.Drawing.Size(138, 21);
            this.comboShapes.TabIndex = 0;
            this.comboShapes.SelectedIndexChanged += new System.EventHandler(this.comboShapes_SelectedIndexChanged);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(50, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(600, 450);
            this.canvas.TabIndex = 5;
            this.canvas.MouseEnter += new System.EventHandler(this.canvas_MouseEnter);
            // 
            // colorDialogPen
            // 
            this.colorDialogPen.AnyColor = true;
            // 
            // colorDialogCanvas
            // 
            this.colorDialogCanvas.AnyColor = true;
            this.colorDialogCanvas.Color = System.Drawing.Color.White;
            // 
            // GrafPack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.shapeOptions);
            this.Controls.Add(this.toolbar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GrafPack";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrafPack Shape Manipulation Program";
            this.toolbar.ResumeLayout(false);
            this.shapeOptions.ResumeLayout(false);
            this.shapeOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTranslateY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTranslateX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericScale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toolbar;
        private System.Windows.Forms.Button buttonCreateTriangle;
        private System.Windows.Forms.Button buttonCreateCircle;
        private System.Windows.Forms.Button buttonCreateSquare;
        private System.Windows.Forms.Panel shapeOptions;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Label labelShapeOptions;
        private System.Windows.Forms.ComboBox comboShapes;
        private System.Windows.Forms.NumericUpDown numericAngle;
        private System.Windows.Forms.NumericUpDown numericScale;
        private System.Windows.Forms.ColorDialog colorDialogPen;
        private System.Windows.Forms.Label labelCanvas;
        private System.Windows.Forms.Label labelPen;
        private System.Windows.Forms.Label labelCanvasColour;
        private System.Windows.Forms.Label labelPenColour;
        private System.Windows.Forms.Label divider;
        private System.Windows.Forms.ColorDialog colorDialogCanvas;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonMouseScale;
        private System.Windows.Forms.Button buttonScale;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonFlipVert;
        private System.Windows.Forms.Button buttonFlipHorz;
        private System.Windows.Forms.NumericUpDown numericTranslateX;
        private System.Windows.Forms.Button buttonTranslate;
        private System.Windows.Forms.NumericUpDown numericTranslateY;
    }
}

