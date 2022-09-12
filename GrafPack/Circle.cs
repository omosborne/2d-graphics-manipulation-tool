using System;
using System.Drawing;

namespace GrafPack
{
    /// <summary>
    /// The Circle class is a concrete implementation of the Shape
    /// class and provides methods to draw and calculate vertices
    /// specific to a circle using the Bresenham Circle Drawing Algorithm.
    /// </summary>
    class Circle : Shape
    {
        // Object properties.
        private int radius;

        // Constructor.
        public Circle(Point centre)
        {
            vertices        = new Point[1];
            centrePoint     = centre;
            vertices[0]     = centre;

            CalculateRadius();
        }

        // Radius of the circle, the distance between the centre
        // and outer vertex.
        private void CalculateRadius()
        {
            // Euclidean Distance Forumla
            radius = (int)Math.Sqrt(Math.Pow(vertices[0].X - centrePoint.X, 2) + Math.Pow(vertices[0].Y - centrePoint.Y, 2));
        }

        // Draw implementation using the Bresenham Circle Drawing
        // Algorithm to place each pixel in an octant, where it moves
        // to the next closest point from the radius to the centre.
        public override void Draw(Graphics g, Pen penColour)
        {
            // Only recalculate the radius when scaling the circle.
            if (isScaling) CalculateRadius();

            // Assign algorithm-specific values.
            int pX = 0;                 // X of pixel to place.
            int pY = radius;            // Y of pixel to place.
            int d = 3 - (2 * radius);   // Decision parameter.
            int oX = centrePoint.X;     // X of origin (centre) point.
            int oY = centrePoint.Y;     // Y of origin (centre) point.

            // Loop for the complete circle.
            while (pX <= pY)
            {
                // Draw 8 pixels in the symetric-octant.
                DrawPixel(g, penColour, pX + oX, pY + oY);
                DrawPixel(g, penColour, pY + oX, pX + oY);
                DrawPixel(g, penColour, pY + oX, -pX + oY);
                DrawPixel(g, penColour, pX + oX, -pY + oY);
                DrawPixel(g, penColour, -pX + oX, -pY + oY);
                DrawPixel(g, penColour, -pY + oX, -pX + oY);
                DrawPixel(g, penColour, -pY + oX, pX + oY);
                DrawPixel(g, penColour, -pX + oX, pY + oY);

                // Identify next pixel area. 
                if (d <= 0) d += 4 * pX + 6;
                else
                {
                    d += 4 * (pX - pY) + 10;
                    pY--;
                }
                pX++;
            }
        }

        // Display an individual pixel at the specified point.
        private void DrawPixel(Graphics g, Pen penColour, int x, int y)
        {
            Brush aBrush = new SolidBrush(penColour.Color);
            g.FillRectangle(aBrush, x, y, 1, 1);
        }

        // Update the centre and outer points to reflect the new position.
        public override void Move(Point newLocation)
        {
            centrePoint = newLocation;
            vertices[0].X = centrePoint.X;
            vertices[0].Y = centrePoint.Y - radius;
        }

        // Recalculate the radius when the circle is updated.
        public override void UpdateSecondPoint(Point newLocation)
        {
            vertices[0] = newLocation;
            CalculateRadius();
        }

        // Translate the centre point and update the outer point.
        public override void Translate(int distanceX, int distanceY)
        {
            centrePoint.X += distanceX;
            centrePoint.Y += distanceY;
            vertices[0].X = centrePoint.X;
            vertices[0].Y = centrePoint.Y - radius;
        }

        // Display the class name for the shape selection box.
        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
