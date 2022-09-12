using System.Drawing;

namespace GrafPack
{
    /// <summary>
    /// The Triangle class is a concrete implementation of the Shape
    /// class and provides methods to draw and calculate vertices
    /// specific to a triangle.
    /// </summary>
    class Triangle : Shape
    {
        // Object properties.
        private int differenceX;
        private int differenceY;
        private float midpointX;
        private float midpointY;

        // Constructor.
        public Triangle(Point firstPoint)
        {
            vertices       = new Point[3];
            vertices[0]    = firstPoint;
            vertices[2]    = firstPoint;

            CalculateDifference();
        }

        // Difference between the first and opposite points.
        private void CalculateDifference()
        {
            differenceX = vertices[2].X - vertices[0].X;
            differenceY = vertices[2].Y - vertices[0].Y;
        }

        // Point at the centre of the triangle.
        private void CalculateCentrePoint()
        {
            centrePoint.X = (vertices[0].X + vertices[1].X + vertices[2].X) / 3;
            centrePoint.Y = (vertices[0].Y + vertices[1].Y + vertices[2].Y) / 3;
        }

        // Point at the middle between the first and opposite points.
        private void CalculateMidpoint()
        {
            midpointX = (vertices[2].X + vertices[0].X) / 2;
            midpointY = (vertices[2].Y + vertices[0].Y) / 2;
        }

        // Custom draw implementation using fundemental operations
        // for drawing a line between each point of the triangle.
        public override void Draw(Graphics g, Pen penColour)
        {
            // Collect values needed to allocated the last vertex.
            CalculateMidpoint();
            CalculateDifference();

            // Assign the last remaining vertex.
            vertices[1] = new Point((int)(midpointX + differenceY / 2), (int)(midpointY - differenceX / 2));

            // Draw the lines between each vertex.
            g.DrawLine(penColour, vertices[0], vertices[1]);
            g.DrawLine(penColour, vertices[1], vertices[2]);
            g.DrawLine(penColour, vertices[2], vertices[0]);

            // Collect the centre point needed for transformations.
            CalculateCentrePoint();
        }

        // Update the first and opposite corners to reflect the new position.
        public override void Move(Point newLocation)
        {
            vertices[0] = newLocation;
            vertices[2] = new Point(newLocation.X + differenceX, newLocation.Y + differenceY);
        }

        // Display the class name for the shape selection box.
        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
