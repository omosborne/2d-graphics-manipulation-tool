using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GrafPack
{
    /// <summary>
    /// The GrafPack class provides the main application functionality,
    /// from UI, to intiating operations via mouse or button clicks.
    /// </summary>
    public partial class GrafPack : Form
    {
        // Canvas mouse operation mode constants.
        private const int DRAW      = 0;
        private const int SELECT    = 1;
        private const int MOVE      = 2;
        private const int SCALE     = 3;

        // Active canvas mouse operation mode.
        private int currentMode = SELECT;

        private bool drawingSquare      = false;
        private bool drawingTriangle    = false;
        private bool drawingCircle      = false;

        // Detect action has begun when mouse pressed.
        private bool isDrawingShape     = false;
        private bool isMovingShape      = false;
        private bool isScalingShape     = false;

        // Program colours.
        private Color canvasColour;
        private Pen penColour;
        private Pen highlightColour;

        // List data structure to hold active selectable shapes.
        private List<Shape> shapes = new List<Shape>();

        // Containers for the drawn and selected shapes.
        private Shape selectedShape;
        private Shape drawnShape;

        // Double buffer.
        Bitmap backBufferBitmap;

        // Constructor.
        public GrafPack()
        {
            // Windows forms sets up UI components created in the designer.
            InitializeComponent();
            
            // Get pen and canvas colours from UI.
            canvasColour = colorDialogCanvas.Color;
            penColour = new Pen(colorDialogPen.Color);

            // Dashed red line for selected shapes.
            highlightColour = new Pen(Color.Red);
            highlightColour.Width = 3.0F;
            highlightColour.DashPattern = new float[] { 4.0F, 4.0F };

            // Initialise the back buffer with the canvas size.
            backBufferBitmap = new Bitmap(canvas.Width, canvas.Height);

            // Allow the user to create a new canvas and quit the program.
            MainMenu optionsMenu    = new MainMenu();
            MenuItem newCanvas      = new MenuItem();
            MenuItem quitProgram    = new MenuItem();

            newCanvas.Text      = "New Canvas";
            quitProgram.Text    = "Quit";

            optionsMenu.MenuItems.Add(newCanvas);
            optionsMenu.MenuItems.Add(quitProgram);

            newCanvas.Click     += new EventHandler(NewCanvas);
            quitProgram.Click   += new EventHandler(QuitProgram);

            Menu = optionsMenu;

            // Link canvas event triggers with handlers.
            canvas.MouseClick   += MouseClicked;
            canvas.MouseDown    += MousePressed;
            canvas.MouseUp      += MouseReleased;
            canvas.Paint        += new PaintEventHandler(Canvas_Paint);
            canvas.MouseMove    += UpdateCanvas;
        }

        // Provide the shape selection box with a shape.
        private void AddShapeToCombo(Shape shape)
        {
            comboShapes.Items.Add(shape);
        }

        // This will clear the canvas of all shapes and selections.
        private void NewCanvas(object sender, EventArgs e)
        {
            comboShapes.Items.Clear();
            shapes.Clear();
            SelectShape(null);
            SetMode(SELECT);
            drawnShape = null;
            UpdateActiveButton(buttonSelect);
            UpdateCanvas(sender, e);
        }

        // Cleanly close the application at the user's request.
        private void QuitProgram(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Set the selected shape. Enable/disable buttons that
        // rely on a selected shape for better user experience
        // and error handling.
        private void SelectShape(Shape shape)
        {
            if (shape != null)
            {
                selectedShape = shape;
                comboShapes.SelectedItem = shape;

                // Enable all operation buttons.
                buttonMove.Enabled          = true;
                buttonMouseScale.Enabled    = true;
                buttonTranslate.Enabled     = true;
                buttonScale.Enabled         = true;
                buttonRotate.Enabled        = true;
                buttonFlipHorz.Enabled      = true;
                buttonFlipVert.Enabled      = true;
                buttonDelete.Enabled        = true;
            }
            else
            {
                selectedShape = null;
                comboShapes.SelectedItem = null;

                // Disable all operation buttons.
                buttonMove.Enabled          = false;
                buttonMouseScale.Enabled    = false;
                buttonTranslate.Enabled     = false;
                buttonScale.Enabled         = false;
                buttonRotate.Enabled        = false;
                buttonFlipHorz.Enabled      = false;
                buttonFlipVert.Enabled      = false;
                buttonDelete.Enabled        = false;
            }
        }

        // Remove a shape, deselect it, and change
        // operation mode back to select.
        private void DeleteShape(object sender, EventArgs e)
        {
            if (selectedShape != null)
            {
                comboShapes.Items.Remove(selectedShape);
                shapes.Remove(selectedShape);
                SelectShape(null);
                SetMode(SELECT);
                UpdateCanvas(sender, e);
            }
        }

        // Selection mode handler for a mouse clicking on a
        // shape's vertex to select the shape. Clicking on
        // an empty area will deselect the shape.
        private void MouseClicked(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (currentMode == SELECT)
                {
                    bool shapeFound = false;
                    foreach (Shape shape in shapes)
                    {
                        foreach (Point vertex in shape.GetVertices())
                        {
                            if (IsMouseOnVertex(vertex, e))
                            {
                                shapeFound = true;
                                SelectShape(shape);
                                break;
                            }
                        }
                    }
                    if (!shapeFound) SelectShape(null);
                }
            }
        }

        // Determine if the mouse position is over a shape's vertex.
        // A buffer of 6 pixels is provided so the user can click a
        // vertex' area easier.
        private bool IsMouseOnVertex(Point vertex, MouseEventArgs e)
        {
            return e.Location.X <= vertex.X + 3 &&
                e.Location.X >= vertex.X - 3 &&
                e.Location.Y <= vertex.Y + 3 &&
                e.Location.Y >= vertex.Y - 3;
        }

        // Handler for rubber-banding mouse down.
        private void MousePressed(object sender, MouseEventArgs e)
        {
            // Begin drawing a shape.
            if (currentMode == DRAW)
            {
                // Create shape at the mouse location on the canvas.
                Point startPoint = new Point(e.X, e.Y);

                // Instantiate a concrete shape implementation.
                if (drawingSquare)          drawnShape = new Square(startPoint);
                else if (drawingTriangle)   drawnShape = new Triangle(startPoint);
                else if (drawingCircle)     drawnShape = new Circle(startPoint);

                isDrawingShape = true;
            }
            // Begin moving a shape.
            else if (currentMode == MOVE)
            {
                isMovingShape = true;
            }
            // Begin scaling a shape.
            else if (currentMode == SCALE)
            {
                isScalingShape = true;
                selectedShape.SetScaling(true);
            }
        }

        // Handler for rubber-banding mouse up.
        private void MouseReleased(object sender, MouseEventArgs e)
        {
            // Finish drawing a shape, add to the list.
            if (currentMode == DRAW)
            {
                isDrawingShape = false;
                AddShapeToCombo(drawnShape);
                shapes.Add(drawnShape);
                drawnShape = null;
            }
            // Finish moving a shape.
            else if (currentMode == MOVE)
            {
                isMovingShape = false;
            }
            // Finish scaling a shape.
            else if (currentMode == SCALE)
            {
                isScalingShape = false;
                selectedShape.SetScaling(false);
            }
        }

        // Request a refresh of the canvas display automatically
        // by invalidating it.
        private void UpdateCanvas(object sender, EventArgs e)
        {
            canvas.Invalidate();
        }

        // Use a double buffer to reduce the flickering of shapes
        // whilst they are being repainted. This method provides
        // the visual ability for "rubber-banding" using a mouse.
        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            // Prepare both buffers.
            Graphics frontBuffer = e.Graphics;
            Graphics backBuffer = Graphics.FromImage(backBufferBitmap);

            // Cache mouse position on canvas for repeated use.
            Point canvasMouse = canvas.PointToClient(MousePosition);

            // Display each shape
            foreach (Shape shape in shapes)
            {
                // Use custom draw methods to connect shape vertices.
                shape.Draw(backBuffer, penColour);

                // Use library draw methods to display UI circles over vertices
                // for easier visual aid to the user.
                shape.DrawUI(backBuffer);
            }

            // Display a shape being drawn whilst the mouse is down.
            if (isDrawingShape)
            {
                drawnShape.UpdateSecondPoint(canvasMouse);
                drawnShape.Draw(backBuffer, penColour);
            }

            // These operations require a shape to be selected.
            if (selectedShape != null)
            {
                // Highlight the select shape for visual identificaion
                // for the user.
                selectedShape.Draw(backBuffer, highlightColour);

                // Proces the move operation on the mouse position.
                if (isMovingShape) selectedShape.Move(canvasMouse);

                // Proces the scale operation on the mouse position.
                if (isScalingShape) selectedShape.Scale(selectedShape.GetScaleFactor(canvasMouse));

            }

            // Finalise the updated canvas by converting the contents
            // of the back buffer to the front buffer all at once, then
            // clear the back buffer to free memory.
            frontBuffer.DrawImage(backBufferBitmap, 0, 0);
            backBuffer.Clear(canvasColour);
        }

        // Button handler to select a shape via the mouse.
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            UpdateActiveButton((Button)sender);
            SetMode(SELECT);
            drawingSquare = false;
            drawingTriangle = false;
            drawingCircle = false;
        }

        // Button handler to move a shape via the mouse.
        private void buttonMove_Click(object sender, EventArgs e)
        {
            UpdateActiveButton((Button)sender);
            SetMode(MOVE);
        }

        // Button handler to create a square via the mouse.
        private void buttonCreateSquare_Click(object sender, EventArgs e)
        {
            UpdateActiveButton((Button)sender);
            SetMode(DRAW);
            drawingSquare = true;
            drawingTriangle = false;
            drawingCircle = false;
        }

        // Button handler to create a triangle via the mouse.
        private void buttonCreateTriangle_Click(object sender, EventArgs e)
        {
            UpdateActiveButton((Button)sender);
            SetMode(DRAW);
            drawingSquare = false;
            drawingTriangle = true;
            drawingCircle = false;
        }

        // Button handler to create a circle via the mouse.
        private void buttonCreateCircle_Click(object sender, EventArgs e)
        {
            UpdateActiveButton((Button)sender);
            SetMode(DRAW);
            drawingSquare = false;
            drawingTriangle = false;
            drawingCircle = true;
        }

        // Button handler to scale a shape via the mouse.
        private void buttonMouseScale_Click(object sender, EventArgs e)
        {
            UpdateActiveButton((Button)sender);
            SetMode(SCALE);
        }

        // Canvas mouse handler to change the mouse depending on
        // the mode of operation to aid the user in knowing which
        // mouse operation mode they are in.
        private void canvas_MouseEnter(object sender, EventArgs e)
        {
            if (currentMode == DRAW)        canvas.Cursor = Cursors.Cross;
            else if (currentMode == SELECT) canvas.Cursor = Cursors.Default;
            else if (currentMode == MOVE)   canvas.Cursor = Cursors.SizeAll;
            else if (currentMode == SCALE)  canvas.Cursor = Cursors.SizeNWSE;
        }

        // Shape selection box handler when a shape is selected.
        private void comboShapes_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectShape((Shape)comboShapes.SelectedItem);
            UpdateCanvas(sender, e);
        }

        // Colour handler to change the pen colour.
        private void labelPenColour_Click(object sender, EventArgs e)
        {
            colorDialogPen.ShowDialog();
            labelPenColour.BackColor = colorDialogPen.Color;
            penColour.Color = colorDialogPen.Color;
            UpdateCanvas(sender, e);
        }

        // Colour handler to change the canvas colour.
        private void labelCanvasColour_Click(object sender, EventArgs e)
        {
            colorDialogCanvas.ShowDialog();
            labelCanvasColour.BackColor = colorDialogCanvas.Color;
            canvasColour = colorDialogCanvas.Color;
            canvas.BackColor = canvasColour;
            UpdateCanvas(sender, e);
        }

        // Button handler to translate a shape.
        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            selectedShape.Translate((int)numericTranslateX.Value, (int)numericTranslateY.Value);
            UpdateCanvas(sender, e);
        }

        // Button handler to scale a shape.
        private void buttonScale_Click(object sender, EventArgs e)
        {
            selectedShape.SetScaling(true);
            selectedShape.Scale((float)numericScale.Value);
            UpdateCanvas(sender, e);
        }

        // Button handler to rotate a shape.
        private void buttonRotate_Click(object sender, EventArgs e)
        {
            selectedShape.Rotate((double)numericAngle.Value);
            UpdateCanvas(sender, e);
        }

        // Button handler to horizontally flip a shape on the Y axis.
        private void buttonFlipHorz_Click(object sender, EventArgs e)
        {
            selectedShape.FlipHorizontal();
            UpdateCanvas(sender, e);
        }

        // Button handler to vertically flip a shape on the X axis.
        private void buttonFlipVert_Click(object sender, EventArgs e)
        {
            selectedShape.FlipVertical();
            UpdateCanvas(sender, e);
        }

        // Button handler to delete a shape.
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteShape(sender, e);
        }

        // Update the mouse operation mode.
        private void SetMode(int mode)
        {
            drawnShape = null;
            if (mode == DRAW) SelectShape(null);
            if (mode == SELECT) UpdateActiveButton(buttonSelect);

            currentMode = mode;
        }

        // Highlight the active button to aid the user
        // knowning which mouse operation mode they are in.
        private void UpdateActiveButton(Button button)
        {
            buttonSelect.BackColor          = Color.Gainsboro;
            buttonMove.BackColor            = Color.Gainsboro;
            buttonMouseScale.BackColor      = Color.Gainsboro;
            buttonCreateSquare.BackColor    = Color.Gainsboro;
            buttonCreateTriangle.BackColor  = Color.Gainsboro;
            buttonCreateCircle.BackColor    = Color.Gainsboro;

            button.BackColor = SystemColors.MenuHighlight;
        }
    }
}


